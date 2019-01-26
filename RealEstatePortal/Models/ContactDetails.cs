using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstatePortal.Models
{
    public class ContactDetails
    {
        public int ContactDetailsID { get; set; }                       
        public int UserID { get; set; }                          // ID of Seller, Buyer, Agent, Office/Business
        public string ContactType { get; set; }
        public string ContactLineline { get; set; }
        public string ContactMobile { get; set; }
        public string ContactFax { get; set; }
        public string ContactEmailAddress { get; set; }
        public string ContactWebsite { get; set; }
        public string ContactFaceBookPage { get; set; }
        public string ContactTwitter { get; set; }
    }
}
