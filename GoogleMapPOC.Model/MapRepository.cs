using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMapPOC.Model
{
    public class MapRepository : IMapRepository
    {
        private GooglemapContext _context;
        public MapRepository(GooglemapContext context)
        {
            this._context = context;
        }
        public void CreatePlace(Place place)
        {
           _context.Places.Add(place);
            Save();
        }

        public void DeletePlace(int id)
        {
            throw new NotImplementedException();
        }

        public Place GetPlace(int id)
        {
            return _context.Places.FirstOrDefault(r => r.ID == id);
        }

        public IEnumerable<Place> GetPlaces()
        {
            return _context.Places.ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public Place UpdatePlace(Place place)
        {
            throw new NotImplementedException();
        }
    }
}
