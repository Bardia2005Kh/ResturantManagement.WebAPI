using ResturantManagement.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantManagement.Models.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderTime { get; set; }
        public OrderStatus Status { get; set; }
        public int TableId { get; set; }
        public int CustomerId { get; set; }
        public int MenuItemId { get; set; }

        public Payment? Payment { get; set; }

        // Navigation
        public MenuItem MenuItem { get; set; }
        public Customer Customer { get; set; }
        public Table Table { get; set; }
    }
}
