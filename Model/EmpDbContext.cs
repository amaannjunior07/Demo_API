using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Diagnostics.CodeAnalysis;
namespace Demo_API.Model
{
    public class EmpDbContext :DbContext
    {
        public EmpDbContext(DbContextOptions<EmpDbContext>options):
            base(options)
        {

        }
        public DbSet<Employee>? Employees { get; set; }
    }
}
