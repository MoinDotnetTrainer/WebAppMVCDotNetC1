using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Models
{
    public class Orders
    {
        [Key] // pk , Auto
        public int OrderID { get; set; }
        public string Name { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int Qty { get; set; }
    }
}
