using System;

namespace Lab_7_Test_Interface_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculation obj = new Calculation();
            int x = 20;
            int y = 5;
            Console.WriteLine("The value of x & y is: " + x + " and " + y+"\n");
            Console.WriteLine(x+" Pow "+y+" = "+obj.XtoY(x,y));
            Console.WriteLine(x+ " + "+ y +  " = "+obj.sum(x,y));
            Console.WriteLine(x+ " - "+ y +  " = "+obj.sub(x,y));
            Console.WriteLine(x+ " * "+ y +  " = "+(obj.multiplication(x,y)));
            Console.WriteLine(x+ " / "+ y +  " = "+obj.division(x,y));
            

            Console.ReadLine();
        }
    }
}
