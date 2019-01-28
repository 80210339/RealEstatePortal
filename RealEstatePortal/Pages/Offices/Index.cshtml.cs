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
    public class IndexModel : PageModel
    {
        private readonly RealEstatePortal.Models.PortalContext _context;

        public IndexModel(RealEstatePortal.Models.PortalContext context)
        {
            _context = context;
        }

        public IList<Office> Office { get;set; }

        public async Task OnGetAsync()
        {
            Office = await _context.Office.ToListAsync();
        }
    }
}
