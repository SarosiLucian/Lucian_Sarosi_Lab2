using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lucian_Sarosi_Lab2.Data;
using Lucian_Sarosi_Lab2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;

namespace Lucian_Sarosi_Lab2.Pages.Borrowings
{
    public class DeleteModel : PageModel
    {
        private readonly Lucian_Sarosi_Lab2.Data.Lucian_Sarosi_Lab2Context _context;
        private readonly IEnumerable bookDetails;

        public DeleteModel(Lucian_Sarosi_Lab2.Data.Lucian_Sarosi_Lab2Context context)
        {
            _context = context;
        }

        [BindProperty]
      public Borrowing Borrowing { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Borrowing == null)
            {
                return NotFound();
            }

            var borrowing = await _context.Borrowing
                .Include(i => i.Member)
                .Include(i => i.Book).ThenInclude(j => j.Author)
                .FirstOrDefaultAsync(m => m.ID == id);

            if (borrowing == null)
            {
                return NotFound();
            }
            else 
            {
                Borrowing = borrowing;

            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Borrowing == null)
            {
                return NotFound();
            }
            var borrowing = await _context.Borrowing.FindAsync(id);

            if (borrowing != null)
            {
                Borrowing = borrowing;
                _context.Borrowing.Remove(Borrowing);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
