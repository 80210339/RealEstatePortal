using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstatePortal.Models
{
    public class Office
    {
        public int OfficeID { get; set; }       
        public string OfficeName { get; set; }      // JNP - HIgh Wycombe, JNP - Hazelmere, 
        public int OfficeAddressID { get; set; }
        public int OfficeContactID { get; set; }
        public string OfficeCompanyRegNumber { get; set; }
        public string OfficeVatRegNumber { get; set; }


        public Address Address { get; set; }
        public ContactDetails ContactDetails { get; set; }
        public Agent Agent { get; set; }

    }
}
