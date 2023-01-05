
// System.Object https://metanit.com/sharp/tutorial/3.10.php
// methods ToString() GetHashCode() GetType() Equals()

namespace Metanit_04_OOP
{
    class _06_SystemObject
    {
        static void Main(string[] strings)
        {
            Console.WriteLine("Print System Object theme");
            Console.WriteLine();

            Console.WriteLine("ToString()");
            int i = 7;
            Console.WriteLine(i.ToString());
            //Console.WriteLine(i.GetHashCode());

            Person p1 = new Person { Name = "Tom" };
            Console.WriteLine("Person ToString" + p1.ToString());
            Console.WriteLine("Also implicit call ToString: " + p1);

            Console.WriteLine();

            Clock clock = new Clock { Hours = 15, Minutes = 27, Seconds = 36 };
            Console.WriteLine("Clock ToString: " + clock.ToString());
            
            
            Console.WriteLine();

            Person p2 = new Person { Name = "Bob" };
            Console.WriteLine("Person p1 HashCode: " + p1.GetHashCode());
            Console.WriteLine("Person p2 HashCode: " + p2.GetHashCode());
            Person p3 = p1;
            Console.WriteLine("Person p3=p1 HashCode: " + p3.GetHashCode());


            Console.WriteLine();
            Console.WriteLine("clock override HashCode");

            Clock clock2 = new Clock { Hours = 22, Minutes = 24, Seconds = 22 };
            Console.WriteLine("clock2 HashCode: " + clock2.GetHashCode());

            Console.WriteLine();
            Console.WriteLine("___GET_TYPE and TYPE_OF_____"); // GetType() - can not overrided
            Console.WriteLine("p1 GetType(): " + p1.GetType());
            Console.WriteLine();
            
            object ob1 = new Person { Name = "Tom" }; //Name like p1
            if (ob1.GetType() == typeof(Person)) Console.WriteLine("ob1 from class Person");
            //or check with "is"
            if (ob1 is Person) Console.WriteLine("ob1 IS A class Person");

            Console.WriteLine();
            Console.WriteLine("___EQUALS___");
            var per1 = new Person { Name = "Tim" };
            var per2 = new Person { Name = "Bill" };
            var per3 = new Person { Name = "Tim" };

            bool per1Eqper2 = per1.Equals(per2);
            Console.WriteLine("per1 is EQUAL per2 (with overriding NAME): " + per1Eqper2);
            bool per1Eqper3 = per1.Equals(per3);
            Console.WriteLine("per1 is EQUAL per3 (with overriding NAME): " + per1Eqper3);




        }
    }

    class Person
    {
        public string Name { get; set; }

        // override Equals()
        public override bool Equals(object? obj) //pay attention to "?" - nullable object
        {
            if (obj is Person person) return Name == person.Name;
            return false; // else
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }

    class Clock
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        //overriding ToString
        public override string ToString()
        {
            return $"{Hours} : {Minutes} : {Seconds}";
        }

        //override GetHashCode()
        public override int GetHashCode()
        {
            return Minutes.GetHashCode();
        }

       
    }

    




}
