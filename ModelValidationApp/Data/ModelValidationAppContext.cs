using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ModelValidationApp.Models
{
    public class ModelValidationAppContext : DbContext
    {
        public ModelValidationAppContext (DbContextOptions<ModelValidationAppContext> options)
            : base(options)
        {
        }

        public DbSet<ModelValidationApp.Models.User> User { get; set; }
    }
}
