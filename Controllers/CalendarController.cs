using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;
using RelationshipApp.Services;
using RelationshipApp.Models;

[Authorize]
[ApiController]
[Route("[controller]")]
[RequiredScope("relationshipapp.read")]
public class CalendarController : ControllerBase
{
    private readonly CalendarService _calendarService;

    public CalendarController(CalendarService calendarService)
    {
        _calendarService = calendarService;
    }

    [HttpGet]
    public ActionResult<List<CalendarEvent>> GetAllEvents([FromQuery] string calendar )
    {
        var events = _calendarService.GetAllEvents(calendar);
        return Ok(events);
    }

    [HttpPost]
    public IActionResult CreateEvent([FromBody] CreateEventRequest request)
    {
        Console.WriteLine("Received request: " + System.Text.Json.JsonSerializer.Serialize(request));

        if (request == null || request.CalendarEvent == null || string.IsNullOrEmpty(request.Calendar))
        {
            return BadRequest("Invalid request.");
        }

        Console.WriteLine("Event Title: " + request.CalendarEvent.Title);

        _calendarService.AddEvent(calendarEvent: request.CalendarEvent, calendar: request.Calendar);
        return Ok();
    }
}