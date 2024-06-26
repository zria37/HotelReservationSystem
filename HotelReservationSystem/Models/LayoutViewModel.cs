﻿namespace HotelReservationSystem.Models
{
    public class LayoutViewModel
    {
        public bool IsLoggedIn { get; set; }
        public string UserRole { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
        public IEnumerable<Room> Rooms{ get; set; }
        public IEnumerable<Reservation> Reservations{ get; set; }
    }
}
