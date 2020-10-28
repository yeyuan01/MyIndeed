using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyIndeed.Models
{
    public class Job
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public bool RecentGraduate { get; set; }
        [Required]
        [Display(Name = "Min year requirement")]
        public int Year { get; set; }
        public ApplicationUser PostUser { get; set; }
    }
}