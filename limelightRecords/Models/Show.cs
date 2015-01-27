using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace limelightRecords.Models
{
    public class Show
    {
        public int ShowID { get; set; }
        public string ShowName { get; set; }
        public double ShowCost { get; set; }
        public int VenueID { get; set; }
        public int TourID { get; set; }
        public DateTime ShowDate { get; set; }

        public virtual ICollection<Artist> Artists { get; set; }
    }
}