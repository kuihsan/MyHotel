using Microsoft.AspNetCore.Mvc;
using MyHotel.Data;
using MyHotel.Models;

namespace MyHotel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly ApiContext _context;
        public HotelController(ApiContext context)
        {
            _context = context;
        }

        [HttpPost("Bookings")]
        public IActionResult CreateBooking(Booking booking)
        {
            var room = _context.HotelRooms.Find(booking.RoomId);

            if (room == null)
                return NotFound("Room not found");

            if (!room.IsAvailable)
                return BadRequest("Room is not available");

            if (booking.CheckInDate >= booking.CheckOutDate)
                return BadRequest("Invalid date range");

            room.IsAvailable = false;

            _context.HotelBookings.Add(booking);
            _context.SaveChanges();

            return Ok("Booking created successfully");
        }
        // GET: api/Hotel/Rooms
        [HttpGet("Rooms")]
        public ActionResult<IEnumerable<Room>> GetRooms()
        {
            return Ok(_context.HotelRooms.ToList());
        }
        // GET: api/Hotel/Bookings
        [HttpGet("Bookings")]
        public ActionResult<IEnumerable<Booking>> GetBookings()
        {
            return Ok(_context.HotelBookings.ToList());
        }

    }
}