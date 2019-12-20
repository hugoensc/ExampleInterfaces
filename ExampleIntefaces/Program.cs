using System;

namespace ExampleIntefaces
{
    class Program
    {
        interface IPoint
        {
            // Property signatures:
            int x
            {
                get;
                set;
            }

            int y
            {
                get;
                set;
            }
        }


        public class Point : IPoint
        {
            // Fields:
            private int _x;
            private int _y;

            // Contructor
            public Point(int x, int y)
            {
                _x = x;
                _y = y;
            }

            // Property implementation
            public int x
            {
                get
                {
                    return _x;
                }

                set
                {
                    _x = value;
                }
            }

            public int y
            {
                get
                {
                    return _y;
                }

                set
                {
                    _y = value;
                }
            }
        }

        static void Main(string[] args)
        {
            IPoint point = new Point(2, 3);
            Console.WriteLine("My point: ");
            PrintPoint(point);
        }

        static void PrintPoint(IPoint point)
        {
            Console.WriteLine("x = {0}, y = {1}", point.x, point.y);
        }
    }
}
