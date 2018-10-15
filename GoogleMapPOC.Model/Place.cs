using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMapPOC.Model
{
    public class Place
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter city name")]
        [Display(Name = "City Name")]
        public string CityName { get; set; }
        [Required(ErrorMessage = "Please enter city latitude")]
        public double Latitude { get; set; }
        [Required(ErrorMessage = "Please enter city longitude ")]
        public double Longitude { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
    }
}
