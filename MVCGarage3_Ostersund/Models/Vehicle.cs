using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCGarage3_Ostersund.Models
{
    public enum VehicleType
    {
        Car,
        Snowmobile,
        Bus,
        Motorcycle,
        Lorry
    };
    
    public class Vehicle
    {
        public int Id { get; set; }
        public string RegNr { get; set; }
        public VehicleType type { get; set; }
    }
}