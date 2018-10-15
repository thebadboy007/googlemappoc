using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMapPOC.Model
{
   public interface IMapRepository
    {
        void CreatePlace(Place place);
        Place GetPlace(int id);
        IEnumerable<Place> GetPlaces();
        void DeletePlace(int id);
        void Save();
        Place UpdatePlace(Place place);
    }
}
