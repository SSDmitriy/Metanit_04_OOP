//inheritance https://metanit.com/sharp/tutorial/3.7.php

namespace Metanit_04_OOP
{
    internal class Chapter01_inheritance
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello, World!");

        //    //Person person1 = new Person("Bob");
        //    //person1.Print(); // Bob

        //    //Employee employee1 = new Employee("Sam", "sam_company");
        //    //employee1.Print(); // Sam
        //    //employee1.PrintNameEmploye(); // Sam

        //    Employee emp1 = new Employee("Tom", 33, "Ms");

        //    Console.WriteLine(emp1.name + emp1.age + emp1.company);

        //}
    }


    
    /*
    class Person
    {
        private string _name = "Dan";

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Person(string name)
        {
            Name = name;
        }

        public void Print()
        {
            Console.WriteLine(Name);

        }
    }

    class Employee : Person
    {

        public string Company { get; set; }

        public Employee(string name, string company) : base(name)
        {
            Company = company;
        }

        // public void PrintNameEmploye() {Console.WriteLine(_name);} ERROR - _name is a private
        public void PrintNameEmploye() { Console.WriteLine(Name); } //Ok



    }

    */

    //can't inheritate from this SEALED class
    sealed class Admin
    {

    }

    //class InhOfAdmin : Admin
    //{

    //}

    class Person
    {
        public string name;
        public int age;

        public Person(string name)
        {
            this.name = name;
            Console.WriteLine("First constructor with \"name\"");
        }

        public Person(string name, int age) : this(name)
        {
            this.age = age;
            Console.WriteLine("Second constructor with \"name\" + \"age\"");
        }
    }

    class Employee : Person
    {
        public string company;

        public Employee (string name, int age, string company) : base(name, age)
        {
            this.company = company;
            Console.WriteLine("Third constructor in Employee with name + age + company");
        }

    }

}

//
/*
namespace Metanit_04_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


        }
    }


}

*/
