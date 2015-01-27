using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace limelightRecords.Models
{
    public class Band
    {
        public int BandID { get; set; }
        public string BandName { get; set; }
        public string BandLocation { get; set; }
        public string BandGenre { get; set; }
        public DateTime BandSignDate { get; set; }
        public double BandBookCost { get; set; }
        public string BandAvailable { get; set; }

        public virtual ICollection<Artist> Artists { get; set; }
    }
}