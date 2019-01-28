using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstatePortal.Models
{
    public class Buyer
    {
        public int BuyerID { get; set; }
        public string BuyerloginID { get; set; }
        public string BuyerPassword { get; set; }
        public string BuyerFirstMidName { get; set; }
        public string BuyerLastName { get; set; }
        public string BuyerCompanyName { get; set; }
        public int AddressID { get; set; }
        public int ContactDetailsID { get; set; }
        public DateTime AccountCreationDate { get; set; }
        public string BuyerPermissionLevel { get; set; }         //in reality or the actors shoudl be in one table with this 
                                                            //public string UserType { get; set; }             //and the userType, with passwords, etc, etc


        public Address Address { get; set; }
        public ContactDetails ContactDetails { get; set; }

       // public ICollection<AgentPropertyBuyerSeller> AgentPropertyBuyerSeller { get; set; }
    }
}
