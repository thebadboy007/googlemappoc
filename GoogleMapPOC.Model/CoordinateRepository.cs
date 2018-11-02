using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMapPOC.Model
{
    public class CoordinateRepository : ICoordinateRepository
    {
        private GooglemapContext _context;
        public CoordinateRepository(GooglemapContext context)
        {
            this._context = context;
        }
        public void CreateCoordinate(Coordinates coordinates)
        {
            _context.Coordinates.Add(coordinates);
            Save();
        }

        public Coordinates GetCoordinates(int id)
        {
            return _context.Coordinates.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Coordinates> GetCoordinates()
        {
            return _context.Coordinates.ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
