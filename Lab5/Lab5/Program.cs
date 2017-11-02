using System;

class Program
{
    static void Main()
    {
        int a = 10;
        int B = EO(a);


        Console.WriteLine("Number {0} is {1}",a,B);
      
    }

    static int EO(int i)
    {
        
        
        if((i%2) == 0)
            {
            return 0  ;
            
           }
        else
        {

            return 1;

        }

    }
}
