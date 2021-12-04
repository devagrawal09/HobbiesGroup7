using System.ComponentModel.DataAnnotations;

namespace HobbiesGroup7.Models
{
    public class TeamMember
    {
        public int TeamMemberId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }

        public string Bio { get; set; }

        [Display(Name = "Hobby Title")]
        public string HobbyTitle { get; set; }

        [Display(Name = "Hobby Description")]
        public string HobbyDescription { get; set; }
    }
}
