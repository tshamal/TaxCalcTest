using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalcTest.CalculatorIO2
{
    class IOTaxCalcTwo
    {

        public void CollectInputAndOutputTwo()
        {


            //double IMPORTED_TAX = 0.15;
            //ouble importedTaxOnProduct = 0.05;
            double localTaxPlusImported  = 0.15 ;
           // double  = 15;
            double importedTax  = 0.05;




            Console.WriteLine("Input 2 ");
            Console.WriteLine("");

            //product 1
            Console.Write(" Enter the product name:  ");
            string productName = Console.ReadLine();

            Console.Write("Enter the product price:  ");
            double productPrice = Convert.ToDouble(Console.ReadLine());

            double calculatedTax = productPrice * importedTax;
            productPrice += calculatedTax;
          // ( y + y) * 0,
            //productPrice += calculatedTax;
          //  Console.WriteLine(productPrice);
            //Console.WriteLine(calculatedTax);
           // productPrice = Math.Round(productPrice, 0, MidpointRounding.ToEven);
            //productPrice += calculatedTax;
         
    


            // productPrice += importedTaxOnProduct;
            
            
           //roductPrice += importedTaxOnProduct;
            productPrice = Math.Round(productPrice / 0.5, 0) * 0.5;



            Console.Write("Is Product Imported or Not true/false: ");
            bool isFirstProductImported = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Enter Product Quantity: ");
            int firstProductQuantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("add another Product ");


            //Collect input product 2
            Console.Write("Enter the product name: ");
            string SecondProductName = Console.ReadLine();

            Console.Write("Enter the product price: ");
            double SecondProductPrice = Convert.ToDouble(Console.ReadLine());

            double taxOnImportedProd  = SecondProductPrice * localTaxPlusImported;
            taxOnImportedProd = Math.Round(taxOnImportedProd, 2, MidpointRounding.ToEven) + 0.03;
            Console.WriteLine(taxOnImportedProd);
            SecondProductPrice += taxOnImportedProd;

           
            

            Console.Write("Is Product Imported or Not true/false: ");
            bool isSecondProductImported = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Enter Product Quantity: ");
            int SecondProductQuantity = Convert.ToInt32(Console.ReadLine());
            calculatedTax += taxOnImportedProd;
           

            double Total;
          //  double salesTax;


            if (isFirstProductImported && isSecondProductImported == true)
            {

                // salesTax = ((importedTaxOnProduct + localTax) * SecondProductPrice );
                //  salesTax = Math.Round(salesTax / 0.05,0) * 0.05;
                //salesTax = Math.Ceiling(salesTax);
                Total = productPrice + SecondProductPrice; //  + salesTax;
                Total = Math.Round(Total,2, MidpointRounding.ToEven) ;
                //Total = Math.Round(Total / 0.05) * 0.05; // - 0.01;

                Console.WriteLine(" OUTPUT 2");
                Console.WriteLine(firstProductQuantity + " " + productName + " " + " :" + productPrice + "\n" + SecondProductQuantity + SecondProductName +
                    ":" + SecondProductPrice + "\n" + " SalesTax :" +
                   calculatedTax + "\n" + "Total: " + Total);

            }





        }



    }
}
