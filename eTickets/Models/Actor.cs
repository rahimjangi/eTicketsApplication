using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor:Base
    {
        [Display(Name ="Profile Picture URL")]
        [Required(ErrorMessage ="Profile picture is required!")]
        public string ProfilePictureUrl { get; set; }
        [Display(Name ="Full Name")]
        [Required(ErrorMessage ="Name can not be null")]
        [StringLength(50,MinimumLength =5,ErrorMessage ="Full Name should be between 5 and 50 chars")]
        public string FullName { get; set; }
        [Display(Name ="Biography")]
        public string Bio { get; set; }
        public List<Actor_Movie> Actors_Movies{ get; set; }
    }
}
