using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vin.DataAccess.Sample.Echo.Interfaces;

namespace Vin.DataAccess.Sample.Echo.Repositories.AzureBlob
{
    internal class SecureStorage_Azure : ISecureStorageRepository
    {
        public DataContracts.Resource GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(DataContracts.Resource entity)
        {
            throw new NotImplementedException();
        }

        public void Update(DataContracts.Resource entity)
        {
            throw new NotImplementedException();
        }

        public string SaveWithOptions(DataContracts.Resource resource, IResourceOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
