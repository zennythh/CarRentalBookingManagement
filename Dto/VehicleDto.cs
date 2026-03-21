using System;
using System.Diagnostics.Contracts;

namespace VehicleManagementSystem.Dto {
    public class VehicleDto {
        public string VIN { get; set; }
        public string LicensePlate { get; set; }

        // Basic Info
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int YearModel { get; set; }
        public string Color { get; set; }

        // Classification
        public string Category { get; set; }
        public string FuelType { get; set; }
        public string Transmission { get; set; }
        public int? SeatingCapacity { get; set; }

        // Purchase 
        public DateTime PurchaseDate { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal CurrentOdometerReading { get; set; }
        public string CurrentStatus { get; set; }
        public decimal DailyRate { get; set; }

        public string ImagePath { get; set; }

        // System fields
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
