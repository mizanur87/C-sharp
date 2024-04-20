using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;

class Test
{

    public static void Main(string[] args)
    {
        
        //Break and continue
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = n; i >= 1; i--)
        {
            for (int k = n-i; k > 0; k--)
            {
                Console.Write(" ");
            }

            for (int j = i; j >= 1; j--)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
        
    }
    
}
