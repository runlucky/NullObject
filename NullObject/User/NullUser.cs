using System;
namespace NullObject
{
    public class NullUser : IUser, INullObject
    {
        public static NullUser Instance = new NullUser();

        public int ID => default(int);
        public string Name
        {
            get => string.Empty;
            set { }
        }

        public void SayName() { }
    }
}
