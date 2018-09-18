using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullObject.Tests
{
    [TestClass]
    public class DeckTests : TestBase
    {
        [TestMethod]
        public void 全カード取得してみた()
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
