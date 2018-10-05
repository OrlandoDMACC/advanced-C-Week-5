using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Week5project.Models
{
    public class employeeContext : DbContext
    {
        public employeeContext (DbContextOptions<employeeContext> options)
            : base(options)
        {
        }

        public DbSet<Week5project.Models.employeeModel> employeeModel { get; set; }
    }
}
