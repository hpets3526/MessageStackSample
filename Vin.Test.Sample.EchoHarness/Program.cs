using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vin.IFX.MessageStack.Common.Enumerations;
using Vin.IFX.MessageStack.Common.Helpers;
using Vin.IFX.MessageStack.Common.Infrastructure;
using Vin.Manager.Sample.Echo;
using Vin.Proxy.Sample.Echo;

namespace Vin.Test.Sample.EchoHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            BindingParams bindingParams = BindingParamsHelper.BuildDefaultBindingParams(BindingType.Intranet);

            HostHelper.Start<EchoManager>(bindingParams, () =>
            {
                Console.WriteLine("Test Harness Started and Services running...");
                Console.Read();
            });

            while (true)
            {
                string input = Console.ReadLine();
                var client = new EchoManager_Client();
                string output = client.EchoMe(input);
                Console.WriteLine(output);
            }
        }
    }
}
