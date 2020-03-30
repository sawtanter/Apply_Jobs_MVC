using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Apply_Jobs_MVC.Models;

namespace Apply_Jobs_MVC.Data
{
    public class Apply_Jobs_DbContext : DbContext
    {
        public Apply_Jobs_DbContext (DbContextOptions<Apply_Jobs_DbContext> options)
            : base(options)
        {
        }

        public DbSet<Apply_Jobs_MVC.Models.Advertisement> Advertisement { get; set; }

        public DbSet<Apply_Jobs_MVC.Models.Application> Application { get; set; }

        public DbSet<Apply_Jobs_MVC.Models.Candidate> Candidate { get; set; }

        public DbSet<Apply_Jobs_MVC.Models.Employer> Employer { get; set; }
    }
}
