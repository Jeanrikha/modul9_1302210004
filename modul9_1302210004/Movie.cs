namespace modul9_1302210004
{
    public class Movie
    {
        //membuat getter setter data Movie
        public string Title { get; set; }
        public string Director { get; set; }
        public List<String> Stars { get; set; }
        public string Description { get; set; }

        //contructor Movie
        public Movie(string title, string director, List<string> stars, string description)
        {
            this.Title = title;
            this.Director = director;
            this.Stars = stars;
            this.Description = description;
        }
        //Contructor kosong
        public Movie() 
        { 
        }
    }
}
