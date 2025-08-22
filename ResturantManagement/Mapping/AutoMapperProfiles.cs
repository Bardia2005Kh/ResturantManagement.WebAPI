using AutoMapper;
using ResturantManagement.Models.DTOs.CategoryDTOs;
using ResturantManagement.Models.DTOs.CustomerDTOs;
using ResturantManagement.Models.DTOs.MenuItemDTOs;
using ResturantManagement.Models.Entities;

namespace ResturantManagement.Mapping
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            // Customer Mapping
            CreateMap<Customer, AddCustomerDto>().ReverseMap();
            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<Customer, UpdateCustomerDto>().ReverseMap();

            // Category Mapping
            CreateMap<Category, AddCategoryDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, CategoryWithMenuItemDto>().ReverseMap();

            // MenuItem Mapping
            CreateMap<MenuItem, MenuItemDto>().ReverseMap();
        }
    }
}
