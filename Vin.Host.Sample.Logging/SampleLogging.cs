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
using Vin.Manager.Logging.Log;
using ServiceBase = System.ServiceProcess.ServiceBase;

namespace Vin.Host.Sample.Logging
{
    public partial class SampleLogging : ServiceBase
    {
        private BindingParams _bindingParams;
        public SampleLogging()
        {
            InitializeComponent();
            _bindingParams = BindingParamsHelper.BuildDefaultBindingParams(BindingType.Queue);
        }

        protected override void OnStart(string[] args)
        {
            HostHelper.Start<LogManager>(_bindingParams, () => { });
        }

        protected override void OnStop()
        {
            HostHelper.Close();
        }
    }
}
