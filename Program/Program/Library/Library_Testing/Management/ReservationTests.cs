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
    public class ReservationTests
    {
        private static ReservationManagement management = new ReservationManagement(new MockDBConnection());

        [TestMethod()]
        public void MakeReservationTest()
        {
            Assert.IsTrue(management.MakeReservation(1, 1, DateTime.UtcNow));
        }

        [TestMethod()]
        public void IsItemAvailbleTest()
        {
            Assert.AreEqual(1,management.IsItemAvailble(2,DateTime.UtcNow));
        }
    }
}