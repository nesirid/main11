using SecurityValidators.DataSecurityValidators.Controllers;
using SecurityValidators.ExtensionMethods.Controllers;
using CalculatorService.Controllers.Account_Controllers;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 1, 2, 3, 4, 5, 6 };
            //int product = numbers.CalculateProduct();
            //Console.WriteLine("Massiv elementlerinin hasili: " + product);

            //string email = "numune@cod.edu.az";
            //bool HasAtSymbol = email.HasAtSymbol();
            //Console.WriteLine("@ simvolu: " + HasAtSymbol);

            //string email = "testemail@code.edu.az";
            //bool hasAtSymbol = email.HasAtSymbol(); // Metodu Istfade Edirem
            //Console.WriteLine("@ Simvolu: " + hasAtSymbol);
      
                Console.WriteLine("Birinci regemi daxil edin: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ikinci Reqemi Daxil Edin:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Aperatorlardan birini daxil edin: (+, /, -, * ):");
                char operation = Convert.ToChar(Console.ReadLine());
                
        }
    }

    
}


