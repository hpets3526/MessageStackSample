using System.ServiceModel;
using System.ServiceModel.Configuration;

namespace Vin.Contract.Sample.EchoManager
{
    [ServiceContract]
    public interface IEchoManager
    {
        [OperationContract]
        string EchoMe(string echoMe);
    }
}