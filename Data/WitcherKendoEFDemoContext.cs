using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WitcherKendoEFDemo.Models;

namespace WitcherKendoEFDemo.Models
{
    public class WitcherKendoEFDemoContext : DbContext
    {
        public WitcherKendoEFDemoContext (DbContextOptions<WitcherKendoEFDemoContext> options)
            : base(options)
        {
        }

        public DbSet<WitcherKendoEFDemo.Models.Character> Character { get; set; }

        public DbSet<WitcherKendoEFDemo.Models.Weapon> Weapon { get; set; }
    }
}
