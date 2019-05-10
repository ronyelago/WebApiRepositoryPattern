using AutoMapper;
using ProductCatalog.Models;
using ProductCatalog.ViewModels;

namespace ProductCatalog.Mappings
{
    public class ProductMap : Profile
    {
        public ProductMap()
        {
            CreateMap<Product, ListProductViewModel>().ReverseMap();
            CreateMap<Product, EditorProductViewModel>().ReverseMap();
        }
    }
}
