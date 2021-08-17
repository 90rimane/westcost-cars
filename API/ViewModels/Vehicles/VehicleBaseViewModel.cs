using System.ComponentModel.DataAnnotations;

namespace API.ViewModels
{
    public class VehicleBaseViewModel
    {
        [Required]
        public string RegNumber { get; set; }
    }
}