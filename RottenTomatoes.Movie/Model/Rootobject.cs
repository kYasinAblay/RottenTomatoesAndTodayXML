namespace RottenTomatoes.Movie.Model
{
    public class Rootobject
    {
        
        public int total { get; set; }
        public Movie[] movies { get; set; }
        public Links links { get; set; }
        public string link_template { get; set; }
    }
}