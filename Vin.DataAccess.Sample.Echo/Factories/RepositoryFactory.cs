using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vin.DataAccess.Sample.Echo.DataContracts;
using Vin.DataAccess.Sample.Echo.Repositories;
using Vin.DataAccess.Sample.Echo.Repositories.EF;

namespace Vin.DataAccess.Sample.Echo.Factories
{
    internal class RepositoryFactory : IRepositoryFactory
    {
        public ISecureStorageRepository CreateSecureStorageRepository(DealerSettings settings)
        {
            return SecureStorageRepositoryFactory.Create(settings);
        }

        public IFileRepository CreateFileRepository(DealerSettings settings)
        {
            return FileRepositoryFactory.Create(settings);
        }
    }
}
