namespace Vin.DataAccess.Sample.Echo.Repositories
{
    internal interface IRepository<T,K>
    {
        T GetById(K id);
        void Save(T entity);
        void Update(T entity);
    }
}