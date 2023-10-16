using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tzclean
{
    public class Patient
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; private set; }
        public int GenderId { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public Patient(string name, DateTime bd, int genderId, string phone, string address)
        {
            Name = name;
            BirthDate = bd;
            GenderId = genderId;
            PhoneNumber = phone;
            Address = address;
        }
    }
}
