using System.ServiceModel;

namespace Vin.Engine.Sample.Validate
{
    [ServiceContract]
    public interface IValidateEngine
    {
        [OperationContract]
        bool IsPalindrome(string message);
    }
}