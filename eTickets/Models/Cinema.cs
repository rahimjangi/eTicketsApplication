using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema : Base
    {
        [Display(Name ="Logo")]
        public string LogoUrl { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }

        public List<Movie>  Movies{ get; set; }
    }
}
