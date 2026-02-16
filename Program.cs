using Microsoft.EntityFrameworkCore;
using MyHotel.Data; 

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApiContext>(options =>
    options.UseInMemoryDatabase("HotelBookingDB")); // Using in-memory database for simplicity

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ApiContext>();

    if (!context.HotelRooms.Any())
    {
        context.HotelRooms.AddRange(
            new MyHotel.Models.Room { Id = 1, Name = "101", Type = "Single", IsAvailable = true },
            new MyHotel.Models.Room { Id = 2, Name = "102", Type = "Single", IsAvailable = true },
            new MyHotel.Models.Room { Id = 3, Name = "103", Type = "Single", IsAvailable = true },
            new MyHotel.Models.Room { Id = 4, Name = "201", Type = "Double", IsAvailable = true },
            new MyHotel.Models.Room { Id = 5, Name = "202", Type = "Double", IsAvailable = true },
            new MyHotel.Models.Room { Id = 6, Name = "203", Type = "Double", IsAvailable = true },
            new MyHotel.Models.Room { Id = 7, Name = "301", Type = "Suite", IsAvailable = true },
            new MyHotel.Models.Room { Id = 8, Name = "302", Type = "Suite", IsAvailable = true },
            new MyHotel.Models.Room { Id = 9, Name = "303", Type = "Suite", IsAvailable = true }
        );

        context.SaveChanges();
    }
}

app.Run();
