using System;
using System.ComponentModel.DataAnnotations;

namespace API.ViewModels
{
    public class AddVehicleViewModel : VehicleBaseViewModel
    {
        [Required]
        public string Name { get; set; }
        public string FuelType { get; set; }
        public string GearType { get; set; } 
        [Required(ErrorMessage = "Tillvarkeren saknas!")]
        public string Make { get; set; }
        public int Mileage { get; set; }
        [Required(ErrorMessage = "Modell beteckning saknas!")]
        public string Model { get; set; }
        public int ModelYear { get; set; }
    }
}