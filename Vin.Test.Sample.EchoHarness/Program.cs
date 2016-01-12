using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vin.IFX.MessageStack.Common.Enumerations;
using Vin.IFX.MessageStack.Common.Helpers;
using Vin.IFX.MessageStack.Common.Infrastructure;
using Vin.IFX.MessageStack.Common.PubSub;
using Vin.Manager.Sample.Echo;
using Vin.Proxy.Sample.Echo;

namespace Vin.Test.Sample.EchoHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            BindingParams bindingParams = new BindingParams();
            PublishSubscribe pubsub = new PublishSubscribe("MessageStackSampleApp", "Your namespace here", "Your access key here");
            SubscriptionDetail detail = new SubscriptionDetail("MyEvent1");
            SubscriptionDetail detail2 = new SubscriptionDetail("MyEvent2");
            pubsub.SubscriptionDetails.Add(detail);
            pubsub.SubscriptionDetails.Add(detail2);

            bindingParams.PublishSubscribe = pubsub;

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

                client.MyEvent1("Pass an Event 1");
                client.MyEvent2("Pass an Event 2");

                Console.WriteLine(output);
            }
        }
    }
}
