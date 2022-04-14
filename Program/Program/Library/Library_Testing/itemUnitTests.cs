using Library_Class;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Library_Testing
{
    [TestClass]
    public class itemUnitTests
    {
        private static ItemManagement management = new ItemManagement(new MockDBConnection());

        [TestMethod]
        public void TestAddBookValid()
        {
            Assert.IsTrue(
                management.AddItem("ValidName", "1234567809", 0,
                "Dutch", "A Description", 10, "Famous Author",
                "Famous Publisher"));            
        }

        [TestMethod]
        public void TestAddMovieValid()
        {
            Assert.IsTrue(
                management.AddItem("ValidName", "12345654321", 0,
                "Dutch", "A Description","None", "Famous Producer",60,
                "16"));
        }


        [TestMethod]
        public void TestUpdateBookValid()
        {
            Assert.IsTrue(
                management.UpdateItem(1,"ValidName", "1234567809", 0,
                "Dutch", "A Description", 10, "Famous Author",
                "Famous Publisher"));
        }

        [TestMethod]
        public void TestUpdateMovieValid()
        {
            Assert.IsTrue(
                management.UpdateItem(1,"ValidName", "12345654321", 0,
                "Dutch", "A Description", "None", "Famous Producer", 60,
                "16"));
        }


        [TestMethod]
        public void TestDeleteValid()
        {
            int result = management.DeleteItem(1);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestDeleteInvalid()
        {
            int result = management.DeleteItem(0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestSearchItem()
        {
            object a = management.SearchItem(1, 'B');
            Assert.IsNull(a);
        }

        [TestMethod]
        public void TestGetAllItems()
        {
            List<Book> books = management.GetAllItems();
            Assert.AreNotEqual(1,books);
        }

        [TestMethod]
        public void TestGetAllItem()
        {
            List<Movie> movies = management.GetAllItem();
            Assert.AreNotEqual(1,movies);
        }

    }
}