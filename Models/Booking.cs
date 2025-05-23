﻿namespace HotelManagementSystem.Models
{
	public class Booking
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public int RoomId { get; set; }
		public DateTime CheckInDate { get; set; }
		public DateTime CheckOutDate { get; set; }
		public decimal TotalPrice { get; set; }
		public string Status { get; set; }
		public User User { get; set; }
		public Room Room { get; set; }
		public Payment Payment { get; set; }
	}
}
