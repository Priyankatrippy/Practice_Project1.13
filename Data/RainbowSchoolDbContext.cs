using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppPracticeProject1._13.Models;

namespace WebAppPracticeProject1._13.Data
{
    public class RainbowSchoolDbContext : DbContext
    {
        public RainbowSchoolDbContext (DbContextOptions<RainbowSchoolDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppPracticeProject1._13.Models.Student> Student { get; set; } = default!;
    }
}
