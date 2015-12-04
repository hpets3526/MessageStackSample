using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vin.IFX.MessageStack.Common.Enumerations;
using Vin.IFX.MessageStack.Common.Helpers;
using Vin.IFX.MessageStack.Common.Infrastructure;
using Vin.Manager.Sample.Echo;
using ServiceBase = System.ServiceProcess.ServiceBase;

namespace Vin.Host.Sample.Echo
{
    public partial class EchoHost : ServiceBase
    {
        public EchoHost()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            BindingParams bindingParams = BindingParamsHelper.BuildDefaultBindingParams(BindingType.Intranet);
            HostHelper.Start<EchoManager>(bindingParams, () => { });
        }

        protected override void OnStop()
        {
            HostHelper.Close();
        }

        protected override void OnPause()
        {
            HostHelper.Close();
            base.OnPause();
        }

        protected override void OnContinue()
        {
            BindingParams bindingParams = BindingParamsHelper.BuildDefaultBindingParams(BindingType.Intranet);
            HostHelper.Start<EchoManager>(bindingParams, () => { });
            base.OnContinue();
        }

        protected override void OnShutdown()
        {
            HostHelper.Close();
            base.OnShutdown();
        }
    }
}
