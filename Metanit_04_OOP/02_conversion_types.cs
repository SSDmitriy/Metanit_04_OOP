// type conversion https://metanit.com/sharp/tutorial/3.11.php

//here is types
//
//         OBJECT
//            ↑
//         PERSON
//         ↑    ↑
//   EMPLOYEE  CLIENT


// "Downcasting невозможен без предварительного Upcasting-а"
// т.е.объект родительский не может стать дочерним, если изначально не содержал ссылку на дочерний

internal class Chapter02_conversion_types
{
    /*
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World2!");

        //upcasting conversion from "employee" to "person" type
        Employee employee = new Employee("Tom", "ms");
        Person person = employee;

        person.Print();
        Console.WriteLine(person.Name);


        //downcasting conversion
        Employee employee1 = new Employee("Tom1", "ms1");
        Person person1 = employee1;
        //Employee employee2 = person1; ERROR - implicit cast
        Employee employee2 = (Employee)person1;


        Person person6 = new Person("66");
        //Employee employee6 = (Employee)person6;  //compilation is Ok? but runtime ERROR here. person is not employee (but employee is person)

        Person person7 = new Employee("77", "comp77");
        Employee employee7 = (Employee)person7; //Ok


        //cheking for bad cating with "as"
        //"as" return null if casting impossible
        Person person8 = new Person("Tom");
        Employee? employee8 = person8 as Employee; // "Employee?" pay attention "?"
        if (employee8 == null)
        {
            Console.WriteLine("Преобразование прошло неудачно");
        }
        else
        {
            Console.WriteLine(employee8.Company);
        }


        //chekin with "is"
        Person person9 = new Person("Bob");
        if (person9 is Employee)
        {
            Console.WriteLine("person9 type of Employee");
        }
        else
        {
            Console.WriteLine("person9 is NOT type of Employee");
        }
    }

    */
}


class Person
{
    //property Name
    public string Name { get; set; }

    //constructor
    public Person(string name)
    {
        Name = name;
    }

    //method Print
    public void Print()
    {
        Console.WriteLine("Person name is: " + Name);
    }
}

class Employee : Person
{
    //unique property
    public string Company { get; set; }

    //constructor
    public Employee(string name, string company) : base(name)
    {
        Company = company;
    }
}

class Client : Person
{
    //unique property "Bank"
    public string Bank { get; set; }

    //constructor
    public Client(string name, string bank) : base(name)
    {
        Bank = bank;
    }
}