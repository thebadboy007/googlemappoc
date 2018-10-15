using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMapPOC.Model
{
   public class GooglemapContext:DbContext
    {
        public GooglemapContext():base()
        {

        }
        public virtual DbSet<Place> Places { get; set; }
    }
}
