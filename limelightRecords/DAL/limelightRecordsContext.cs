using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace limelightRecords.DAL
{
    public class limelightRecordsContext : System.Data.Entity.DbContext
    {
        public limelightRecordsContext() : base("limelightRecordsContext")
        {
        }
        
        public System.Data.Entity.DbSet<limelightRecords.Models.Artist> Artists { get; set; }
        public System.Data.Entity.DbSet<limelightRecords.Models.Agent> Agents { get; set; }
        public System.Data.Entity.DbSet<limelightRecords.Models.Band> Bands { get; set; }
        public System.Data.Entity.DbSet<limelightRecords.Models.Show> Shows { get; set; }
        public System.Data.Entity.DbSet<limelightRecords.Models.Tour> Tours { get; set; }
        public System.Data.Entity.DbSet<limelightRecords.Models.Venue> Venues { get; set; }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
        }
    }
}