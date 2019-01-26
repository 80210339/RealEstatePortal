using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstatePortal.Models
{
    public class Address
    {
        public string AddressID { get; set; }
        public string PersonID { get; set; }    // ID of Seller, Buyer, Agent, Office/Business
        public string AddressType { get; set; }
        public string Build { get; set; }
        public string Street { get; set; }
        public string Locality { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
    }
}
