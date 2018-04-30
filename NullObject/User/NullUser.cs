using System;
namespace NullObject
{
    public class NullUser : IUser, INullObject
    {
        public int ID
        {
            get => default(int);
            set { }
        }
        public string Name => string.Empty;
        public bool IsManager() => default(bool);
        public void SayName() { }
    }
}
