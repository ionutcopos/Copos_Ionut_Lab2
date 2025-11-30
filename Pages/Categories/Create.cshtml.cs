using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Copos_Ionut_Lab2.Data;
using Copos_Ionut_Lab2.Models;

namespace Copos_Ionut_Lab2.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly Copos_Ionut_Lab2.Data.Copos_Ionut_Lab2Context _context;

        public CreateModel(Copos_Ionut_Lab2.Data.Copos_Ionut_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Category == null || Category == null)
            {
                return Page();
            }

            _context.Category.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
