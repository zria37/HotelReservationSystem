namespace HotelReservationSystem.Models
{
    public class LayoutViewModel
    {
        public bool IsLoggedIn { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
        public IEnumerable<Room> Rooms{ get; set; }
    }
}
