using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RealEstatePortal.Models;

namespace RealEstatePortal.Pages.AgentPropertyBuyerSellers
{
    public class EditModel : PageModel
    {
        private readonly RealEstatePortal.Models.PortalContext _context;

        public EditModel(RealEstatePortal.Models.PortalContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AgentPropertyBuyerSeller AgentPropertyBuyerSeller { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AgentPropertyBuyerSeller = await _context.AgentPropertyBuyerSeller.FirstOrDefaultAsync(m => m.AgentPropertyBuyerSellerID == id);

            if (AgentPropertyBuyerSeller == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(AgentPropertyBuyerSeller).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AgentPropertyBuyerSellerExists(AgentPropertyBuyerSeller.AgentPropertyBuyerSellerID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AgentPropertyBuyerSellerExists(int id)
        {
            return _context.AgentPropertyBuyerSeller.Any(e => e.AgentPropertyBuyerSellerID == id);
        }
    }
}
