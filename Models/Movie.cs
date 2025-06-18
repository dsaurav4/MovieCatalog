namespace MovieCatalog.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public required string Title { get; set; }

        public GenreList Genre { get; set; }

        public int ReleaseYear { get; set; }

        public RatingList Rating { get; set; }

        public Movie()
        {
        
        }
    }

    public enum GenreList
    {
        Action,
        Comedy,
        Drama,
        Horror,
        SciFi,
        Romance,
        Documentary
    }

    public enum RatingList
    {
        G,
        PG,
        PG13,
        R,
        NC17
    }
}
