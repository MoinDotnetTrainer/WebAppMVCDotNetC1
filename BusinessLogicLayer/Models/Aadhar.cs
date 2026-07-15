using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Models
{
    public class Aadhar
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime Dob { get; set; }
        public Pan _pan { get; set; }  // navigation
    }

    public class Pan
    {
        [Key]
        public int ID { get; set; }
        public string PanUserName { get; set; }
        public string PanNo { get; set; }

        // navigation key
        public int AadharID { get; set; } // fk
        public Aadhar _Aadhar { get; set; }  // navigation

    }
    public class Aadhar1
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime Dob { get; set; }
    }

    public class Pan1
    {
        [Key]
        public int ID { get; set; }
        public int PanUserName { get; set; }
        public int PanNo { get; set; }

        // navigation key
        public int AadharID { get; set; } // fk


    }

}
