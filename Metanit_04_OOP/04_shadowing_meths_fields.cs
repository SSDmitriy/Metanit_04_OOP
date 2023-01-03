// shadowing/hiding methods, fields, consts with "new"
//https://metanit.com/sharp/tutorial/3.41.php

namespace Metanit_04_OOP
{
    class _04_shadowing_meths_fields
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello 04 shadowing");
            Console.WriteLine();

            Person p1 = new Person("Per1");
            p1.Print();// Print from parent

            Person p2e = new Employee("Per2e", "p2Company");
            p2e.Print();// Print from parent

            Employee p3e = new Employee("Per3e", "p3Company");
            p3e.Print();// Print from CHILD

            Console.WriteLine();
            Console.WriteLine("____shadowing properties____");
            Console.WriteLine("p1 Name: " + p1.Name);
            Console.WriteLine("p2e Name: " + p2e.Name);
            Console.WriteLine("p3e Name: " + p3e.Name);

            Console.WriteLine();
            Console.WriteLine("____shadowing VAR_____");
            Console.WriteLine("person static var: " + Person.varP);
            Console.WriteLine("employee static var: " + Employee.varP);

            Console.WriteLine();
            Console.WriteLine("____shadowing CONST_____");
            Console.WriteLine("person CONST: " + Person.typeName);
            Console.WriteLine("employee CONST: " + Employee.typeName);


        }

    }


    class Person
    {

        public static int varP = 1; //var in parent
        public const string typeName = "type-PERSON"; //const in parent

        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }

        //meth in parent class
        public void Print()
        {
            Console.WriteLine($"Print in Parent PERSON : {Name}");
        }
    }

    class  Employee : Person
    {
        public new static int varP = 22; //hiding with "new"
        public new const string typeName = "type-EMPLOYEE"; //hiding with "new"
        public new string Name { //here NEW for hiding property from parent
            get
            {
                return $"hidding property {base.Name} from CHILD employee";
            }
            set
            {
                base.Name = value;
            }
        }
        public string Company { get; set; }

        public Employee(string name, string company) : base(name)
        {
            Company = company;
        }

        public new void Print() //here NEW for hiding orginal method
        {
            Console.WriteLine($"Print in CHILD EMPLOYEE : {Name} and {Company}");
            Console.WriteLine("Also with BASE we can call meth from parent");
            base.Print();
        }
        

    }

}
