using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstatePortal.Models
{
    public class UserAudit                              // basic Audit use of portal,  
    {                                                   // who, what and when (buyers) are lookingat which properties
        public int UserAuditID { get; set; }                     // who deleted the data???
        public int UserID { get; set; }                 // (seller) what properties did I last look at yesterday?
        public string ActivityType { get; set; }        // who keeps forgetting their password
        public String ActivityAction { get; set; }      // how log are sellers spending on the site???
        public DateTime ActionDate { get; set; }        // have people request more informatio or a viewing???
    }                                                   // etc, etc, etc.


}
