using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vin.Engine.Sample.Translate;
using Vin.Engine.Sample.Validate;
using Vin.IFX.MessageStack.Common.Clients;

namespace Vin.Manager.Sample.Echo.Factories
{
    internal class EngineFactory : IEngineFactory
    {
        public ITranslateEngine CreateTranslateEngine()
        {
            var proxy = InProcFactory.CreateInstance<TranslateEngine, ITranslateEngine>();
            return proxy;
        }

        public IValidateEngine CreateValidateEngine()
        {
            var proxy = InProcFactory.CreateInstance<ValidateEngine, IValidateEngine>();
            return proxy;
        }
    }
}
