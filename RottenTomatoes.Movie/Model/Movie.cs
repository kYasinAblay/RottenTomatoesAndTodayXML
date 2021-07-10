namespace RottenTomatoes.Movie.Model
{
    public class Movie
    {
        public string id { get; set; }
        public string title { get; set; }
        public object year { get; set; }
        public string mpaa_rating { get; set; }
        public object runtime { get; set; }
        public string critics_consensus { get; set; }
        public Release_Dates release_dates { get; set; }
        public Ratings ratings { get; set; }
        public string synopsis { get; set; }
        public Posters posters { get; set; }
        public Abridged_Cast[] abridged_cast { get; set; }
        public Links1 links { get; set; }
    }
}