using System;
using System.Threading.Channels;

class Test
{

    public static void Main(string[] args)
    {
        
        //Temp converter
        
        Console.WriteLine("Temperature Converter Started");
        Console.WriteLine("1.Choose Fahrenheit to Celcius");
        Console.WriteLine("2.Choose Celcius to Fahrenheit");

        int choice = Convert.ToInt32(Console.ReadLine());
        
        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter Fahrenheit temperature: ");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());
                double celcius = (fahrenheit - 32) / 1.8;
                Console.WriteLine($"Temperature in celcius:{celcius:F2}");
                break;
            
            case 2:
                Console.WriteLine("Enter Celcius temperature: ");
                double celci = Convert.ToDouble(Console.ReadLine());
                double fahrenh = (celci * 1.8) + 32;
                Console.WriteLine($"Temperature in fahrenheit:{fahrenh:F2}");
                break;
            
            default:
                Console.WriteLine("Invalid choice");
                break;
                
        }
        


    }
    
}
