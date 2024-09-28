using System.Globalization;
using RelationshipApp.Models;

namespace RelationshipApp.Services {

    public class CalendarService
    {
        private static List<CalendarEventWithId> _personalEvents = new List<CalendarEventWithId>
            {
                new CalendarEventWithId { Id = Guid.NewGuid(), Title = "Doctor Appointment", Start = DateTime.Now, End = DateTime.Now.AddHours(1), Latitude = 40.7128, Longitude = -74.0060 },
                new CalendarEventWithId { Id = Guid.NewGuid(), Title = "Gym Session", Start = DateTime.Now.AddDays(1), End = DateTime.Now.AddDays(1).AddHours(1), Latitude = 34.0522, Longitude = -118.2437 }
            };
        private static List<CalendarEventWithId> _sharedEvents = new List<CalendarEventWithId>
            {
                new CalendarEventWithId { Id = Guid.NewGuid(), Title = "Team Meeting", Start = DateTime.Now.AddDays(2), End = DateTime.Now.AddDays(2).AddHours(2), Latitude = 37.7749, Longitude = -122.4194 },
                new CalendarEventWithId { Id = Guid.NewGuid(), Title = "Project Deadline", Start = DateTime.Now.AddDays(3), End = DateTime.Now.AddDays(3).AddHours(2), Latitude = 47.6062, Longitude = -122.3321 }
            };

        public CalendarService()
        {
        }

        public List<CalendarEventWithId> GetAllEvents(string calendar)
        {
            if(calendar == "shared") {
                return _sharedEvents;
            }
            if(calendar == "personal") {
                return _personalEvents;
            }
            return new List<CalendarEventWithId>();
        }

        public CalendarEvent AddEvent(CalendarEvent calendarEvent, string calendar)
        {
            Console.WriteLine($"Adding event to: {calendar}");

            CalendarEventWithId calendarEventWithId = CalendarEventService.createCalendarEventWithId(calendarEvent);

            if (calendar == "shared")
            {
                _sharedEvents.Add(calendarEventWithId);
                Console.WriteLine("Event added to shared events.");
                return calendarEvent;
            }
            else if (calendar == "personal")
            {
                _personalEvents.Add(calendarEventWithId);
                Console.WriteLine("Event added to personal events.");
                return calendarEvent;
            }
            else
            {
                Console.WriteLine("Invalid calendar type.");
                throw new Exception("Invalid calendar type");
            }
        }
    }
}