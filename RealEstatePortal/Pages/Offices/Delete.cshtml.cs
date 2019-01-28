using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RealEstatePortal.Models;

namespace RealEstatePortal.Pages.Offices
{
    public class DeleteModel : PageModel
    {
        private readonly RealEstatePortal.Models.PortalContext _context;

        public DeleteModel(RealEstatePortal.Models.PortalContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Office Office { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Office = await _context.Office.FirstOrDefaultAsync(m => m.OfficeID == id);

            if (Office == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Office = await _context.Office.FindAsync(id);

            if (Office != null)
            {
                _context.Office.Remove(Office);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
