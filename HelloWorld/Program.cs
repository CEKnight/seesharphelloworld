using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string foo = "bar";
            var greeter = new Greeter("Chris");
            Console.WriteLine($"{greeter.SayHello()}");
        }
    }
    public class Greeter
    {
        public string Name { get; }
        public Greeter(string inputName)
        {
            Name = inputName;
        }

        public string SayHello()
        {

            return $"What's up {Name}";
        }
    }
}