﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RealEstatePortal.Models;

namespace RealEstatePortal.Pages.UserAudits
{
    public class CreateModel : PageModel
    {
        private readonly RealEstatePortal.Models.PortalContext _context;

        public CreateModel(RealEstatePortal.Models.PortalContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public UserAudit UserAudit { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.UserAudit.Add(UserAudit);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}