using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Data;
using ProductCatalog.Models;
using System.Linq;

namespace ProductCatalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly StoreDataContext _context;

        public FuncionarioController(StoreDataContext context)
        {
            _context = context;
        }

        [Route("{id}")]
        [HttpGet]
        public L_FUNCIONARIOS Get(int id)
        {
            return _context.L_FUNCIONARIOS.FirstOrDefault(f => f.Id == id);
        }
    }
}