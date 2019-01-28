using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RealEstatePortal.Models;

namespace RealEstatePortal.Pages.UserAudits
{
    public class DeleteModel : PageModel
    {
        private readonly RealEstatePortal.Models.PortalContext _context;

        public DeleteModel(RealEstatePortal.Models.PortalContext context)
        {
            _context = context;
        }

        [BindProperty]
        public UserAudit UserAudit { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            UserAudit = await _context.UserAudit.FirstOrDefaultAsync(m => m.UserAuditID == id);

            if (UserAudit == null)
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

            UserAudit = await _context.UserAudit.FindAsync(id);

            if (UserAudit != null)
            {
                _context.UserAudit.Remove(UserAudit);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
