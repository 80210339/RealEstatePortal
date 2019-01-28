using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RealEstatePortal;
using RealEstatePortal.Models;

namespace RealEstatePortal.Pages.Agents
{
    public class DeleteModel : PageModel
    {
        private readonly RealEstatePortal.Models.PortalContext _context;

        public DeleteModel(RealEstatePortal.Models.PortalContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Agent Agent { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Agent = await _context.Agent.FirstOrDefaultAsync(m => m.AgentID == id);

            if (Agent == null)
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

            Agent = await _context.Agent.FindAsync(id);

            if (Agent != null)
            {
                _context.Agent.Remove(Agent);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
