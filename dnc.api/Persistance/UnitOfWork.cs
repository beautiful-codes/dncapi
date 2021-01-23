namespace dnc.api.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApiDbContext context;

        public UnitOfWork(ApiDbContext context)
        {
            this.context = context;
        }

        public int Complete()
        {
            return this.context.SaveChanges();
        }
    }
}