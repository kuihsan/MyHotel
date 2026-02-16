namespace MyHotel.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }  // 101, 102, etc.
        public string Type { get; set; }  // Single, Double, Suite
        public bool IsAvailable { get; set; } = true;
    }
}
