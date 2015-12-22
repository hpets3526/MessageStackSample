using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vin.Engine.Sample.Translate;
using Vin.Engine.Sample.Validate;

namespace Vin.Manager.Sample.Echo.Factories
{
    internal class EngineMaker<T> where T : IEngineFactory, new()
    {
        internal EngineMaker()
        {
            T factory = new T();
            TranslateEngine = factory.CreateTranslateEngine();
            ValidateEngine = factory.CreateValidateEngine();
        }

        internal ITranslateEngine TranslateEngine { get; private set; }
        internal IValidateEngine ValidateEngine { get; private set; }
    }
}
