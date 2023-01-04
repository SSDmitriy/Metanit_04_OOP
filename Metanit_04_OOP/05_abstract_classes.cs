// abstract classes https://metanit.com/sharp/tutorial/3.8.php

using Metanit_04_OOP;

namespace Metanit_04_OOP
{
    class _05_abstract_classes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello abstract");
            Console.WriteLine();

            Transport t1 = new Ship("spaceship");
            t1.Move();

            Transport t2 = new Car("batmobile");
            t2.Move();


            Console.WriteLine("____SHAPES____");
            Console.WriteLine();
            Rectangle r1 = new Rectangle();
            r1.Height = 5; r1.Width = 10;
            Console.WriteLine("r1 Perimeter is: " + r1.GetPerimeter());
            Console.WriteLine();

            Rectangle r2 = new Rectangle { Height = 24.0, Width = 36.0 };
            Console.WriteLine("r2 Area is: " + r2.GetArea());
            Console.WriteLine();

            Circle circ1 = new Circle { Radius = 12 };
            Console.WriteLine("circle1 Area is: " + circ1.GetArea());
            Console.WriteLine();






        }
    }


    abstract class Transport
    {

        //abstract property
        public abstract int Speed { get; set; }

        public string Name { get; }

        //constructor of abstract class
        public Transport(string name)
        {
            Name = name;
        }
        public abstract void Move();

    }


    class Ship : Transport
    {

        //need implement abstract PROPERTY (Speed) with "override"
        public override int Speed { get; set; }


        //need call constructor of parent class
        public Ship(string name) : base(name)
        {
        }

        //implement abstract method of parent class
        public override void Move()
        {
            Console.WriteLine("Ship is moving");
        }

    }



    class Car : Transport
    {

        int speed;
        public override int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public Car(string name) : base(name) { }

        public override void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }


    //abstract SHAPE with implement CIRCLE and RECTANGLE
    public abstract class Shape
    {
        public abstract double GetPerimeter();
        public abstract double GetArea();
    }

    public class Rectangle : Shape
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public override double GetPerimeter()
        {
            return (Height + Width) * 2;
        }

        public override double GetArea()
        {
            return Height * Width;
        }
    }


    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double GetArea()
        {
            return 3.14 * Radius * Radius;
        }

        public override double GetPerimeter()
        {
            return 2 * 3.14 * Radius;
        }


    }


}

