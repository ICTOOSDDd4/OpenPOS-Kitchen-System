﻿using OpenPOS_APP.Services.Models;

namespace OpenPOS_APP.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int User_id { get; set; }
        public int Bill_id { get; set; }
        public bool? Status { get; set; }
        //public List<OrderLine> Lines { get; set; }
        public DateTime Updated_At { get; set; }
        public DateTime Created_At { get; set; }
        public Order() { }
        public Order(int id, bool? status, int userId, int billId, DateTime updatedAt, DateTime createdAt)
        {
            Id = id;
            Status = status;
            User_id = userId;
            Bill_id = billId;
            //Lines = OrderLineService.GetAllById(Id);
            Updated_At = updatedAt;
            Created_At = createdAt;
        }
        public List<OrderLine> GetLines(int id)
        {

         List<OrderLine> lines = OrderLineService.GetAllById(id);

         return lines;
        }
    }
}
