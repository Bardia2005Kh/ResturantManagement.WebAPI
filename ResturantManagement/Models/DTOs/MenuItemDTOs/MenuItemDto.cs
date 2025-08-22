namespace ResturantManagement.Models.DTOs.MenuItemDTOs
{
    public class MenuItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }
        public bool IsAvailable { get; set; }

        public int CategoryId { get; set; }
    }
}
