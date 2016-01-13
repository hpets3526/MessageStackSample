using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure;
using Vin.Contract.Sample.EchoManager;
using Vin.Engine.Sample.Translate;
using Vin.IFX.MessageStack.Common.Clients;
using Vin.IFX.MessageStack.Common.Infrastructure;
using Vin.IFX.MessageStack.Common.Logging.Client;
using Vin.IFX.MessageStack.Common.ServiceBehaviors.Intranet;
using Vin.Manager.Sample.Echo.Factories;
using System.Configuration;

namespace Vin.Manager.Sample.Echo
{
    [IntranetServiceBehavior]
    public class EchoManager : ServiceBase, IEchoManager
    {
        public string EchoMe(string echoMe)
        {
            string translated = "This is a palindrome";

            LogManagerClient myClient = new LogManagerClient();
            string application = ConfigurationManager.AppSettings["Application"];
            myClient.WriteLogInfo(application, "Random Logging Message");

            var engineMaker = new EngineMaker<EngineFactory>();
            if (engineMaker.ValidateEngine.IsPalindrome(echoMe) == false)
            {
                translated = engineMaker.TranslateEngine.Translate(echoMe);
            }
            
            return translated;
        }
    }
}
