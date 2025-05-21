using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung.Model
{
    [Table("Table3_FuelTypes")]
    public class Fuel
    {
        public int Id { get; set; }
        public string FuelTypes { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? EditedAt { get; set;}
        public DateTime? DeletedAt { get; set; }
    }
}
