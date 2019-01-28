using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RealEstatePortal.Models;

namespace RealEstatePortal.Pages.ContactDetailss
{
    public class DeleteModel : PageModel
    {
        private readonly RealEstatePortal.Models.PortalContext _context;

        public DeleteModel(RealEstatePortal.Models.PortalContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ContactDetails ContactDetails { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ContactDetails = await _context.ContactDetails.FirstOrDefaultAsync(m => m.ContactDetailsID == id);

            if (ContactDetails == null)
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

            ContactDetails = await _context.ContactDetails.FindAsync(id);

            if (ContactDetails != null)
            {
                _context.ContactDetails.Remove(ContactDetails);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
