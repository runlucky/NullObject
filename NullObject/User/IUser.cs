using System;
namespace NullObject
{
    public interface IUser
    {
        int ID { get; }
        string Name { get; set; }
        void SayName();
    }
}
