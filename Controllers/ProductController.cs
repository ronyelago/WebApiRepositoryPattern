using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductCatalog.Data;
using ProductCatalog.Models;
using ProductCatalog.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace ProductCatalog.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly StoreDataContext _context;
        private readonly IMapper _mapper;

        public ProductController(StoreDataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public List<ListProductViewModel> Get()
        {
            var products = _context.Products.AsNoTracking().ToList();
            var productsViewModel = _mapper.Map<List<Product>, List<ListProductViewModel>>(products);

            return productsViewModel;
        }

        [HttpGet]
        [Route("{id}")]
        public EditorProductViewModel Get(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            var editorProductViewModel = _mapper.Map<Product, EditorProductViewModel>(product);

            return editorProductViewModel;
        }

        [HttpPost]
        public Product Post([FromBody]EditorProductViewModel editorProductViewModel)
        {
            var product = _mapper.Map<EditorProductViewModel, Product>(editorProductViewModel);
            
            _context.Products.Add(product);
            _context.SaveChanges();

            return product;
        }
    }
}