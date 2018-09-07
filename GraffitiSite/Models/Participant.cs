using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GraffitiSite.Models
{
    public class Participant
    {
        [Display(Name="First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Display(Name = "Division")]
        public int DivisionID { get; set; }

        [Display(Name = "Team Name")]
        public string TeamName { get; set; }

        [Display(Name = "Grade")]
        public int Grade { get; set; }
    }
}