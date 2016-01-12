using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Vin.Contract.Sample.EchoManager
{
    [ServiceContract]
    public interface IEvent
    {
        [OperationContract(IsOneWay = true)]
        void MyEvent1(string message);
        [OperationContract(IsOneWay = true)]
        void MyEvent2(string message);
    }
}
