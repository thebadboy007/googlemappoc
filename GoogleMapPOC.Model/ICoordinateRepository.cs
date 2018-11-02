using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMapPOC.Model
{
  public  interface ICoordinateRepository
    {
        void CreateCoordinate(Coordinates coordinates);
        Coordinates GetCoordinates(int id);
        IEnumerable<Coordinates> GetCoordinates();
        void Save();
    }
}
