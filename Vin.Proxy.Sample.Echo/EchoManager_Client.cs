using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vin.Contract.Sample.EchoManager;
using Vin.IFX.MessageStack.Common.Enumerations;
using Vin.IFX.MessageStack.Common.Helpers;
using Vin.IFX.MessageStack.Common.Infrastructure;
using Vin.IFX.MessageStack.Common.PubSub;

namespace Vin.Proxy.Sample.Echo
{
    public class EchoManager_Client : IEchoManager, IEvent
    {
        private BindingParams _bindingParams;
        public EchoManager_Client(BindingParams bindingParams)
        {
            _bindingParams = bindingParams;
        }

        public string EchoMe(string echoMe)
        {
            EchoProxy proxy = null;
            try
            {
                proxy = new EchoProxy(_bindingParams);
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

        public void MyEvent1(string message)
        {
            EventProxy proxy = null;
            try
            {
                proxy = new EventProxy(_bindingParams);
                proxy.MyEvent1(message);
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

        public void MyEvent2(string message)
        {
            EventProxy proxy = null;
            try
            {
                proxy = new EventProxy(_bindingParams);
                proxy.MyEvent2(message);
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
