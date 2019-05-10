using System;
using Arithmatic;
namespace DelegatesDemo
{
    //Delegate is a type-safe method pointer
    //1. declare a delegate
    delegate void DelShapes(double x=3.2);
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Instantiate a delegate
            //DelShapes ds = new DelShapes(ShapeArea.CircleArea);
            /*DelShapes ds = ShapeArea.CircleArea;
            ds += ShapeArea.SquareArea;//InvocationList - FIFO
            ds -= ShapeArea.CircleArea;
            //3. Invocation of Delegates
            //ds.Invoke(3);//old way invoking delegates
            ds();*/

            //Predefined delegates in C#
            //1. Action- Delegate of type void
            // Delegate tied to a named Method
            //delAct += ShapeArea.CircleArea;

            //Delegate is tied to an anonymous method
            Action<double> delAct;
            /*delAct = delegate (double radius)
            {
                double area = Math.PI * radius * radius;
                Console.WriteLine($"Area of a circle with radius {radius} cm is {area}");
            };*/


            //delAct += ShapeArea.SquareArea;
            /*delAct += delegate (double s)
            {
                double area = s * s;
                Console.WriteLine($"Area of a Square with side {s} cm is {area}");
            };*/

            delAct = (r) => {
                double v = Math.PI * r * r;
                Console.WriteLine(v);
            };

            //delAct(6);
            //2. Func - Delegate of return type
            Func<double, double, double> DelFunc = ShapeArea.RectArea;
            //Console.WriteLine($"Area of rectangle is {DelFunc(4,8)}");

            MathLogic m = new MathLogic();
            Func<int, int, int> DelCalculate = (a, b) => a + b;

            /*DelCalculate = m.Add;
            DelCalculate += m.Sub;
            DelCalculate +=m.Multiply;
            DelCalculate +=m.Divide;
            DelCalculate -= m.Divide;*/
            Console.WriteLine(DelCalculate(5, 6));
            //3. Predicate - a delgate of type bool

            //Anonymous Methods
        }
    }
    class ShapeArea
    {
        public static void CircleArea(double radius=7)
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine($"Area of a circle with radius {radius} cm is {area}");
        }
        public static void SquareArea(double s)
        {
            double area = s * s;
            Console.WriteLine($"Area of a Square with side {s} cm is {area}");
        }
        public static double RectArea(double w, double h)
        {
            return w * h;
        }
    }
}
