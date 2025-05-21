using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung.Model
{
    [Table("Table5_EuroStandard")]
    public class EuroNorm
    {
        public int ID { get; set; }
        public string EuroStandard { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? EditedAt { get; set;}
        public DateTime? DeletedAt { get; set; }
    }
}
