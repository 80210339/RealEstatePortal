using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RealEstatePortal.Models;

namespace RealEstatePortal.Pages.AgentPropertyBuyerSellers
{
    public class DetailsModel : PageModel
    {
        private readonly RealEstatePortal.Models.PortalContext _context;

        public DetailsModel(RealEstatePortal.Models.PortalContext context)
        {
            _context = context;
        }

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
    }
}
