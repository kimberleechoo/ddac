using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MaesrkLine.Models
{
    public class Vessels
    {
        public int ID { get; set; }

        [Display (Name = "Vessel Name")]
        [Required]
        [StringLength(50)]
        public string VesselName { get; set; }


        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        [Display(Name="Departure Date")]
        [DataType(DataType.Date)]
        public DateTime VesselDeparture { get; set; }

        [Display(Name = "Departing From")]
        [Required]
        [StringLength(50)]
        public string DepartureFrom { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        [Display(Name = "Arrival Date")]
        [DataType(DataType.Date)]
        public DateTime VesselArrival { get; set; }

        [Display(Name = "Arriving To")]
        [Required]
        [StringLength(50)]
        public string ArrivingTo { get; set; }

    }
}