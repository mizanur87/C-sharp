using System;
using System.Threading.Channels;

class Test
{

    public static void Main(string[] args)
    {

        int num1, num2;

        char operation;
        
        Console.WriteLine("Enter an operation(+,-,*,/):");
        operation = Convert.ToChar(Console.ReadLine());
        
        Console.WriteLine("Enter an number1: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter an number2: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        switch (operation)
        {
            case '+':
                Console.WriteLine($"{num1}+{num2}={num1+num2}");
                break;
            case '-':
                Console.WriteLine($"{num1}-{num2}={num1-num2}");
                break;
            case '*':
                Console.WriteLine($"{num1}-{num2}={num1*num2}");
                break;
            case '/':
                if (num2 != 0)
                { 
                    Console.WriteLine($"{num1}/{num2}={num1/num2}");
                }
                else
                {
                    Console.WriteLine("Divison is not possible");
                }
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
            
        }

    }
    
}

