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
        string cs = "Data Source=DESKTOP-PBNEOV6;Initial Catalog=tz;Integrated Security=True";
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
            using (AddEditForm form = new AddEditForm())
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
            using (AddEditForm form = new AddEditForm(SelectById(id)))
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
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("InsertPatient", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@FullName", patient.Name);
                    cmd.Parameters.AddWithValue("@Dob", patient.BirthDate);
                    cmd.Parameters.AddWithValue("@GenderID", patient.GenderId);
                    cmd.Parameters.AddWithValue("@Phone", patient.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Address", patient.Address);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private Patient SelectById(int id)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GetPatientById", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string name = reader["FullName"].ToString();
                            DateTime dob = (DateTime)reader["Dob"];
                            int genderId = int.Parse(reader["GenderID"].ToString());
                            string number = reader["Phone"].ToString();
                            string address = reader["Address"].ToString();

                            var patient = new Patient(name, dob, genderId, number, address);
                            return patient;
                        }
                    }
                }
            }
            return null;
        }

        private void EditById(int id, Patient patient)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("UpdatePatient", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@FullName", patient.Name);
                    cmd.Parameters.AddWithValue("@Dob", patient.BirthDate);
                    cmd.Parameters.AddWithValue("@GenderID", patient.GenderId);
                    cmd.Parameters.AddWithValue("@Phone", patient.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Address", patient.Address);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void DeleteById(int id)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("DeletePatientById", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Id", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
