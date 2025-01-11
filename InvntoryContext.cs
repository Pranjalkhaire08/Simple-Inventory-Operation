using Microsoft.EntityFrameworkCore;

namespace ProductCRUD.Models
{
    public class InvntoryContext : DbContxt
    {
        public InvntoryContext(DbContxtOptions<InvntoryContext> options)
            : base(options)
        {
            
        }

        public virtual DbSet<Products> Products { get; set; }
    }
}
