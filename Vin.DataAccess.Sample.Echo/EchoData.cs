using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Vin.DataAccess.Sample.Echo.DataContracts;
using Vin.DataAccess.Sample.Echo.Entities;
using Vin.DataAccess.Sample.Echo.Factories;
using Vin.DataAccess.Sample.Echo.Interfaces;
using Vin.DataAccess.Sample.Echo.Repositories;
using Vin.DataAccess.Sample.Echo.Repositories.S3;
using Vin.DataAccess.Sample.Echo.ServiceContracts;

namespace Vin.DataAccess.Sample.Echo
{
    public class EchoData : IEchoData
    {
        public EchoData()
        {
        }

        public Response SaveSecureData(Resource resource)
        {
            //Get the dealer settings based on the id
            DealerSettings settings = new DealerSettings();
            Repositories<RepositoryFactory> repositories = new Repositories<RepositoryFactory>(settings);
            //Get the the options
            IResourceOptions options = new ResourceOptions();

            string path = repositories.SecureStorageRepository.SaveWithOptions(resource, options);

            return new Response();
        }

        public Response SaveFile(Resource resource)
        {
            DealerSettings settings = new DealerSettings();
            Repositories<RepositoryFactory> repositories = new Repositories<RepositoryFactory>(settings);
            repositories.FileRepository.Save(resource);
            return new Response();
        }
    }
}
