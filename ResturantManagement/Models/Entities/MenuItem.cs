using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantManagement.Models.Entities
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }
        public bool IsAvailable { get; set; }
        
        public int CategoryId { get; set; }

        public ICollection<Order> Orders { get; } = new List<Order>();

        // Navigation
        public Category Category { get; set; }
    }
}
