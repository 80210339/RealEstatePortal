using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstatePortal.Models
{
    public class FloorPlan
    {
        public int FloorPlanID { get; set; }
        public int PropetyID { get; set; }
        public int FloorPlanLevel { get; set; }     // Basement, Ground, First (Might be the same as the the label below?)
        public string FloorPlanLabel { get; set; }     // First Floor, Front Graden, Back Garden, Garage 
        public int ImagesID { get; set; }

        public Room Room { get; set; }
        public Images Images { get; set; }

        public ICollection<Property> Property { get; set; }
        //public ICollection<AgentPropertyBuyerSeller> AgentPropertyBuyerSeller { get; set; }

    }
}
