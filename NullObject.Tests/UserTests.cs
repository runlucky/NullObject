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
            IUser user = new User
            {
                Name = "TestName"
            };

            user.SayName();
            user.Name.Is("TestName");
            user.IsNull().IsFalse();
        }

        [TestMethod]
        public void testNullUser()
        {
            var user = NullUser.Instance;

            user.SayName();
            user.Name.Is(string.Empty);
            user.IsNull().IsTrue();
        }

        [TestMethod]
        public void testNull()
        {
            IUser user = null;
            user.IsNull().IsTrue();
        }
    }
}
