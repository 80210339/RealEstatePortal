using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstatePortal.Models
{
    public class Seller
    {
        public int SellerID { get; set; }
        public string SellerloginID { get; set; }
        public string SellerPassword { get; set; }
        public string SellerFirstMidName { get; set; }
        public string SellerLastName { get; set; }
        public string SellerCompanyName { get; set; }
        public int SellerAddressID { get; set; }
        public int SellerContactID { get; set; }
        public DateTime AccountCreationDate { get; set; }
        public string SellerPermissionLevel { get; set; }         //in reality or the actors shoudl be in one table with this 
                                                            //public string UserType { get; set; }             //and the userType, with passwords, etc, etc


        public Address Address { get; set; }
        public ContactDetails ContactDetails { get; set; }

        public ICollection<AgentPropertyBuyerSeller> AgentPropertyBuyerSeller { get; set; }
    }

}
