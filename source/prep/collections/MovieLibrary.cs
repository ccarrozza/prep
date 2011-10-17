using System;
using System.Collections.Generic;
using prep.infrastructure;
using prep.infrastructure.filtering;

namespace prep.collections
{
    public class MovieLibrary
    {
        IList<Movie> movies;

        public MovieLibrary(IList<Movie> list_of_movies)
        {
            this.movies = list_of_movies;
        }

        public IEnumerable<Movie> all_movies()
        {
            return movies.one_at_a_time();
        }

        public void add(Movie movie)
        {
            if (already_contains(movie)) return;

            movies.Add(movie);
        }

        bool already_contains(Movie movie)
        {
            return movies.Contains(movie);
        }

        public IEnumerable<Movie> sort_all_movies_by_title_descending()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> get_all_movies_matching(Condition<Movie> condition)
        {
            return movies.all_items_matching(condition);
        }


        bool is_published_by_pixar_or_disney(Movie movie)
        {
            return movie.production_studio == ProductionStudio.Pixar || movie.production_studio == ProductionStudio.Disney;
        }

        public IEnumerable<Movie> all_movies_published_by_pixar()
        {
            return get_all_movies_matching(movie => movie.production_studio == ProductionStudio.Pixar);
        }

        public IEnumerable<Movie> all_movies_published_by_pixar_or_disney()
        {
            return get_all_movies_matching(is_published_by_pixar_or_disney);
        }

        public IEnumerable<Movie> sort_all_movies_by_title_ascending()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> sort_all_movies_by_movie_studio_and_year_published()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> all_movies_not_published_by_pixar()
        {
            return get_all_movies_matching(m => m.production_studio != ProductionStudio.Pixar);
        }

        public IEnumerable<Movie> all_movies_published_after(int year)
        {
            return get_all_movies_matching(m => m.date_published.Year > year);
        }

        public IEnumerable<Movie> all_movies_published_between_years(int startingYear, int endingYear)
        {
            return get_all_movies_matching(m => m.date_published.Year >= startingYear && m.date_published.Year <= endingYear);
        }

        public IEnumerable<Movie> all_kid_movies()
        {
            return get_all_movies_matching(x => x.genre == Genre.kids);
        }

        public IEnumerable<Movie> all_action_movies()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> sort_all_movies_by_date_published_descending()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> sort_all_movies_by_date_published_ascending()
        {
            throw new NotImplementedException();
        }

    }
}
