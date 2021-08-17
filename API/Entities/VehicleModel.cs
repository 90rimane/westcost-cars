


using System.Collections.Generic;

namespace API.Entities
{
    public class VehicleModel
    {
        public int Id { get; set; }
        public string Description { get; set; }

        //navigation egenskap
        public ICollection<Vehicle> Vehicle { get; set; }
    }
}