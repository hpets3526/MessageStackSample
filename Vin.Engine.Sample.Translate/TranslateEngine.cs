using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vin.IFX.MessageStack.Common.Infrastructure;
using Vin.IFX.MessageStack.Common.ServiceBehaviors.InProc;

namespace Vin.Engine.Sample.Translate
{
    [InProcServiceBehavior]
    public class TranslateEngine : ServiceBase, ITranslateEngine
    {
        public string Translate(string translateMe)
        {
            var reversed = translateMe.Reverse().ToArray();
            return new string(reversed);
        }
    }
}
