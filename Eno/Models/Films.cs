namespace Eno.Models
{
    public class Films
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PublishDate { get; set; }

        public virtual ICollection<FilmTheatres>? FilmTheatres { get; set; }
        public Films()
        {

        }

    }
}
