using System;
namespace NullObject
{
    public interface IUser
    {
        int ID { get; set; }
        string Name { get; }
        bool IsManager();
        void SayName();
    }
}
