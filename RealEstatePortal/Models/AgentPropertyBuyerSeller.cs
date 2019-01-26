using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstatePortal.Models
{
    public enum Relationship
    {
        A,B,S   // Relationship to Property : (A) Agent to Property, (B) Buyer to Property, (S) Seller to Property 
    }

    public class AgentPropertyBuyerSeller
    {
        public int AgentPropertyBuyerSellerID { get; set; }
        public int AgentID { get; set; }
        public int PropertyID { get; set; }
        public int BuyerID { get; set; }
        public int SellerID { get; set; }
        public Relationship REPM_Relationship { get; set; }
    }
}
