namespace ProductCRUD.Models
{
    public class DbContxt
    {
        private DbContxtOptions<InvntoryContext> options;

        public DbContxt(DbContxtOptions<InvntoryContext> options)
        {
            this.options = options;
        }
    }
}