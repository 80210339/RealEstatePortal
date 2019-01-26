using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstatePortal.Models
{
    public class Property
    {
        public int PropertyID { get; set; }
        public string PropertyName { get; set; }
        public string PropertyType { get; set; }           //detacted, semi, terraced, flat, bugalow, land, park home
        public int NumberOfBedroom { get; set; }
        public int NumberOfBathrooms { get; set; }
        public int AddressID { get; set; }
        public int Propertylocation { get; set; }       // Maybe lat/long. google maps, etc
        public int PropertyDescription { get; set; }
        public int PropertyFacilities { get; set; }     // could be a binary bit map
                                                        // (1) Garden, (2) Parking, (4) Garage, (8) Downstairs toliet (16) GAS CENTRAL HEATING
                                                        // (32) UPVC DOUBLE GLAZING

        public Address Address { get; set; }
        public FloorPlans FloorPlans { get; set; }
    }
}
