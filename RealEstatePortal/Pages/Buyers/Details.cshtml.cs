using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RealEstatePortal.Models;

namespace RealEstatePortal.Pages.Buyers
{
    public class DetailsModel : PageModel
    {
        private readonly RealEstatePortal.Models.PortalContext _context;

        public DetailsModel(RealEstatePortal.Models.PortalContext context)
        {
            _context = context;
        }

        public Buyer Buyer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Buyer = await _context.Buyer.FirstOrDefaultAsync(m => m.BuyerID == id);

            if (Buyer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
