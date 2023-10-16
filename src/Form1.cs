using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tzclean
{
    public partial class mainWindows : Form
    {
        public mainWindows()
        {
            InitializeComponent();
        }

        private void mainWindows_Load(object sender, EventArgs e)
        {
            RefreshGrid();

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (AddForm form = new AddForm())
            {
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    InsertInDb(form.returnValue);
                }
            }
            RefreshGrid();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int id = GetId();
            using (EditForm form = new EditForm(SelectById(id)))
            {
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    EditById(id, form.returnValue);
                }
            }
            RefreshGrid();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int id = GetId();

            var confirmResult = MessageBox.Show("გსურთ მონიშნული ჩანაწერის წაშლა?",
                                     "ოპერაციის დასტური",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                DeleteById(id);
                RefreshGrid();
            }
            else
            {
                return;
            }
        }

        private int GetId()
        {
            if (mainGrid.SelectedRows.Count > 0)
                return int.Parse(mainGrid.SelectedRows[0].Cells[0].Value.ToString());
            else
                return 0;
        }

        private void RefreshGrid()
        {
            this.patientsTableAdapter.Fill(this.tzDataSet.Patients);
        }

        private void InsertInDb(Patient patient)
        {
            Patient pat = patient;
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-PBNEOV6;Initial Catalog=tz;Integrated Security=True"))
            {
                con.Open();
                string sqlQuery = "INSERT INTO Patients (FullName, Dob, GenderID, Phone, Address) " +
                     "VALUES (@Value1, @Value2, @Value3, @Value4, @Value5)";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Value1", pat.Name);
                    cmd.Parameters.AddWithValue("@Value2", pat.BirthDate);
                    cmd.Parameters.AddWithValue("@Value3", pat.GenderId);
                    cmd.Parameters.AddWithValue("@Value4", pat.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Value5", pat.Address);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private Patient SelectById(int id)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-PBNEOV6;Initial Catalog=tz;Integrated Security=True"))
            {
                con.Open();
                string sqlQuery = "SELECT * FROM Patients WHERE ID = @IdValue";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                {
                    cmd.Parameters.AddWithValue("@IdValue", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string name = reader["FullName"].ToString();
                            DateTime dob = (DateTime)reader["Dob"];
                            int genderId = int.Parse(reader["GenderID"].ToString());
                            string number = reader["Phone"].ToString();
                            string address = reader["Address"].ToString();

                            var user = new Patient(name, dob, genderId, number, address);
                            return user;
                        }
                    }
                }
            }
            return null;
        }

        private void EditById(int id, Patient patient)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-PBNEOV6;Initial Catalog=tz;Integrated Security=True"))
            {
                con.Open();
                string updateQuery = "UPDATE Patients SET FullName = @Name, Dob = @BirthDate, GenderID = @GenderId, Phone = @Phone, Address = @Address WHERE ID = @Id";
                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    cmd.Parameters.AddWithValue("@Name", patient.Name);
                    cmd.Parameters.AddWithValue("@BirthDate", patient.BirthDate);
                    cmd.Parameters.AddWithValue("@GenderID", patient.GenderId);
                    cmd.Parameters.AddWithValue("@Phone", patient.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Address", patient.Address);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void DeleteById(int id)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-PBNEOV6;Initial Catalog=tz;Integrated Security=True"))
            {
                con.Open();
                string sqlQuery = "DELETE FROM Patients WHERE ID = @IdValue";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                {
                    cmd.Parameters.AddWithValue("@IdValue", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
