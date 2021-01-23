namespace dnc.api.Persistance
{
    public interface IUnitOfWork
    {
        int Complete();
    }            
}