using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullObject.Tests
{
    [TestClass]
    public class UserTests : TestBase
    {
        [TestMethod]
        public void testUser()
        {
            var user = new User();
            SayName(user, "TestName").IsFalse();
        }

        [TestMethod]
        public void testNullUser()
        {
            var user = NullUser.Instance;
            SayName(user, string.Empty).IsTrue();
        }

        private bool SayName(IUser user, string name)
        {
            user.Name = name;
            user.SayName();
            user.Name.Is(name);
            return user.IsNull();
        }

        [TestMethod]
        public void testNull()
        {
            IUser user = null;
            user.IsNull().IsTrue();
        }
    }
}
