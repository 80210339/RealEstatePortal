﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstatePortal.Models
{
    public class FloorPlans
    {
        public int FloorPlansID { get; set; }
        public int PropetyID { get; set; }
        public int FloorPlanLevel { get; set; }     // Basement, Ground, First (Might be the same as the the label below?)
        public int FloorPlanLabel { get; set; }     // First Floor, Front Graden, Back Garden, Garage 
        public int ImagesID { get; set; }

        public Rooms Rooms { get; set; }
        public Images Images { get; set; }

        public ICollection<AgentPropertyBuyerSeller> AgentPropertyBuyerSeller { get; set; }

    }
}
