using System;
namespace NullObject
{
    public static class ObjectExtension
    {
        public static bool IsNull(this object source) => source == null || source is INullObject;
    }
}
