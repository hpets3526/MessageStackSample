using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vin.DataAccess.Sample.Echo.DataContracts;
using Vin.DataAccess.Sample.Echo.Factories;

namespace Vin.DataAccess.Sample.Echo.Repositories
{
    internal class Repositories<T> where T : IRepositoryFactory, new()
    {
        private T _factory;

        public Repositories(DealerSettings settings)
        {
            _factory = new T();
            SecureStorageRepository = _factory.CreateSecureStorageRepository(settings);
            FileRepository = _factory.CreateFileRepository(settings);
        }

        internal ISecureStorageRepository SecureStorageRepository { get; set; }
        internal IFileRepository FileRepository { get; set; }
    }

    
}
