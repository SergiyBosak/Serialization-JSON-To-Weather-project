using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Serialization_JSON
{
    public class LocationContext : DbContext
    {
        public LocationContext() : base("DBLocations")
        {

        }

        public DbSet<Location> Locations { get; set; }
    }
}
