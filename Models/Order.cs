using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace OnlineLibrary.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public IdentityUser User { get; set; } // IdentityUser from Microsoft.AspNetCore.Identity
        public DateTime OrderDate { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
