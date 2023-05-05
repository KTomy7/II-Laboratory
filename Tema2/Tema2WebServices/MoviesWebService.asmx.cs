using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Services;

namespace Tema2WebServices
{
    /// <summary>
    /// Summary description for MoviesWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MoviesWebService : System.Web.Services.WebService
    {
        public MoviesWebService()
        {

        }

        [WebMethod]
        public List<Movie> GetMovies()
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Movies.ToList();
            }
        }

        [WebMethod]
        public List<Movie> GetWatchedMovies()
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Movies.Where(m => m.Watched == true).ToList();
            }
        }

        [WebMethod]
        public List<Movie> GetUnwatchedMovies()
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Movies.Where(m => m.Watched == false).ToList();
            }
        }

        [WebMethod]
        public Movie GetMovieById(int id)
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Movies.Find(id);
            }
        }

        [WebMethod]
        public Movie GetMovieByTitle(string title)
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Movies.FirstOrDefault(m => m.Title == title);
            }
        }

        [WebMethod]
        public void AddMovie(Movie movie)
        {
            using (var dbContext = new AppDbContext())
            {
                dbContext.Movies.Add(movie);
                dbContext.SaveChanges();
            }
        }

        [WebMethod]
        public void UpdateMovie(Movie movie)
        {
            using (var dbContext = new AppDbContext())
            {
                var movieToUpdate = dbContext.Movies.Find(movie.Id);
                if (movieToUpdate != null)
                {
                    movieToUpdate.Title = movie.Title;
                    movieToUpdate.Genre = movie.Genre;
                    movieToUpdate.Duration = movie.Duration;
                    movieToUpdate.ReleaseDate = movie.ReleaseDate;
                    movieToUpdate.Description = movie.Description;
                    movieToUpdate.Rating = movie.Rating;
                    movieToUpdate.Watched = movie.Watched;
                    dbContext.SaveChanges();
                }
            }
        }

        [WebMethod]
        public void DeleteMovie(Movie movie)
        {
            using (var dbContext = new AppDbContext())
            {
                var movieToDelete = dbContext.Movies.Find(movie.Id);
                if (movieToDelete != null)
                {
                    dbContext.Movies.Remove(movieToDelete);
                    dbContext.SaveChanges();
                }
            }
        }
    }
}
