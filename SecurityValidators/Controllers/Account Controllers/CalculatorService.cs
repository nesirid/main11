namespace CalculatorService.Controllers.Account_Controllers
{
    internal class CalculatorService
    {
        public void Calculation(double num1, double num2, char operation)
        {
            double result;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                    Console.WriteLine("Sifira bolunmur");
                    return;
                    }
                    break;
                default:

                    Console.WriteLine("Xata Yalnish emeliyyat");
                    return;
            }
            Console.WriteLine($"Cavabi: {result}");
        }

    }
}
