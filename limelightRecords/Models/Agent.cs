using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace limelightRecords.Models
{
    public class Agent
    {
        public int AgentID { get; set; }
        public string AgentName { get; set; }
        public string AgentLocation { get; set; }
        public string AgentLabel { get; set; }

        public virtual ICollection<Artist> Artists { get; set; }
    }
}