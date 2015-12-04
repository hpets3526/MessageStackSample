using System.ServiceModel;

namespace Vin.Engine.Sample.Translate
{
    [ServiceContract]
    public interface ITranslateEngine
    {
        [OperationContract]
        string Translate(string translateMe);
    }
}