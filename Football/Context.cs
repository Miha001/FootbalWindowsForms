using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Football
{
    public class Context:DbContext
    {
        public Context() : base("Football")
        { }

        public DbSet <Team> Teams { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Dates> Datess { get; set; }
    }
}
