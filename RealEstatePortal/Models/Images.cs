using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RealEstatePortal.Models
{
    public class Images                                     // This will be for any images, floorplan, rooms, etc
    {
        public int ImagesID { get; set; }
        //public Image Picture { get; set; }
        public int PictureType { get; set; }
        public int PictureLablel { get; set; }
        public DateTime PictureUploadDate { get; set; }
        public String PictureFileLocation { get; set; } // included file path incase usnable to save to database 
                                                        // due you best practice, easy of uses, size limitation 
                                                        // or converting from image type to BLOB/VARBINARY for the database ???


        //commnet out "public Image Picture { get; set; }" as was getting the follwoing error below
        //1>------ Build started: Project: RealEstatePortal, Configuration: Debug Any CPU ------
        //1>Models\Images.cs(12,32,12,35): error CS0722: 'MediaTypeNames.Image': static types cannot be used as return types
        //1>Models\Images.cs(12,37,12,40): error CS0721: 'MediaTypeNames.Image': static types cannot be used as parameters
        //1>Done building project "RealEstatePortal.csproj" -- FAILED.
        //========== Build: 0 succeeded, 1 failed, 0 up-to-date, 0 skipped ==========
    }
}
