using System;

namespace NullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello(new User());
            Hello(new NullUser());
            Hello(null);
        }

        static void Hello(IUser user)
        {
            if (user.IsNull()) Console.WriteLine("I am null or null object.");
            user?.SayName();
        }


    }
}
