using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS2
{
    class Staff
    {
        private int id { get; set; }
        public  String  Fname { get; set; }
        private String Lname { get; set; }
        private DateTime BirthDate { get; set; }
        private DateTime HireDate { get; set; }
        

        public Staff(String fname ,String lname)
        {
            Fname = fname;
            Lname = lname;
            HireDate = System.DateTime.Now;
        }
        public Staff(String fname, String lname,DateTime birthdate)
        {
            Fname = fname;
            Lname = lname;
            HireDate = System.DateTime.Now;
            BirthDate = birthdate;
        }

        

    }
}
