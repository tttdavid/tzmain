using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tzclean
{
    public partial class EditForm : Form
    {
        public Patient returnValue = null;
        private Patient patientForEdit;
        public EditForm(Patient patientForEdit)
        {
            InitializeComponent();
            this.patientForEdit = patientForEdit;
        }

        private void editAddButton_Click(object sender, EventArgs e)
        {
            string firstname = editName.Text;
            string secondname = edit2Name.Text;
            DateTime birthDate = editDate.Value;
            int genderId = editGender.SelectedIndex;
            string number = editPhone.Text;
            string address = editAddress.Text;

            if (firstname.Length < 3 || secondname.Length < 3)
            {
                ErrMessage();
                return;
            }
            if (!number.StartsWith("5") || number.Trim().Length != 9)
            {
                ErrMessage();
                return;
            }
            if (address.Length < 5)
            {
                ErrMessage();
                return; 
            }

            string fullname = $"{secondname} {firstname}";
            returnValue = new Patient(fullname, birthDate, genderId, number, address);

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void editCancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void LoadPatient(object sender, EventArgs e)
        {
            string[] name = patientForEdit.Name.Split(' ');
            editName.Text = name[1];
            edit2Name.Text = name[0];
            editPhone.Text = patientForEdit.PhoneNumber;
            editDate.Value = patientForEdit.BirthDate;
            editGender.SelectedIndex = patientForEdit.GenderId;
            editAddress.Text = patientForEdit.Address;
        }

        private void ErrMessage()
        {
            MessageBox.Show("არასწორი მონაცემები!");
        }
    }
}
