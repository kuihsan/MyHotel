using MyHotel.Models;

namespace MyHotel.Data
{
    public static class DbInitializer
    {
        public static void Seed(ApiContext context)
        {
            if (context.HotelRooms.Any())
                return; // DB already seeded

            context.HotelRooms.AddRange(
                new Room { Id = 1, Name = "101", Type = "Single", IsAvailable = true },
                new Room { Id = 2, Name = "102", Type = "Single", IsAvailable = true },
                new Room { Id = 3, Name = "103", Type = "Single", IsAvailable = true },
                new Room { Id = 4, Name = "201", Type = "Double", IsAvailable = true },
                new Room { Id = 5, Name = "202", Type = "Double", IsAvailable = true },
                new Room { Id = 6, Name = "203", Type = "Double", IsAvailable = true },
                new Room { Id = 7, Name = "301", Type = "Suite", IsAvailable = true },
                new Room { Id = 8, Name = "302", Type = "Suite", IsAvailable = true },
                new Room { Id = 9, Name = "303", Type = "Suite", IsAvailable = true }
            );

            context.SaveChanges();
        }
    }
}
