using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceBus.Messaging;
using Vin.Contract.Sample.EchoManager;
using Vin.IFX.MessageStack.Common.Clients;
using Vin.IFX.MessageStack.Common.Infrastructure;

namespace Vin.Proxy.Sample.Echo
{
    public class EventProxy : PublisherProxyBase<IEvent>, IEvent
    {
        public EventProxy(BindingParams bindingParams) : base(bindingParams)
        { }

        public void MyEvent1(string message)
        {
            var channel = Channel;
            using (new OperationContextScope((IContextChannel) channel))
            {
                BrokeredMessageProperty brokeredMessageProperty = new BrokeredMessageProperty();
                brokeredMessageProperty.Properties["EventName"] = "MyEvent1";
                OperationContext.Current.OutgoingMessageProperties.Add(BrokeredMessageProperty.Name, brokeredMessageProperty);
                channel.MyEvent1(message);
            }
        }

        public void MyEvent2(string message)
        {
            var channel = Channel;
            using (new OperationContextScope((IContextChannel)channel))
            {
                BrokeredMessageProperty brokeredMessageProperty = new BrokeredMessageProperty();
                brokeredMessageProperty.Properties["EventName"] = "MyEvent2";
                OperationContext.Current.OutgoingMessageProperties.Add(BrokeredMessageProperty.Name, brokeredMessageProperty);
                channel.MyEvent2(message);
            }
        }
    }
}
