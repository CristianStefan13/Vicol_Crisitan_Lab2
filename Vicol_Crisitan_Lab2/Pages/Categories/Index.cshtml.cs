using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vicol_Crisitan_Lab2.Data;
using Vicol_Crisitan_Lab2.Models;
using Vicol_Crisitan_Lab2.Models.ViewModels;

namespace Vicol_Crisitan_Lab2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Vicol_Crisitan_Lab2.Data.Vicol_Crisitan_Lab2Context _context;

        public IndexModel(Vicol_Crisitan_Lab2.Data.Vicol_Crisitan_Lab2Context context)
        {
            _context = context;
        }

        public IList<BookCategory> BookCategory { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.BookCategory != null)
            {
                BookCategory = await _context.BookCategory
                .Include(b => b.Book)
                .Include(b => b.Category).ToListAsync();
            }
        }
    }
}

