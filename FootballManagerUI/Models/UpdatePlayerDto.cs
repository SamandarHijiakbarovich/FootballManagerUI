﻿using FootballManagerUI.Enums;
using System.ComponentModel.DataAnnotations;

namespace FootballManagerUI.Models
{
    public class UpdatePlayerDto
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [Range(1, 99)]
        public int ShirtNumber { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public int TeamId { get; set; }

        [Required]
        public Position Position { get; set; }
    }
}
