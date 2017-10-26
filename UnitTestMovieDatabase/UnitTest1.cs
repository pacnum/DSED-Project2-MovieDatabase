using System;
using DSED_Project2_MovieDatabase;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace UnitTestMovieDatabase
{
    [TestClass]
    public class UnitTest1
    {
        Form1 myForm = new Form1();
        private Database myDB = new Database();
        //Unit Test 1 - Connecting to DATABASE and asserting a value for Customers
        [TestMethod]
        public void SelectAllCustomers()
        {
            Database myDB = new Database();
            int Actual = myDB.SelectAllCustomers();
            Assert.IsFalse(Actual > 1);

        }
        //Unit Test 2 - Connecting to DATABASE and asserting a value for Movies
        [TestMethod]
        public void SelectAllMovies()
        {
            Database myDB = new Database();
            int Actual = myDB.SelectAllMovies();
            Assert.IsFalse(Actual > 1);
        }




    }
}
