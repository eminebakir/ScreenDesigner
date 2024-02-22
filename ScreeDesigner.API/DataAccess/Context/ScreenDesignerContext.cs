using Microsoft.EntityFrameworkCore;
using ScreeDesigner.API.Models;

namespace ScreeDesigner.API.DataAccess.Context
{
    public class ScreenDesignerContext : DbContext
    {
        public ScreenDesignerContext(DbContextOptions<ScreenDesignerContext> options) : base(options)
        {
        }

        public DbSet<DesignElement> DesignElement { get; set; }
        public DbSet<Property> Property { get; set; }
    }
}
