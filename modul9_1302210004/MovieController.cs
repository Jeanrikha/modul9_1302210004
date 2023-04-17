using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
namespace modul9_1302210004
{
    [ApiController]//penanda MovieController sebagai API Controller
    [Route("api/[controller]")]//penentu route
    public class MovieController : ControllerBase
    {

        public static List<Movie> ListMovie = new List<Movie>
        {
            //Data default Movie imdb top 3
            new Movie()
            {
                Title = "The Shawshank Redemption",
                Director = "Frank Darabont",
                Stars = new List<string> {"Tim Robbins", "Morgan Freeman","Bob Gunton","William Sadler"},
                Description = "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion."
            },
            new Movie()
            {
                Title = "The Godfather",
                Director = "Francis Ford Coppola",
                Stars = new List<string>{"Marlon Brando", "Al Pacino", "James Caan", "Diane Keaton"},
                Description = "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."
            },
            new Movie()
            {
                Title = "The Dark Knight",
                Director = "Christoper Nolan",
                Stars = new List<string>{"Christian Bale", "Heath Ledger", "Aaron Eckhart", "Michael Caine"},
                Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice."
            }
        };

        [HttpGet]//metode GET
        public IEnumerable<Movie> Get()
        {
            return ListMovie;//mereturn data pada ListMovie
        }

        [HttpPost]//metode POST
        public void Post(Movie mov) 
        {
            ListMovie.Add(mov);//menambahkan data baru yang akan disimpan pada ListMovie
        }

        [HttpGet("{id}")]//metode GET dengan parameter "id"
        public Movie Get(int id)
        {
            return ListMovie[id];//mereturn data pada ListMovie sesuai "id" yang diminta
        }

        [HttpDelete("{id}")]//metode DELETE
        public void Delete(int id)
        {
            ListMovie.RemoveAt(id);//menghapus data pada ListMovie sesuai "id" yang diminta
        }

    }
}
