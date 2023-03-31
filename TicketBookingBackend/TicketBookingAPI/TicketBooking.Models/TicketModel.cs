﻿
namespace TicketBooking.Models
{
    public class TicketModel
    {
        public int BusId { get; set; }
        public string UserId { get; set; }
        public double Fare { get; set; }
        public bool IsPaymentDone { get; set; }
        public UserModel User { get; set; }
        public BusModel Bus { get; set; }
    }

}
