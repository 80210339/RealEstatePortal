using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstatePortal.Models
{
    public class Room
    {
        public int RoomID { get; set; }
        public int PropertyID { get; set; }
        public int FloorPlanID { get; set; }
        public int RoomPictureID { get; set; }  // ID from images
        public string RoomType { get; set; }
        public string RoomName { get; set; }
        public string RoomLabel { get; set; }
        public string RoomSize { get; set; }

        //public ICollection<Property> Property { get; set; }
        //public ICollection<FloorPlan> FloorPlans { get; set; }
        //public ICollection<Images> Images { get; set; }
    }
}
