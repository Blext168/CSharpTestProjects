using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung.Model
{
    [Table("Table4_Painting")]
    public class Paint
    {
        public int ID { get; set; }
        public string Painting { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? EditedAt { get; set;}
        public DateTime? DeletedAt { get; set; }
    }
}
