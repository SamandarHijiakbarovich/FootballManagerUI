using System.ComponentModel.DataAnnotations;

namespace FootballManagerUI.Models
{
    public class CreateMatchDto
    {
        [Required]
        public DateTime MatchDate { get; set; }

        [Required]
        public int HomeTeamId { get; set; }

        [Required]
        public int AwayTeamId { get; set; }
    }
}
