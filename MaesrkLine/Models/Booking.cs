using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MaesrkLine.Models
{
    public class Booking
    {
        public int ID { get; set; }

        [Display(Name = "Customer Name")]
        [Required]
        [StringLength(50)]
        public string CustomerName { get; set; }

        [Display(Name = "Customer Email")]
        [Required]
        [StringLength(50)]
        public string CustomerEmail { get; set; }


        [Display(Name = "Phone Number")]
        [Required]
        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Container Type: Dry/Refrigerated/Special")]
        [Required]
        [StringLength(50)]
        public string ContainerType { get; set; }

        [Display(Name = "Container Size: 10/20/40ft")]
        [Required]
        [StringLength(50)]
        public string ContainerSize { get; set; }


        public Vessels VesselsInformation { get; set; }
        public string VesselName { get; set; }


    }
}