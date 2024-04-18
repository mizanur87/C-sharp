using System;
using System.Threading.Channels;

class Test
{

    public static void Main(string[] args)
    {

        int n;
        n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                sum = sum + i;
                Console.WriteLine($"Even {i}");
            }
            
            else if (i % 2 != 0)
            {
                sum = sum + i;
                Console.WriteLine($"Odd {i}");

            }
            

        }
            
        
    }
    
}
