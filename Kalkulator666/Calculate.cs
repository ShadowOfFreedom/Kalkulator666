using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator666
{
    class Calculate
    {
        static private decimal operand1;
        static private decimal operand2;
        static private string output;
        static private char sign;
       
        static public string Equals(string userOperand1, string userOperand2, char userSign)
        {

            operand1 = Convert.ToDecimal(userOperand1);
            operand2 = Convert.ToDecimal(userOperand2);
            
            switch (userSign)
            {
                case '+':
                    return output = Convert.ToString(operand1 + operand2); break;
                case '-':
                    return output = Convert.ToString(operand1 - operand2); break;
                case '*':
                    return output = Convert.ToString(operand1 * operand2); break;
                case '/':
                    if (operand2 == 0)
                    {
                        return output = Convert.ToString(operand1); break;
                    }
                    else
                    {
                        return output = Convert.ToString(operand1 / operand2); break;
                    }
                default:
                    return null;
            }
        }

    }
}