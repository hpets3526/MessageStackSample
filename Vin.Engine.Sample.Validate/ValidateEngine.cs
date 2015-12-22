using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vin.IFX.MessageStack.Common.Infrastructure;
using Vin.IFX.MessageStack.Common.ServiceBehaviors.InProc;

namespace Vin.Engine.Sample.Validate
{
    [InProcServiceBehavior]
    public class ValidateEngine : ServiceBase, IValidateEngine 
    {
        public bool IsPalindrome(string message)
        {
            bool isPalindrome = false;
            char[] reversedArray = message.Reverse().ToArray();
            string reversed = new string(reversedArray);
            if (reversed == message)
            {
                isPalindrome = true;
            }
            return isPalindrome;
        }
    }
}
