using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung.Model
{
    [Table("Table6_Details")]
    public class Details
    {
        public int ID { get; set; }
        public int Brand { get; set; }
        public int Model { get; set; }
        public int FuelType { get; set; }
        public int Painting { get; set; }
        public int EuroStandards { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? EditedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public double Price { get; set; }
        public int PowerPS { get; set; }
        public string? Color { get; set; }
        public string? Plate { get; set; }
        public DateTime BuildingYear { get; set; }
        public DateTime HU { get; set; }
        public double? Odometer { get; set; }
    }
}
