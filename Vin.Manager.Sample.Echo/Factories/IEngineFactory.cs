using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vin.Engine.Sample.Translate;
using Vin.Engine.Sample.Validate;

namespace Vin.Manager.Sample.Echo.Factories
{
    internal interface IEngineFactory
    {
        ITranslateEngine CreateTranslateEngine();
        IValidateEngine CreateValidateEngine();
    }
}
