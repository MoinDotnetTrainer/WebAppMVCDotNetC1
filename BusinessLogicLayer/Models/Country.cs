using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Models
{
    public class Country
    {
        [Key]
        public int ID { get; set; }
        public string CName { get; set; }
        public ICollection<State> _state { get; set; } // one to many  navigation
    }

    public class State
    {
        [Key]
        public int ID { get; set; }
        public string StateName { get; set; }

        [ForeignKey("CountryID")]  // a new field CountryID will be Created as fk
        public Country _Country { get; set; }
    }
}
