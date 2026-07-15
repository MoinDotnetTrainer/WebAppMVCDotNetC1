using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Models
{

    [Table("Tbl_Employees")]
    [Index(nameof(Email), IsUnique = true)]  // non cluster and Unique value
    public class DataAnnotationEx
    {
        [Key] //PK and Auto increment
        public int ID { get; set; }

        [Required(ErrorMessage = "Name Required")]
        [RegularExpression("^[a-zA-Z]+$")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Email Required")]
        [EmailAddress]
        public string Email { get; set; }


        [Required(ErrorMessage = "Password Required")]
        [MinLength(6)]
        public string Password { get; set; }

        [Required(ErrorMessage = "ConfirmPassword Required")]
        [Compare("Password")]
        [NotMapped]
        public string ConfirmPassword { get; set; } // this will not create ain db


        [Required]
        [Range(18,50)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Mobile Required")]

        [RegularExpression("^[0-9]+$")]
        public int Mobile { get; set; }


        [MaxLength(50)]
        public string Address { get; set; }
    }
}
