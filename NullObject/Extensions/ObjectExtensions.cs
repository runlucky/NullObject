using System;
namespace NullObject
{
    public static class ObjectExtensions
    {
        public static bool IsNull(this object source) => source == null || source is INullObject;
    }
}
