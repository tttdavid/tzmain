using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace tzclean
{
    public partial class AddForm : Form
    {
        public Patient returnValue = null;
        public AddForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string firstname = addName.Text;
            string secondname = add2Name.Text;
            DateTime birthDate = addDate.Value;
            int genderId = addGender.SelectedIndex;
            string number = addPhone.Text;
            string address = addAddress.Text;

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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ErrMessage()
        {
            MessageBox.Show("არასწორი მონაცემები!");
        }
    }
}
