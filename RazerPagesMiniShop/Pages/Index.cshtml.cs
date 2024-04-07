using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazerPagesMiniShop.Data;
using RazerPagesMiniShop.Models;

namespace RazerPagesMiniShop.Pages
{
  public class IndexModel(ApplicationDbContext _db) : PageModel
  {
    [BindProperty]
    public List<Product> products { get; set; }

    public void OnGet()
    {
      products = _db.Products.Include(products => products.company).ToList();
    }

    public IActionResult OnPostDelete(int id)
    {
      var pr = _db.Products.SingleOrDefault(p => p.Id == id);
      if (pr != null)
      {
        _db.Products.Remove(pr);
        _db.SaveChanges();
        return RedirectToPage("Index");
      }
      return Page();
    }
  }

}
