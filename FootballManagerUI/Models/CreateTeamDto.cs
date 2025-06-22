using System.ComponentModel.DataAnnotations;

namespace FootballManagerUI.Models
{
    public class CreateTeamDto
    {
        [Required(ErrorMessage = "Team name is required.")]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "City is required.")]
        [MaxLength(100)]
        public string City { get; set; }
    }
}
