using E_Commerce.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace E_Commerce.Controller
{
    [ApiController]
    public class HomeController
    {
        private IProductRepository _productRepository;
        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public Task<IActionResult> GetById(int id)
        {
            return View()
        }
    }
}
