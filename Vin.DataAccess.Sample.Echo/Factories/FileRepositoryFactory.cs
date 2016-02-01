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
    internal static class FileRepositoryFactory
    {
        internal static IFileRepository Create(DealerSettings settings)
        {
            switch (settings.SecureStorageProvider)
            {
                default:
                    {
                        return new FileRepository_EF();
                    }
            }
        }
    }
}
