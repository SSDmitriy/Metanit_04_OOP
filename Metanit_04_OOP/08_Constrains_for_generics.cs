// Constrains for generic https://metanit.com/sharp/tutorial/3.38.php
/*
namespace Metanit_04_OOP
{
    internal class _08_Constrains_for_generics
    {
        static void Main(string[] args)
        {
            Console.WriteLine("There were CONSTRAINS for generics");
            Console.WriteLine();

            Person p1 = new Person("Tom");

            Console.WriteLine("Constrains for methods");
            SendMessage(new Message("this is just mes1")); //call method without <>
            SendMessage<EmailMessage>(new EmailMessage("this is <EmailMessage> mes2")); //explicit call method WITH <T>

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Constrain for class");
            Console.WriteLine();
            Messenger<Message, Person> telegram = new Messenger<Message, Person>();
            telegram.SendMessage(new Message("mes3 via telegram"));

            Messenger<Message, Person> outlook = new Messenger<Message, Person>();
            outlook.SendMessage(new Message("mes4 via outlook"));


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Few Constrains for class");
            Console.WriteLine();
            Messenger<Message, Person> gmail = new Messenger<Message, Person>();
            Person tom = new Person("Tom-Sender");
            Person bob = new Person("Bob-Receiver");
            Message mes5 = new Message("text for mes5");

            gmail.SendTo(tom, bob, mes5);



            // generic METHOD with constrain
            void SendMessage<T>(T message) where T : Message // "where T : Message" - this a CONSTRAIN
            {
                Console.WriteLine($"This method just send message: {message.Text}");

            }

        }




    }

    class Message //parent
    {
        public string Text { get; }
        public Message(string text)
        {
            Text = text;
        }
    }

    class EmailMessage : Message
    {
        public EmailMessage(string text) : base(text) { }
    }


    class Messenger<T, P>
        where T : Message //constrain for the first type T for whole CLASS
        where P : Person  //constrain for second type
    {
        public void SendMessage(T message)
        {
            Console.WriteLine($"...class Messenger  is working. Your message is: {message.Text}");
        }

        public void SendTo(P sender, P receiver, T message)
        {
            Console.WriteLine($"meth with two constrains (Person and Message). Sender is: {sender.Name}");
            Console.WriteLine($"meth with two constrains. Receiver is: {receiver.Name}");
            Console.WriteLine($"meth with two constrains. Message is: {message.Text}");
        }
    }

    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
    }


    //we can use for constrains
    // classes
    // interfaces
    // single class
    // structure
    // new() - public constructor without any parameters

    class Lim1<T> where T : struct
    { }
    class Lim2<T> where T : class
    { }
    class Lim3<T> where T : new()
    { }


    // we also can use a FEW constrains in SUCH ORDER: [exact] class or "class" or struct
    // then interface
    // then construuctor without parameters new()
    // for example
    class Lim4<T> where T : Message, new()
    { }


}


*/