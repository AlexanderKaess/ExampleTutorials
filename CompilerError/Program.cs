using System;

namespace CompilerError
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //i = 10;                   // CS0120
            //f();                      // CS0120
            //int p = Prop;             // CS0120

            // Try the following lines instead.
            var mp = new Program();
            mp.i = 10;
            mp.f();
            int p = mp.Prop;

            //TestCall();               // CS0120

            // To call a non-static method from Main,
            // first create an instance of the class.
            // Use the following two lines instead:
            var anInstanceofMyClass = new Program();
            anInstanceofMyClass.TestCall();

            DoIt("Hello There\n");        // CS0120


            //The following example demonstrates a class with two class constructors, one without arguments and one with two arguments.
            var p1 = new Coords();
            var p2 = new Coords(5, 3);

            // Display the results using the overriden ToString method.
            Console.WriteLine("Coords #1 at {0}", p1);
            Console.WriteLine($"Coords #2 at {p2}\n");

            //In this example, the class Person does not have any constructors, in which case, 
            //a parameterless constructor is automatically provided and the fields are initialized to their default values.
            //Notice that the default value of age is 0 and the default value of name is null.
            //var person = new Person();
            Person person = new Person();

            Console.WriteLine($"Name: {person.name}, Age: {person.age}");
            Console.WriteLine("Press any key to exit.\n");

            //The following example demonstrates using the base class initializer. The Circle class is derived from the general class Shape, 
            //and the Cylinder class is derived from the Circle class. The constructor on each derived class is using its base class initializer.
            double radius = 2.5;
            double height = 3.0;

            Circle ring = new Circle(radius);
            Cylinder tube = new Cylinder(radius, height);

            Console.WriteLine("Area of the circle = {0:F2}", ring.Area());
            Console.WriteLine("Area of the cylinder = {0:F2}", tube.Area());
            Console.WriteLine("Press any key to exit.");

            Console.ReadKey();
        }

        // Non-static field.
        public int i;
        // Non-static method.
        public void f() { }
        // Non-static property.
        int Prop
        {
            get
            {
                return 1;
            }
        }

        public void TestCall()
        {
            //bla bla bla 
        }
        //private void DoIt(string sText)
        //You could also add the keyword static to the method definition.
        private static void DoIt(string sText)
        {
            Console.WriteLine(sText);
        }
    }

    class Coords
    {
        public int x, y;

        // Default constructor.
        public Coords()
        {
            x = 0;
            y = 0;
        }

        // A constructor with two arguments.
        public Coords(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // Override the ToString method.
        public override string ToString()
        {
            return $"({x},{y})";
        }
    }

    public class Person
    {
        public int age;
        public string name;
    }

    abstract class Shape
    {
        public const double pi = Math.PI;
        protected double x, y;

        public Shape(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract double Area();
    }

    class Circle : Shape
    {
        public Circle(double radius) : base(radius, 0)
        {
        }

        public override double Area()
        {
            return pi * x * x;
        }
    }

    class Cylinder : Circle
    {
        public Cylinder(double radius, double height) : base(radius)
        {
            y = height;
        }

        public override double Area()
        {
            return (2 * base.Area()) + (2 * pi * x * y);
        }
    }
}
