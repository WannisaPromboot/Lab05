using System;

class Program
{
    static void Main()
    {
        double d = 5e9d;
        Console.WriteLine(d);
        int i = (int)d;
        Console.WriteLine(i);

       
            double myDouble = d;
          //  Console.WriteLine(myDouble);

            int myLong = (int)myDouble;
        //  Console.WriteLine(myLong);

        Console.WriteLine("Checked : double is {0} covert to {1}",d, myLong);


    }


}

