using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstatePortal
{
    public class Agent
    {
        public int AgentID { get; set; }
        public string AgentloginID { get; set; }
        public string AgentPassword { get; set; }
        public string AgentFirstMidName { get; set; }
        public string AgentLastName { get; set; }
        public string AgentCompanyName { get; set; }
        public int AddressID { get; set; }
        public int ContactDetailsID { get; set; }
        public int OfficeID { get; set; }            
        public DateTime AccountCreationDate { get; set; }
        public string AgentPermissionLevel { get; set; }         //in reality or the actors shoudl be in one table with this 
                                                            //public string UserType { get; set; }             //and the userType, with passwords, etc, etc

        public Models.Address Address { get; set; }
        public Models.ContactDetails ContactDetails { get; set; }

        public ICollection<Models.AgentPropertyBuyerSeller> AgentPropertyBuyerSeller { get; set; }

    }
}
