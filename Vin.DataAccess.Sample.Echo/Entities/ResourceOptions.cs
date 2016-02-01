using System;
using System.Collections.Generic;
using System.Configuration;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vin.DataAccess.Sample.Echo.Interfaces;

namespace Vin.DataAccess.Sample.Echo.Entities
{
    internal class ResourceOptions : IResourceOptions
    {
        internal ResourceOptions()
        {
            Options = new Dictionary<string, string>();
        }
        public string ResourceName { get; set; }

        public Dictionary<string, string> Options { get; set; }
    }
}
