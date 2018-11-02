using GoogleMapPOC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoogleMapPOC.Controllers
{
    public class CoordinatesController : Controller
    {
        private readonly ICoordinateRepository _repository;
        public CoordinatesController()
        {
            this._repository = new CoordinateRepository(new GooglemapContext());
        }
        // GET: Coordinates
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateCoordinate()
        {
            string markers = "[";
            var sdr = _repository.GetCoordinates();
            foreach (var s in sdr)
            {
                markers += "{";
                markers += string.Format("'lat': '{0}',", s.Latitude);
                markers += string.Format("'lng': '{0}',", s.Longitude);
                markers += "},";

            }
            markers += "];";
            ViewBag.Marker = markers;
            return View();
        }

        [HttpPost]
        public ActionResult CreateCoordinate(Coordinates coordinates)
        {
            if (ModelState.IsValid)
            {
                _repository.CreateCoordinate(coordinates);
                return Json(new { success = true });
            }
            else
            {

            }
            return RedirectToAction("CreateCoordinate");
        }
    }
}