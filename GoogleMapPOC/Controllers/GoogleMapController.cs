using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GoogleMapPOC.Model;

namespace GoogleMapPOC.Controllers
{
    public class GoogleMapController : Controller
    {
        private readonly IMapRepository _repository;
        public GoogleMapController()
        {
            this._repository = new MapRepository(new GooglemapContext());
        }
        // GET: GoogleMap
       // GooglemapContext GooglemapContext = new GooglemapContext();

        public ActionResult Index()
        {
            return View();
        }

        //public JsonResult Location()
        //{

        //    var v = GooglemapContext.Places.OrderBy(a => a.CityName).ToList();
        //    // List<Place> places = GooglemapContext.Places.ToList();


        //    return new JsonResult
        //    {
        //        Data = v,JsonRequestBehavior = JsonRequestBehavior.AllowGet
        //    };
        //}
        
        public ActionResult Location()
        {
            string markers = "[";
            var sdr = _repository.GetPlaces();
            foreach (var s  in sdr)
            {
                markers += "{";
                markers += string.Format("'title': '{0}',", s.CityName);
                markers += string.Format("'lat': '{0}',", s.Latitude);
                markers += string.Format("'lng': '{0}',", s.Longitude);
                markers += string.Format("'description': '{0}',", s.Description);
                markers += string.Format("'type': '{0}',", s.Type);
                markers += "},";
            }
            markers += "];";
            ViewBag.Marker = markers;
            
            return View();
        }


        [HttpPost]
        public ActionResult Location(Place place)
        {
            if (ModelState.IsValid)
            {
                _repository.CreatePlace(place);
            }
            else
            {

            }
            return RedirectToAction("Location");
        }


    }
}
