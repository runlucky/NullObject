using System;
namespace NullObject
{
    public class NullUser : IUser, INullObject
    {
        public NullUser()
        {
        }

        public int ID
        {
            get => 0;
            set
            {
                if (value == 0) throw new Exception();
            }
        }

        public string Name => "";

        public bool IsManager() => true;

        public void SayName() { }
    }
}
