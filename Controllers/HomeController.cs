using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using ProdsCats.Models;

namespace ProdsCats.Controllers
{
    public class HomeController : Controller
    {   
        private MyContext dbContext;

        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("products")]
        public ViewResult AllProducts()
        {
            ViewBag.Products = dbContext.Products.ToList();
            return View();
        }

        [HttpPost("products")]
        public IActionResult AddProduct(Product product)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(product);
                dbContext.SaveChanges();
                return RedirectToAction("AllProducts");
            }
            else
            {
                ViewBag.Products = dbContext.Products.ToList();
                return View("AllProducts");
            }
        }

        [HttpGet("categories")]
        public ViewResult AllCategories()
        {
            ViewBag.Categories = dbContext.Categories.ToList();
            return View();
        }

        [HttpPost("categories")]
        public IActionResult AddCategory(Category category)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(category);
                dbContext.SaveChanges();
                return RedirectToAction("AllCategories");
            }
            else
            {
                ViewBag.Categories = dbContext.Categories.ToList();
                return View("AllCategories");
            }
        }

        [HttpGet("products/{productId}")]
        public IActionResult SpecProduct(int productId)
        {
            ViewBag.ProductId = productId;
            ViewBag.ProdName = dbContext.Products.FirstOrDefault(p => p.ProductId == productId).Name;

            ViewBag.ProductAssociations = dbContext.Products
                .Include(p => p.Associations)
                .ThenInclude(a => a.Category)
                .FirstOrDefault(p => p.ProductId == productId)
                .Associations.ToList();

            ViewBag.ChooseCategories = dbContext.Categories
                .Include(c => c.Products)
                .ThenInclude(a => a.Product)
                .Where(c => c.Products.All(a => a.ProductId != productId))
                .ToList();
            return View();
        }

        [HttpPost("addcategory")]
        public RedirectToActionResult AddCategory(int ProductId, int CategoryId)
        {
            Association newAssociation = new Association();
            newAssociation.ProductId = ProductId;
            newAssociation.CategoryId = CategoryId;
            dbContext.Add(newAssociation);
            dbContext.SaveChanges();
            return RedirectToAction("SpecProduct", new { productId = ProductId });
        }

        [HttpGet("categories/{categoryId}")]
        public ViewResult SpecCategory(int categoryId)
        {
            ViewBag.CategoryId = categoryId;
            ViewBag.CatName = dbContext.Categories.FirstOrDefault(c => c.CategoryId == categoryId).Name;

            ViewBag.CategoryAssociations = dbContext.Categories
                .Include(c => c.Products)
                .ThenInclude(a => a.Product)
                .FirstOrDefault(c => c.CategoryId == categoryId)
                .Products.ToList();

            ViewBag.ChooseProducts = dbContext.Products
                .Include(p => p.Associations)
                .ThenInclude(a => a.Category)
                .Where(p => p.Associations.All(a => a.CategoryId != categoryId))
                .ToList();

            return View();
        }

        [HttpPost("addproduct")]
        public RedirectToActionResult AddProduct(int CategoryId, int ProductId)
        {
            Association newAssociation = new Association();
            newAssociation.ProductId = ProductId;
            newAssociation.CategoryId = CategoryId;
            dbContext.Add(newAssociation);
            dbContext.SaveChanges();
            return RedirectToAction("SpecCategory", new { categoryId = CategoryId });
        }
    }
}
