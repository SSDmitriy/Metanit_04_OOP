//inheritance for generics https://metanit.com/sharp/tutorial/3.39.php

namespace Metanit_04_OOP
{
    internal class _09_Inheritance_generics
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi Inheritance for generics!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1) inheritance generic with SAME TYPE of parent class");
            Console.WriteLine();
            Person<string> p1 = new Person<string>("r123");
            Person<int> p2 = new UniversalPerson<int>(345);
            UniversalPerson<int> p3 = new UniversalPerson<int>(678);
            Console.WriteLine("p1 Id is: " + p1.Id);
            Console.WriteLine("p2 Id is: " + p2.Id);
            Console.WriteLine("p3 Id is: " + p3.Id);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("2) inheritance NONgeneric from generic");
            Console.WriteLine();
            StringPerson p4 = new StringPerson("rr234");
            Console.WriteLine("p4 Id is: " + p4.Id);

            //or variable of parent class but type child
            Person<string> p5 = new StringPerson("pp456");
            Console.WriteLine("p5 Id is: " + p4.Id);


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("3) inheritance ANOTHER TYPE and GENERIC than parent");
            Console.WriteLine();

            IntPerson<string> p7 = new IntPerson<string>(7, "code77");
            Console.WriteLine("p7 Id is: " + p7.Id);

            //or variable of parent class but type child
            Person<int> p8 = new IntPerson<char>(8, 'h');
            Console.WriteLine("p8 Id is: " + p8.Id);


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("4) few parameters for child AND another parameter for parent");
            Console.WriteLine();

            MixedPerson<string, int> p9 = new MixedPerson<string, int>("strId99", 99);
            Console.WriteLine(p9.Id);
            Person<string> p10 = new MixedPerson<string, int>("strId10", 10);
            Console.WriteLine(p10.Id);

        }
    }


    //some base class (parent)
    class Person<T>
    {
        public T Id { get; set; }
        public Person(T id)
        {
            Id = id;
        }
    }

    //1) child with SAME TYPE
    class UniversalPerson<T> : Person<T>
    {
        public UniversalPerson(T id) : base(id)
        { }

    }


    //2) child is NONgenegic
    class StringPerson : Person<string>  // necessary specify <type> of parent
    {
        public StringPerson(string id) : base(id)
        { }
    }

    //3) child is ANOTHER and GENERIC than parent
    class IntPerson<T> : Person<int> //also necessary specify <type> of parent
    {
        public T Code { get; set; }
        public IntPerson(int id, T code) : base(id)
        {
            Code = code;
        }
    }


    //4) few parameters for child AND one pararmeter from parent
    class MixedPerson<T, K> : Person<T>
        where K : struct //this is a constraint for K
    {
        public K Code { get; set; }
        public MixedPerson(T id, K code) : base(id)
        {
            Code = code;
        }
    }



    //5) if constraint was apply for base (parent) then for child will be apply same onstraint
    class A<T> where T : struct // "struct" here - is a constraint for type T
    {
        public T Field { get; set; }
        public A(T field)
        {
            Field = field;
        }
    }

    class B<T> : A<T> where T : struct // here in child we must use SAME CONSTRAINT for type <T> like in parent
    {
        public B(T id) : base(id)
        { }

    }

}
