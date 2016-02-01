using System.Collections.Generic;

namespace Vin.DataAccess.Sample.Echo.Interfaces
{
    public interface IResourceOptions
    {
        string ResourceName { get; set; }
        Dictionary<string, string> Options { get; set; }
    }
}