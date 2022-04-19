using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Testing
{
    [TestClass()]
    public class AccountTests
    {
        private static AccountManagement management = new AccountManagement(new MockDBConnection());

        [TestMethod()]
        public void LoginTest()
        {
            AccountManagement managementNew = new AccountManagement(new DBConnection());
            string role = "";
            string id = "";
            bool sussecfull = managementNew.Login("arenco@mail.nl", "1234567890",out role,out id);
            Assert.IsTrue(sussecfull);
        }

        [TestMethod()]
        public void AddAccountTest()
        {
            Assert.IsTrue(management.AddAccount("Freddy", "Kruger", "random@mail.com", "12345678902", "RandomStreet", "9c", "7890SD", "City", "Rand0mPassw0rd"));
        }

        [TestMethod()]
        public void UpdateAccountTest()
        {
            Assert.IsTrue(management.UpdateAccount(1, "Michelle", "Kryger", "Random@mail.com", "12345687901", "RandomBigStreet", "16d", "3345WQ", "AnyCity", "NewPassw0rd"));
        }
    }
}