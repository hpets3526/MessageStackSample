using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vin.Contract.Sample.EchoManager;
using Vin.IFX.MessageStack.Common.Clients;
using Vin.IFX.MessageStack.Common.Infrastructure;

namespace Vin.Proxy.Sample.Echo
{
    internal class EchoProxy : IntranetProxyBase<IEchoManager>, IEchoManager
    {
        internal EchoProxy(BindingParams bindingParams) : base(bindingParams)
        { }

        public string EchoMe(string echoMe)
        {
            return Channel.EchoMe(echoMe);
        }
    }
}
