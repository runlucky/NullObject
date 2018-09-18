using System;
namespace NullObject
{
    public class User : IUser
    {
        public int ID { get; private set; } = 0;
        public string Name { get; set; } = "John";
        public void SayName() => Console.WriteLine($"I am {Name}.");
    }
}
