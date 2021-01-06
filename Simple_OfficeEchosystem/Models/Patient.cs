using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_OfficeEchosystem.Models
{
    public class Patient
    {
        private string name1;

        public string Getname()
        {
            return name1;
        }

        public void Setname(string value)
        {
            name1 = value;
        }

        private string family1;

        public string Getfamily()
        {
            return family1;
        }

        public void Setfamily(string value)
        {
            family1 = value;
        }

        private string sickness1;

        public string Getsickness()
        {
            return sickness1;
        }

        public void Setsickness(string value)
        {
            sickness1 = value;
        }

        private int thisYear = DateTime.Today.Year;
        private int dateofbirth1;

        public int GetAge()
        {

            return thisYear-dateofbirth1;
        }

        public void Setdateofbirth(int value)
        {
            dateofbirth1 = value;
        }
    }
}
