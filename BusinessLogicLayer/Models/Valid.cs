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
    [Table("UserTable")]
    [Index(nameof(Email), IsUnique = true)]
    [Index(nameof(Mobile))]
    public class Valid
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z]+$")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        [NotMapped]
        public string ConfirmPassword { get; set; }

        [Range(18, 60)]
        public int Age { get; set; }

        [RegularExpression("^[0-9]+$")]
        public string Mobile { get; set; }


        [MaxLength(100)]
        public string Address { get; set; }

        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }
    }
}
