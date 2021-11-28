using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cacuci_Daciana_Lab8.Models;
using Cacuci_Daciana_Lab8.Pages;

namespace Cacuci_Daciana_Lab8.Data
{
    public class Cacuci_Daciana_Lab8Context : DbContext
    {
        public Cacuci_Daciana_Lab8Context (DbContextOptions<Cacuci_Daciana_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Cacuci_Daciana_Lab8.Models.Book> Book { get; set; }

        public DbSet<Cacuci_Daciana_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Cacuci_Daciana_Lab8.Models.Category> Category { get; set; }
    }
}
