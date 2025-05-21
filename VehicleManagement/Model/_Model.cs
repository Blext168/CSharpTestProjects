using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung.Model
{
    [Table("Table2_Model")]
    public class _Model
    {
        public int Id { get; set; }
        public int Brand { get; set; }
        public string Model { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? EditedAt { get; set; }
        public DateTime? deletedAt { get; set; }
    }
}
