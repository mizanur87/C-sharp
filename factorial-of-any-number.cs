using System;
using System.Threading.Channels;

class Test
{

    public static void Main(string[] args)
    {

        int fac;
        fac = Convert.ToInt32(Console.ReadLine());
        int fact = 1;
        

        for (int i = fac; i >= 1; i--)
        {
            fact = fact * i;
        }
        Console.WriteLine($"{fact}");
            
        
    }
    
}
