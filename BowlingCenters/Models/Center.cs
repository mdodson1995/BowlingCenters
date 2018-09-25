using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BowlingCenters.Models
{
    public class Center
    {
        [Key]
        [Display(Name = "Location ID")]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Location")]
        public string locationName { get; set; }

        [Required]
        [Display(Name = "Street Address")]
        public string locationAddress { get; set; }

        [Required]
        [Display(Name = "City")]
        public string locationCity { get; set; }

        [Required]
        [Display(Name = "State")]
        [MaxLength(2, ErrorMessage = "Must be 2 characters.")]
        public string locationState { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        [MaxLength(5, ErrorMessage = "Must be 5 characters.")]
        public string locationZipCode { get; set; }
    }
}