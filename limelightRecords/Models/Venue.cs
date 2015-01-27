using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace limelightRecords.Models
{
    public class Venue
    {
        public int VenueID { get; set; }
        public string VenueName { get; set; }
        public string VenueLocation { get; set; }
        public string VenueDescription { get; set; }
        public string VenueContact { get; set; }
        public long PhoneNumber { get; set; }


        public virtual ICollection<Show> Shows { get; set; }
    }
}