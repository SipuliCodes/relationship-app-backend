using RelationshipApp.Models;

namespace RelationshipApp.Services {
    public class CalendarEventService {
        public static CalendarEventWithId createCalendarEventWithId(CalendarEvent calendarEvent) {
            return new CalendarEventWithId {
                Title = calendarEvent.Title,
                Start = calendarEvent.Start,
                End = calendarEvent.End,
                Latitude = calendarEvent.Latitude,
                Longitude = calendarEvent.Longitude,
                Id = Guid.NewGuid()
            };
        }
    }
}