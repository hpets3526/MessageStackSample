using Vin.DataAccess.Sample.Echo.DataContracts;
using Vin.DataAccess.Sample.Echo.Repositories;

namespace Vin.DataAccess.Sample.Echo.Factories
{
    internal interface IRepositoryFactory
    {
        ISecureStorageRepository CreateSecureStorageRepository(DealerSettings settings);
        IFileRepository CreateFileRepository(DealerSettings settings);
    }
}