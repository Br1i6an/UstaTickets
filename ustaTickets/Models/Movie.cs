using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ustaTickets.Data.Enum;

namespace ustaTickets.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        [Display(Name = "Movie Name")]
        public string Description { get; set; }
        [Display(Name = "Movie Price")]
        public double Price { get; set; }
        [Display(Name = "Movie Image")]
        public string ImageURL { get; set; }
        [Display(Name = "Movie StartDate")]
        public DateTime StartTime { get; set; }
        [Display(Name = "Movie EndTime")]
        public DateTime EndTime { get; set; }
        [Display(Name = "Movie Category")]
        public MovieCategory MovieCategory { get; set; }

        //Relationships

        public List<Actor_Movie> Actor_Movies { get; set; }

        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        public int DirectorId { get; set; }
        [ForeignKey("DirectorId")]
        public Director Director { get; set; }


    }
}
