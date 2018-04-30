using System;
namespace NullObject
{
    public class User : IUser
    {
        public User()
        {

        }

        public int ID { get; set; }
        public string Name { get; set; }

        public bool IsManager()
        {
            return true;
        }

        public void SayName() => Console.WriteLine($"I am {Name}.");

    }
}
