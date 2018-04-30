using System;
namespace NullObject
{
    public class User : IUser
    {
        public int ID { get; set; } = 0;
        public string Name { get; set; } = "default";

        public bool IsManager() => ID < 10;
        public void SayName() => Console.WriteLine($"I am ID:{ID}, {Name}.");
    }
}
