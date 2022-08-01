using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalcTest.CalculatorIO1
{
    class IOCalcOne
    {
       




    //double BOOK_TAX = 0.0;
    //double FOOD_TAX = 0.0;
    //double MEDICAL_TAX = 0.0;
  

        public  void CollectInputAndOutputOne()
        {

            double MISC_TAX = 0.10;
            

            Console.WriteLine("Input 1 ");
            

            //product 1
            Console.Write(" Enter the product name:  ");
            string productName = Console.ReadLine();

         
 
                Console.Write("Enter the product price:  ");
                double productPrice = Convert.ToDouble(Console.ReadLine());
            


            

            Console.Write("Is Product Not Imported or  true/false: ");
            bool isFirstProductNotImported = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Enter Product Quantity: ");
            int firstProductQuantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("add another Product ");


            //Collect input product 2
            Console.Write("Enter the product name: ");
            string SecondProductName = Console.ReadLine();


            Console.Write("Enter the product price: ");
            double SecondProductPrice = Convert.ToDouble(Console.ReadLine());
            double calculatedTax = SecondProductPrice * MISC_TAX;
            SecondProductPrice += calculatedTax;
            SecondProductPrice = Math.Round(SecondProductPrice, 2, MidpointRounding.ToEven);
            calculatedTax = Math.Round(calculatedTax, 2, MidpointRounding.ToEven);




            Console.WriteLine(SecondProductPrice);

            Console.Write("Is Product  Not Imported or  true/false: ");
            bool isSecondProductNotImported = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Enter Product Quantity: ");
            int SecondProductQuantity = Convert.ToInt32(Console.ReadLine());


            //third product

            Console.WriteLine("add another Product ");

            Console.Write(" Enter the product name:  ");
            string thirdProductName = Console.ReadLine();


            Console.Write("Enter the product price:  ");
            double thirdProductPrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Is Product Not Imported or  true/false: ");
            bool isThirdProductNotImported = Convert.ToBoolean(Console.ReadLine());


            Console.Write("Enter Product Quantity: ");
            int thirdProductQuantity = Convert.ToInt32(Console.ReadLine());


            double Total;
           


            if (isFirstProductNotImported && isSecondProductNotImported && isThirdProductNotImported == true)
            {

              
                Total = productPrice + SecondProductPrice + thirdProductPrice ;
                Total = Math.Round(Total, 2, MidpointRounding.ToEven);

                Console.WriteLine(" OUTPUT 1");
                Console.WriteLine(firstProductQuantity + " " + productName + " " + " :" + productPrice + "\n" + "" + SecondProductQuantity + SecondProductName +
                    ":" + SecondProductPrice + "\n" + thirdProductQuantity + " " + thirdProductName + " :" + " " + thirdProductPrice + "\n" + " SalesTax :" +
                    calculatedTax + "\n" + "Total: " + Total);

            }





        }






    }
}
