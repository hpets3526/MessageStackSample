using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vin.Contract.Sample.EchoManager;
using Vin.IFX.MessageStack.Common.Infrastructure;
using Vin.IFX.MessageStack.Common.ServiceBehaviors.PubSub;

namespace Vin.Manager.Sample.Echo
{
    [SubscriptionServiceBehavior]
    public class EchoEventHandler : ServiceBase, IEvent
    {
        public void MyEvent1(string message)
        {
            //do something here...
        }

        public void MyEvent2(string message)
        {
            //do something here...
        }
    }
}
