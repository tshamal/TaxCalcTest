using System;
using TaxCalcTest.CalculatorIO1;
using TaxCalcTest.CalculatorIO2;
using TaxCalcTest.CalculatorIO3;

namespace TaxCalcTest
{
    class Program
    {
      public  static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            //input 1 Test 
             IOCalcOne input_Output_one = new IOCalcOne();
            input_Output_one.CollectInputAndOutputOne();


            //input 2 Test

            IOTaxCalcTwo input_Output_two = new IOTaxCalcTwo();
            input_Output_two.CollectInputAndOutputTwo();


            //input 3  Test
              IOTaxCalcThree input_Output_Three = new IOTaxCalcThree();
             input_Output_Three.CollectInputAndOutputThree();






            Console.ReadLine();


        }
    }
}
