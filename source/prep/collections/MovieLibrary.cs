using System;
using System.Collections.Generic;

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
            return this.movies;
        }

        public void add(Movie movie)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> sort_all_movies_by_title_descending()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> all_movies_published_by_pixar()
        {
            Func<Movie, bool> pixarFunc = (Movie m) =>
                                              {
                                                  if (m.production_studio == ProductionStudio.Pixar)
                                                  {
                                                      return true;
                                                  }
                                                  return false;
                                              };
            return GetMovieCollection(pixarFunc);
        }

        public IEnumerable<Movie> all_movies_published_by_pixar_or_disney()
        {
            Func<Movie, bool> pixarOrDisneyFunc = (Movie m) =>
                                                      {
                                                          if (m.production_studio == ProductionStudio.Pixar ||
                                                              m.production_studio == ProductionStudio.Disney)
                                                          {
                                                              return true;
                                                          }
                                                          return false;
                                                      };
            return GetMovieCollection(pixarOrDisneyFunc);
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
            Func<Movie, bool> nonPixarFunc = (Movie m) =>
                                                 {
                                                     if (m.production_studio != ProductionStudio.Pixar)
                                                     {
                                                         return true;
                                                     }
                                                     return false;
                                                 };
            return GetMovieCollection(nonPixarFunc);
        }

        public IEnumerable<Movie> all_movies_published_after(int year)
        {
            Func<Movie, bool> afterYearFunc = (Movie m) =>
                                                  {
                                                      if (m.date_published.Year > year)
                                                      {
                                                          return true;
                                                      }
                                                      return false;
                                                  };
            return GetMovieCollection(afterYearFunc);
        }

        public IEnumerable<Movie> all_movies_published_between_years(int startingYear, int endingYear)
        {
            Func<Movie, bool> betweenYearFunc = (Movie m) =>
                                                    {
                                                        if (m.date_published.Year >= startingYear &&
                                                            m.date_published.Year < endingYear)
                                                        {
                                                            return true;
                                                        }
                                                        return false;
                                                    };
            return GetMovieCollection(betweenYearFunc);
        }

        public IEnumerable<Movie> all_kid_movies()
        {
            Func<Movie,bool> kidsMoviesFunc = (Movie m) =>
                                      {
                                          if (m.genre == Genre.kids)
                                          {
                                              return true;
                                          }
                                          return false;
                                      };
            return GetMovieCollection(kidsMoviesFunc);

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

        private IEnumerable<Movie> GetMovieCollection(Func<Movie,bool> inFunc)
        {
            foreach (var movie in movies)
            {
                if (inFunc.Invoke(movie))
                {
                    yield return movie;
                }
            }
        } 
    }
}
