using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vin.DataAccess.Sample.Echo.DataContracts;
using Vin.DataAccess.Sample.Echo.Repositories;
using Vin.DataAccess.Sample.Echo.Repositories.AzureBlob;
using Vin.DataAccess.Sample.Echo.Repositories.S3;

namespace Vin.DataAccess.Sample.Echo.Factories
{
    internal static class SecureStorageRepositoryFactory
    {
        internal static ISecureStorageRepository Create(DealerSettings settings)
        {
            switch (settings.SecureStorageProvider)
            {
                case 1:
                {
                    return new SecureStorage_S3();
                }
                default:
                {
                    return new SecureStorage_Azure();
                }
            }
        }
    }
}
