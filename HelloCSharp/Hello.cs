using System;
namespace HelloCSharp
{
    class Hello
    {
        string name;
        public Hello(){
            Console.WriteLine("please enter your name");
            name = Console.ReadLine();
            Console.WriteLine(name);
        }
    }
}