using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalcTest.CalculatorIO3
{
    class IOTaxCalcThree
    {

        public void CollectInputAndOutputThree()
        {

           // double MISC_TAX = 0.10;
            double basicTax = 0.10;
            double importedTax = 0.5;


            Console.WriteLine("Input 3 ");
            //product 1
            Console.Write(" Enter the product name:  ");
            string productName = Console.ReadLine();
            Console.Write("Enter the product price:  ");
            double productPrice = Convert.ToDouble(Console.ReadLine());
            double calculated = productPrice * 0.15;
            Console.WriteLine(calculated);
            calculated = Math.Round(calculated, 2, MidpointRounding.ToEven);
           
            productPrice += calculated;
            Console.WriteLine(productPrice);



            Console.WriteLine("Is Product  Imported or not   true/false: ");
            bool isFirstProductNotImported = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Enter Product Quantity: ");
            int firstProductQuantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("add another Product ");


            //Collect input product 2
            Console.Write("Enter the product name: ");
            string SecondProductName = Console.ReadLine();

            Console.Write("Enter the product price: ");
            double SecondProductPrice = Convert.ToDouble(Console.ReadLine());
            double secondProductPriceTax = SecondProductPrice * basicTax;
            SecondProductPrice += secondProductPriceTax;    
            SecondProductPrice = Math.Round(SecondProductPrice, 2, MidpointRounding.ToEven);  


            Console.Write("Is Product Not Imported   true/false: ");
            bool isSecondProductNotImported = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Enter Product Quantity: ");
            int SecondProductQuantity = Convert.ToInt32(Console.ReadLine());


            //third product

            Console.WriteLine("add another Product ");

            Console.Write(" Enter the product name:  ");
            string thirdProductName = Console.ReadLine();


            Console.Write("Enter the product price:  ");
            double thirdProductPrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Is Product Not  Imported   true/false: ");
            bool isThirdProductNotImported = Convert.ToBoolean(Console.ReadLine());


            Console.Write("Enter Product Quantity: ");
            int thirdProductQuantity = Convert.ToInt32(Console.ReadLine());

            //4th product

            Console.WriteLine("add another Product ");

            Console.Write(" Enter the product name:  ");
            string fourthProductName = Console.ReadLine();


            Console.Write("Enter the product price:  ");
            double fourthProductPrice = Convert.ToDouble(Console.ReadLine());
            double fourthProductPriceTax = fourthProductPrice * importedTax;
            fourthProductPrice += fourthProductPriceTax;
            fourthProductPrice = Math.Round(fourthProductPrice, 2, MidpointRounding.ToEven);

            Console.Write("Is Product Imported or Not true/false: ");
            bool isFourthProductNotImported = Convert.ToBoolean(Console.ReadLine());


            Console.Write("Enter Product Quantity: ");
            int fourthProductQuantity = Convert.ToInt32(Console.ReadLine());


            double Total;
            double salesTax = calculated  + secondProductPriceTax + fourthProductPriceTax ;


            if (isFirstProductNotImported && isSecondProductNotImported && isThirdProductNotImported   && isFourthProductNotImported == true)
            {

                
                salesTax = Math.Round(salesTax, 2, MidpointRounding.ToEven);
                Total = productPrice + SecondProductPrice + thirdProductPrice + salesTax;
                Total = Math.Round(Total, 2, MidpointRounding.ToEven);

                Console.WriteLine(" OUTPUT 3");
                Console.WriteLine(firstProductQuantity + " " + productName + " " + " :" + productPrice + "\n" + SecondProductQuantity + SecondProductName +
                    ":" + SecondProductPrice + "\n" + thirdProductQuantity + " " + thirdProductName + " :" + " " + thirdProductPrice +   "\n"  + fourthProductQuantity + " " +
                  fourthProductName +   " :"  +  fourthProductPrice + "\n" + " SalesTax :" +
                    salesTax + "\n" + "Total: " + Total);

            }

        }
    }
}
    
