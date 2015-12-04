using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vin.Contract.Sample.EchoManager;
using Vin.Engine.Sample.Translate;
using Vin.IFX.MessageStack.Common.Clients;
using Vin.IFX.MessageStack.Common.Infrastructure;
using Vin.IFX.MessageStack.Common.ServiceBehaviors.Intranet;

namespace Vin.Manager.Sample.Echo
{
    [IntranetServiceBehavior]
    public class EchoManager : ServiceBase, IEchoManager
    {
        public string EchoMe(string echoMe)
        {
            var proxy = InProcFactory.CreateInstance<TranslateEngine, ITranslateEngine>();
            string translated = proxy.Translate(echoMe);
            return translated;
        }
    }
}
