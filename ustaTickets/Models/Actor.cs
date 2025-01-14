﻿using System.ComponentModel.DataAnnotations;
namespace ustaTickets.Models
{
    public class Actor
    {
        //Actor ID
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile picture")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string? ProfilePictureURL { get; set; }

        [Display(Name = "FullName")]
        [Required(ErrorMessage = "Full name is required")]
        [StringLength(50, MinimumLength =3, ErrorMessage ="Full name must be between 3 and 50 chars.")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }

        //RelationShip
        public List<Actor_Movie>? Actor_Movies { get; set; }
    }
}
