using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class PracticeDelegate
    {
        public delegate void MathCalculation(float value1, float value2);
        public static void AddNumbers(float value1, float value2) { Console.WriteLine("The Add of {0} + {1} is:" + (value1 + value2),value1,value2); }
        public static void SubtractNumbers(float value1, float value2) { Console.WriteLine("The Subtract of {0} - {1} is:" + (value1 - value2), value1, value2); }
        public static void MultiplyNumbers(float value1, float value2) { Console.WriteLine("The Multiply of {0} * {1} is:" + (value1 * value2), value1, value2); }
        public static void DivideNumbers(float value1, float value2) { Console.WriteLine("The Divide of {0} / {1} is:" + (value1 / value2), value1, value2); }

        
        public static void PraciceMain()
        {

            MathCalculation calculateAll = AddNumbers;
            calculateAll += SubtractNumbers;
            calculateAll += MultiplyNumbers;
            calculateAll += DivideNumbers;
            calculateAll(1, 2);
            
        }
    }
}
