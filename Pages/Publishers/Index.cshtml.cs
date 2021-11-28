using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cacuci_Daciana_Lab8.Data;
using Cacuci_Daciana_Lab8.Models;

namespace Cacuci_Daciana_Lab8.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Cacuci_Daciana_Lab8.Data.Cacuci_Daciana_Lab8Context _context;

        public IndexModel(Cacuci_Daciana_Lab8.Data.Cacuci_Daciana_Lab8Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }
        public List<Book> Book { get; private set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book
            .Include(b => b.Publisher)
            .ToListAsync();
        }

       
    }
}
