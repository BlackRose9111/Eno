namespace Eno.Models
{
    public class Theatres
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<FilmTheatres>? FilmTheatres { get; set; }
        public Theatres()
        {

        }
    }
}
