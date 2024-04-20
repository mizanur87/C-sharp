using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;

class Test
{

    public static void Main(string[] args)
    {
        
        //Break and continue
        int startNum,endNum;
        
        Console.Write("Enter Start Number:");
        startNum = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter End Number:");
        endNum = Convert.ToInt32(Console.ReadLine());

        for (int i = startNum; i <= endNum; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} * {j} = {i*j}");
                
            }
            Console.WriteLine("");
        }

    }
    
}
