using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vin.DataAccess.Sample.Echo.DataContracts;
using Vin.DataAccess.Sample.Echo.Interfaces;

namespace Vin.DataAccess.Sample.Echo.Repositories.S3
{
    internal class SecureStorage_S3 : ISecureStorageRepository
    {
        public Resource GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Resource entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Resource entity)
        {
            throw new NotImplementedException();
        }

        public string SaveWithOptions(Resource resource, IResourceOptions options)
        {
            if (options.Options.ContainsKey("") == false)
            {
                throw new ArgumentException();
            }

            return string.Empty;
        }
    }
}
