// WOW! GENERICS! https://metanit.com/sharp/tutorial/3.12.php


/*

namespace Metanit_04_OOP
{
    class _07_Generics
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Generics!!!");
            Console.WriteLine();

            Person<int> p1 = new Person<int>(123, "Tom");
            Person<string> p2 = new Person<string>("str_123", "Bob");

            Console.WriteLine($"p1 ID: {p1.Id} - int");
            Console.WriteLine($"p2 ID: {p2.Id} - string");

            Console.WriteLine();
            Console.WriteLine("__ generic type in generic ___");
            Console.WriteLine();
            Person<int> pres1 = new Person<int>(11, "mrPresident11");
            Company<Person<int>> tesla = new Company<Person<int>>(pres1);
            Console.WriteLine($"pres1 Id: {tesla.President.Id} (int) and his name is: {tesla.President.Name}.");
            
            Person<string> pres2 = new Person<string>("22pr", "mrPresi22");
            Company<Person<string>> motorola = new Company<Person<string>>(pres2);
            Console.WriteLine($"pres2 Id: {motorola.President.Id} (string) and his name is: {motorola.President.Name}.");

            Console.WriteLine();
            Console.WriteLine("__ generic in STATIC FIELDS __");
            Console.WriteLine();
            // for static field we can use class name, not instance of class
            Person<int>.field = 777;
            Person<string>.field = "this a string static field";
            Person<char>.field = 'j';

            Console.WriteLine("all static fields in Person<T>:\n" + Person<int>.field + "\n"
                                                                    + Person<string>.field + "\n" 
                                                                        + Person<char>.field);


            Console.WriteLine();
            Console.WriteLine("__ FEW GENERICS in one class (type)__");
            Console.WriteLine();
            Person2<int, string> p2p1 = new Person2<int, string>(33, "jobp2p1");
            Person2<string, string> p2p2 = new Person2<string, string>("forty four", "jobp2p2222");
            Console.WriteLine($"p2p1 Age {p2p1.Age} and Job {p2p1.Job}.");
            Console.WriteLine($"p2p1 Age {p2p2.Age} and Job {p2p2.Job}.");

            Console.WriteLine();
            Console.WriteLine("__ generics in METHODS __");
            Console.WriteLine();

            void Swap<T>(ref T x, ref T y)
            {
                T temp = x;
                x = y;
                y = temp;
            }

            //for ints
            int x = 5; int y = 2;
            Console.WriteLine($"vars before swap, X = {x}, Y = {y}");
            Swap(ref x, ref y);
            Console.WriteLine($"vars  AFTER swap, X = {x}, Y = {y}");

            Console.WriteLine();

            //for chars
            char cx = 'A'; char cy = 'F';
            Console.WriteLine($"vars before swap, X = {cx}, Y = {cy}");
            Swap(ref cx, ref cy);
            Console.WriteLine($"vars  AFTER swap, X = {cx}, Y = {cy}");
        }
    }


    class Person<T> // <T> - means "generic type"
    {
        //generics for static fields
        public static T? field; // <T?> - nullable and any type
        public T Id { get; set; } // for "Id" specify <T> - i.e. ANY of TYPE, like int or string
        public string Name { get; set; }
        public Person(T id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    class Company<T>
    {
        public T President { get; set; }
        public Company(T president)
        {
            President = president;
        }
    }

    class Person2<T, K>
    {
        public T Age { get; set; }
        public K Job { get; set; }

        // constructor with two generics <T> and <K>
        public Person2(T age, K job)
        {
            Age = age;
            Job = job;
        }
    }


    class Arrays<T>
    {
        public T[] objs; // ? - for nullable, for deleting with record "null"

        //add objects
        public void AddObject(int index, T element)
        {
            objs[index] = element;
        }


        //delete objects
        public void DeleteObject(int index)
        {
           // objs[index].Remove(); // for remove element we can use second array newObjs[]
           // and do not record obj[index] in second array
           // then objs[] = newObjs[]
        }


        //get objects
        public T GetObject(int index)
        {
            return objs[index];
        }


        //get length
        public int GetLength(T[] objs)
        {
            return objs.Length;
        }

    }
}


*/