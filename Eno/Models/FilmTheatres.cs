using System.ComponentModel.DataAnnotations;

namespace Eno.Models
{
    public class FilmTheatres
    {
        [Key]
        public int Id { get; set; }
        public virtual Films Film {get; set;}

        public int FilmId { get; set; }
        public virtual Theatres Theatre { get; set;}
        public int TheatreId { get; set; }

        public DateTime ShowDate { get; set; }

        public FilmTheatres()
        {
           

        }
    }
}
