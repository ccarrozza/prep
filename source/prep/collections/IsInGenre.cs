using prep.infrastructure;
using prep.infrastructure.filtering;

namespace prep.collections
{
    public class IsInGenre : IMatchA<Movie>
    {
        Genre genre;

        public IsInGenre(Genre genre)
        {
            this.genre = genre;
        }

        public bool matches(Movie movie)
        {
            return movie.genre == genre;
        }
    }
}