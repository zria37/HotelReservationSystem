﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace HotelReservationSystem.Models;

public partial class CheckIn
{
    public int CheckInId { get; set; }

    public int ReservationId { get; set; }

    public DateOnly CheckInDate { get; set; }

    public DateOnly CheckOutDate { get; set; }

    public virtual Reservation Reservation { get; set; }
}