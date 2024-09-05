using System.Globalization;
using RelationshipApp.Models;

namespace RelationshipApp.Services {

    public class CalendarService
    {
        private static List<CalendarEvent> _personalEvents = new List<CalendarEvent>
            {
                new CalendarEvent { Id = 1, Title = "Doctor Appointment", Start = DateTime.Now, End = DateTime.Now.AddHours(1), Latitude = 40.7128, Longitude = -74.0060 },
                new CalendarEvent { Id = 2, Title = "Gym Session", Start = DateTime.Now.AddDays(1), End = DateTime.Now.AddDays(1).AddHours(1), Latitude = 34.0522, Longitude = -118.2437 }
            };
        private static List<CalendarEvent> _sharedEvents = new List<CalendarEvent>
            {
                new CalendarEvent { Id = 3, Title = "Team Meeting", Start = DateTime.Now.AddDays(2), End = DateTime.Now.AddDays(2).AddHours(2), Latitude = 37.7749, Longitude = -122.4194 },
                new CalendarEvent { Id = 4, Title = "Project Deadline", Start = DateTime.Now.AddDays(3), End = DateTime.Now.AddDays(3).AddHours(2), Latitude = 47.6062, Longitude = -122.3321 }
            };

        public CalendarService()
        {
        }

        public List<CalendarEvent> GetAllEvents(string calendar)
        {
            if(calendar == "shared") {
                return _sharedEvents;
            }
            if(calendar == "personal") {
                return _personalEvents;
            }
            return new List<CalendarEvent>();
        }

        public void AddEvent(CalendarEvent calendarEvent, string calendar)
        {
            Console.WriteLine($"Adding event to: {calendar}");

            if (calendar == "shared")
            {
                _sharedEvents.Add(calendarEvent);
                Console.WriteLine("Event added to shared events.");
            }
            else if (calendar == "personal")
            {
                _personalEvents.Add(calendarEvent);
                Console.WriteLine("Event added to personal events.");
            }
            else
            {
                Console.WriteLine("Invalid calendar type.");
            }
        }
    }
}