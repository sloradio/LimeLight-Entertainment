using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace limelightRecords.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }
        public string ArtistName { get; set; }
        public string ArtistLocation { get; set; }
        public string ArtistGenre { get; set; }
        public DateTime SignDate { get; set; }
        public double BookCost { get; set; }
        public string CurrentlyAvailable { get; set; }
        public int AgentID { get; set; }


        public virtual ICollection<Band> Bands { get; set; }
        public virtual ICollection<Tour> Tours { get; set; }
    }
}

