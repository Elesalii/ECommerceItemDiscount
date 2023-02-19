using ECommerceItemDiscount.Data;
using ECommerceItemDiscount.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerceItemDiscount.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemDiscountController: ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ItemDiscountController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetProductList")]
        public List<ProductModel> GetProductList()
        {
            var result = _context.Products.ToList();
            return result;
        }
        [HttpGet("GetProductListByCategory")]
        public List<ProductModel> GetProductListByCategory(int categoryId)
        {
            var result = _context.Products.Where(x => x.CategoryId == categoryId).ToList();
            return result;
        }
        [HttpGet("GetDiscountProductList")]
        public List<ProductModel> GetDiscountProductList()
        {
            var query =
                (from products in _context.Products
                join discounts in _context.Discounts on products.CategoryId equals discounts.CategoryId
                where discounts.StartDate < DateTime.UtcNow && discounts.ExpiryDate > DateTime.UtcNow
                select new ProductModel
                {
                    Id = products.Id,
                    CategoryId = discounts.CategoryId,
                    Name = products.Name,
                    Price = products.Price*(100-discounts.Rate)/100,
                    Description = products.Description
                }).ToList();
            return query;
        }
    }
}
