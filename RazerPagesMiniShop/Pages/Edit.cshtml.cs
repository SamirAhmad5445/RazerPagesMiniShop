using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazerPagesMiniShop.Data;
using RazerPagesMiniShop.Models;

namespace RazerPagesMiniShop.Pages
{
    public class EditModel(ApplicationDbContext _db) : PageModel
    {
    [BindProperty]
    public Product product { get; set; }
        public void OnGet(int id)
        {
          if(id != null && id > 0)
          {
            product = _db.Products.SingleOrDefault(p => p.Id == id);
          }
        }

        public IActionResult OnPost()
        {
          _db.Products.Update(product);
          _db.SaveChanges();
          return RedirectToPage("Index");
        }
    }
}
