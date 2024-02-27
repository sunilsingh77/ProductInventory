using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductRegistration.Models;

namespace ProductRegistration.Controllers
{
    public class ProductsController : Controller
    {

        private readonly ApplicationUserDbContext _db;
        public ProductsController(ApplicationUserDbContext context)
        {
            _db = context;
        }

        // GET: Product  
        public async Task<IActionResult> Index()
        {
            return View(await _db.Products.ToListAsync());
        }

        // GET: Product/Details/5  
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productMaster = await _db.Products
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (productMaster == null)
            {
                return NotFound();
            }

            return View(productMaster);
        }

        // GET: Product/Create  
        public IActionResult Create()
        {
            return View();
        }

        // POST: Product/Create  
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for   
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.  
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Amount,Image,Quantity,Brand,IsActive")] Product productMaster)
        {
            if (ModelState.IsValid)
            {
                _db.Add(productMaster);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productMaster);
        }

        // GET: Product/Edit/5  
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productMaster = await _db.Products.FindAsync(id);
            if (productMaster == null)
            {
                return NotFound();
            }
            return View(productMaster);
        }

        // POST: Product/Edit/5  
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for  
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Amount,Image,Quantity,Brand,IsActive")] Product productMaster)
        {
            if (id != productMaster.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _db.Update(productMaster);
                    await _db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductMasterExists(productMaster.ProductId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(productMaster);
        }

        // GET: Product/Delete/5  
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productMaster = await _db.Products
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (productMaster == null)
            {
                return NotFound();
            }

            return View(productMaster);
        }

        // POST: Product/Delete/5  
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productMaster = await _db.Products.FindAsync(id);
            _db.Products.Remove(productMaster);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductMasterExists(int id)
        {
            return _db.Products.Any(e => e.ProductId == id);
        }
    }
}
