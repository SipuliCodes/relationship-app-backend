
namespace RelationshipApp.Models
{
    public class CalendarEvent
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required DateTime Start { get; set; }
        public required DateTime End { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}