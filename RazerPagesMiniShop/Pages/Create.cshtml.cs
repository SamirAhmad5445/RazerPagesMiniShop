using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazerPagesMiniShop.Data;
using RazerPagesMiniShop.Models;

namespace RazerPagesMiniShop.Pages
{
    public class CreateModel(ApplicationDbContext _db) : PageModel
  { 
    [BindProperty]
      public Product product { get; set; }
        public IActionResult OnGet()
        {
          return Page();
        }

        public IActionResult OnPost()
        {
          _db.Products.Add(product);
          _db.SaveChanges();
          return RedirectToPage("Index");
        }
    }
}
