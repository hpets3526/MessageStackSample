using Vin.DataAccess.Sample.Echo.DataContracts;
using Vin.DataAccess.Sample.Echo.Interfaces;

namespace Vin.DataAccess.Sample.Echo.Repositories
{
    internal interface ISecureStorageRepository : IRepository<Resource, int>
    {
        string SaveWithOptions(Resource resource, IResourceOptions options);
    }
}