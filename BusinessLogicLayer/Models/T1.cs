using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Models
{
    public class T1
    {
        [Key]
        public int ID { get; set; }
        public int Name { get; set; }

        public T2? T2Data { get; set; }
    }

    public class T2
    {
        [Key]
        public int ID { get; set; }

        public int Email { get; set; }

        public int T1ID { get; set; }
        public T1? T1Data { get; set; }



    }

    public class T3
    {
        [Key]
        public int ID { get; set; }
        public int Name { get; set; }

        public T4? T4Data { get; set; }
    }

    public class T4
    {
        [Key]
        public int ID { get; set; }

        public int Email { get; set; }

        [ForeignKey("abovetable")]
        public T3? T3Data { get; set; }



    }
}
