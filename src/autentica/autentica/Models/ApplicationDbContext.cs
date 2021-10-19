using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace autentica.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public  DbSet<Cliente> Clientes{ get; set; }

    }
}
