using freightLution.Model.Cache;
using freightLution.Model.Enums;
using RouteCalculations.Enum;
using System;

namespace RouteCalculations.Controls.ViewModel
{
    public class EmissionViewModel
    {
        public int Id { get; set; }
        public int TransportId { get; set; }
        public DateTime TransportStartDay { get; set; }
        public DateTime TransportEndDay { get; set; }
        public decimal TransportDistance { get; set; }
        public enmTransportStatus TransportStatus { get; set; }
        public DateTime TransportCreatedAt { get; set; }
        public int TransportCreatedBy { get; set; }
        public DateTime TransportEditedAt { get; set; }
        public int TransportEditedBy { get; set; }
        public TransportOriginEnum TransportOrigin { get; set; }
        public double ElectricityConsumption { get; set; }
        public double FuelConsumption { get; set; }
        public double AverageFuelConsumption { get; set; }
        public double Co2eTankToWheel { get; set; }
        public double Co2eWellToWheel { get; set; }
        public double EnergyTankToWheel { get; set; }
        public double EnergyWellToWheel { get; set; }
        public DateTime CalculatedAt { get; set; } = DateTime.Now;
        public int CalculatedBy { get; set; } = UserCache.User.Id;
        public CalculationOptionsEnum Property { get; set; } = CalculationOptionsEnum.PTV;
        public int CalculationVehicleProfileId { get; set; }
    }
}
