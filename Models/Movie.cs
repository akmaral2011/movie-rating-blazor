namespace MovieRatingBlazor.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string Image { get; set; } = ""; 
        public int Rating { get; set; }
        public int HoverRating { get; set; }
        public string Comment { get; set; } = "";
        public bool ShowSuccessMessage { get; set; }
    }
}