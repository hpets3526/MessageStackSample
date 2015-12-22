using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vin.Contract.Sample.EchoManager;
using Vin.IFX.MessageStack.Common.Enumerations;
using Vin.IFX.MessageStack.Common.Helpers;
using Vin.IFX.MessageStack.Common.Infrastructure;

namespace Vin.Proxy.Sample.Echo
{
    public class EchoManager_Client : IEchoManager
    {
        public string EchoMe(string echoMe)
        {
            EchoProxy proxy = null;
            try
            {
                BindingParams bindingParams = BindingParamsHelper.BuildDefaultBindingParams(BindingType.Intranet);
                proxy = new EchoProxy(bindingParams);
                return proxy.EchoMe(echoMe);
            }
            catch (Exception)
            {
                if (proxy != null)
                {
                    proxy.Abort();
                }
                throw;
            }
            finally
            {
                if (proxy != null)
                {
                    proxy.Close();
                }
            }
        }
    }
}
