// VIRTUAL methods and propeties https://metanit.com/sharp/tutorial/3.19.php
// in base class we use "virtual"
//in child class we use "override" for method or property
// we should use "sealed" in CHILD class if we don't want permit overriding for meths and props
namespace _03
{
    class _03_Virtual_Meths_and_Props
    {
        //*
        static void Main(string[] args)
        {
            Console.WriteLine("Hello 03");

            Person bob = new Person("Bob");
            bob.Print();

            Employee emp1 = new Employee("Tom", "ms");
            emp1.Print();


            Manager man1 = new Manager("mng1", "job title");
            man1.Print();


            Console.WriteLine("________");
            Manager man2 = new Manager("mng2", "overrjob");
            Console.WriteLine(man2.Age);
            man2.Age = 10;
            Console.WriteLine(man2.Age);//18
            man2.Age = 55;
            Console.WriteLine(man2.Age);

        }

        //*/

    }

    class Person
    {

        int age;

        public string Name { get; set; }

        //VIRTUAL property for overriding
        public virtual int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person(string name)
        {
            Name = name;
        }

        public virtual void Print()
        {
            Console.WriteLine("This method from BASE-class person. Name is: " + Name);
        }
    }

    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string name, string company) : base(name)
        {
            Company = company;
        }

        public override void Print()
        {
            Console.WriteLine("This method from EMLOYEE-class. Name is: " + Name);

        }
    }

    //override properties
    class Manager : Person
    {

        //OVERRIDE property
        public override int Age
        {
            get { return base.Age; }
            set
            {
                if (value > 17 && value < 100)
                {
                    base.Age = value;
                }
                else { base.Age = 18; }

                Console.WriteLine("overriding property in MANAGER");
            }

        }

        public string Job { get; set; }

        public Manager(string name, string job) : base(name)
        {
            Job = job;
        }

        //overriding method
        public override void Print()
        {
            base.Print();
            Console.WriteLine("print from MANAGER");
        }

    }

}