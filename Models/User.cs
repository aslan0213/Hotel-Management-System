﻿using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace HotelManagementSystem.Models
{
	public class User
	{
		public int Id { get; set; }
		public string FullName { get; set; }
		public string Email { get; set; }
		public string Password { get; set; } 
		public string Role { get; set; }
		public string PhoneNumber { get; set; }
		public string Address { get; set; }
		public List<Booking> Bookings { get; set; }
		public List<Review> Reviews { get; set; }
	}
}
