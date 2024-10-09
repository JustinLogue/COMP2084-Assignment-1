
using Microsoft.EntityFrameworkCore;

namespace Assignment1.Data
{
    public class ApplicationDbContext: DbContext

    {
       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
