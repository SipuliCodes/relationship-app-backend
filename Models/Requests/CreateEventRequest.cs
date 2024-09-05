using RelationshipApp.Models;
public class CreateEventRequest
{
    public required CalendarEvent CalendarEvent { get; set; }
    public required string Calendar { get; set; }
}