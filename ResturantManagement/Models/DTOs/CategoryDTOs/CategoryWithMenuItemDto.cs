using ResturantManagement.Models.DTOs.MenuItemDTOs;

namespace ResturantManagement.Models.DTOs.CategoryDTOs
{
    public class CategoryWithMenuItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<MenuItemDto> menuItemDtos { get; set; }
    }
}
