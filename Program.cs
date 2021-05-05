using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatoroverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // circle c1 , c2 . c1+c2
            string name1 = "deepali";
            string name2 = "kamatkar";
            string name3 = name1 + name2; //overloaded 


            Box Box1 = new Box();   // Declare Box1 of type Box
            Box Box2 = new Box();   // Declare Box2 of type Box
            Box Box3 = new Box();   // Declare Box3 of type Box
            double volume = 0.0;    // Store the volume of a box here
            Box Box4 = new Box();
            // box 1 specification
            Box1.setLength(6.0);
            Box1.setBreadth(7.0);
            Box1.setHeight(5.0);

            // box 2 specification
            Box2.setLength(12.0);
            Box2.setBreadth(13.0);
            Box2.setHeight(10.0);

            //box 4 specifications
            Box4.setLength(12.0);
            Box4.setBreadth(13.0);
            Box4.setHeight(10.0);

            // volume of box 1
            volume = Box1.getVolume();
            Console.WriteLine("Volume of Box1 : {0}", volume);

            // volume of box 2
            volume = Box2.getVolume();
            Console.WriteLine("Volume of Box2 : {0}", volume);
            //int sum = 3 + 4 + 5;
            // Add two object as follows:
            Box3 = Box1 + Box2 + Box4+Box4; 

            // volume of box 3
            volume = Box3.getVolume();
            Console.WriteLine("Volume of Box3 : {0}", volume);
            Console.ReadKey();
            //hello all
            Circle c1 = new Circle();
            c1._radius = 34;
            Circle c2 = new Circle();
            c2._radius = 22;
            Circle c4 = new Circle();
            Circle c3 = c1 + c2 + c4; ;
           // c3.calarea();



        }
    }
}
    

