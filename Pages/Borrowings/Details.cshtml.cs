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
    public class DetailsModel : PageModel
    {
        private readonly Lucian_Sarosi_Lab2.Data.Lucian_Sarosi_Lab2Context _context;
        private readonly IEnumerable bookDetails;

        public DetailsModel(Lucian_Sarosi_Lab2.Data.Lucian_Sarosi_Lab2Context context)
        {
            _context = context;
        }

      public Borrowing Borrowing { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Borrowing == null)
            {
                return NotFound();
            }

            var borrowing = await _context.Borrowing.FirstOrDefaultAsync(m => m.ID == id);
            if (borrowing == null)
            {
                return NotFound();
            }
            else 
            {
                Borrowing = borrowing;
                ViewData["BookID"] = new SelectList(bookDetails, "ID", "BookDetails");
                ViewData["MemberID"] = new SelectList(_context.Member, "ID", "FullName");
            }
            return Page();
        }
    }
}
