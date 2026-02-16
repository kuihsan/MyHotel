using Microsoft.EntityFrameworkCore;
using MyHotel.Models;

namespace MyHotel.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }

        public DbSet<Booking> HotelBookings { get; set; }
        public DbSet<Room> HotelRooms { get; set; }
    }
}
