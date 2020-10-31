using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask3
{
   
    class Traingle
    {
        private int x;
        private int y;
        private int z;
        public void ShowInfo(int x,int y,int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void TestTriangle()
        {
            if (x==y && y==z && z==x)
            {
                Console.WriteLine(" triangle is equilateral 3 equal sides");
            }
             else if(x!=y && y!=z && z==x)
            {
                Console.WriteLine("  isosceles 2 equal sides");
               
            }
             else if (x != y && y==z && z != x)
            {
                Console.WriteLine("  isosceles 2 equal sides");

            }
             else if (x == y && y != z && z != x)
            {
                Console.WriteLine("  isosceles 2 equal sides");

            }
                 else if(x != y && y != z && z != x)
            {
                Console.WriteLine(" scalene no equal sides ");
            }
        }
        static void Main()
        {
            Traingle ob = new Traingle();
            ob.ShowInfo(2,22,22);
            ob.TestTriangle();
            Console.ReadLine();
        }
    }
}
