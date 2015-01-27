using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace limelightRecords.Models
{
    public class Tour
    {
        public int TourID { get; set; }
        public string TourName { get; set; }
        public string Continent { get; set; }
        public string TourDescription { get; set; }

        public virtual ICollection<Show> Shows { get; set; }
    }
}