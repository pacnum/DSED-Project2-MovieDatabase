using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSED_Project2_MovieDatabase
{
    class Database
    {
        private SqlConnection Connection = new SqlConnection();
        private SqlCommand Command = new SqlCommand();
        private SqlDataAdapter DataAdaptor = new SqlDataAdapter();


        public Database()
        {
            string connectionString =
            @"Data Source=LAPTOP\SQLEXPRESS;Initial Catalog=VBMoviesFullData;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            Connection.ConnectionString = connectionString;
            Command.Connection = Connection;
        }

        public DataTable FillDGVCustomerWithCustomer()
        {
            DataTable dt = new DataTable();
            using (DataAdaptor = new SqlDataAdapter("select * from Customer ", Connection))
            {
                Connection.Open();
                DataAdaptor.Fill(dt);
                Connection.Close();
            }
            return dt;
        }

        public DataTable FillDGVMoviesWithMovies()
        {
            DataTable dt = new DataTable();
            using (DataAdaptor = new SqlDataAdapter("select * from AllMoviesLessCosts ", Connection))
            {
                Connection.Open();
                DataAdaptor.Fill(dt);
                Connection.Close();
            }
            return dt;
        }

        public DataTable FillDGVRentalsWithCustomerAndMoviesRented()
        {
            DataTable dt = new DataTable();
            using (DataAdaptor = new SqlDataAdapter("select * from CustomerAndMoviesRented ", Connection))
            {
                Connection.Open();
                DataAdaptor.Fill(dt);
                Connection.Close();
            }
            return dt;
        }

        public DataTable FillDGVNotReturnedwithMovieReturned()
        {
            DataTable dt = new DataTable();
            using (DataAdaptor = new SqlDataAdapter("select * from MovieReturned ", Connection))
            {
                Connection.Open();
                DataAdaptor.Fill(dt);
                Connection.Close();
            }
            return dt;
        }

        public DataTable FillDGVTopCustomerswithTopCustomerView()
        {
            DataTable dt = new DataTable();
            using (DataAdaptor = new SqlDataAdapter("select * from TopCustomerView ", Connection))
            {
                Connection.Open();
                DataAdaptor.Fill(dt);
                Connection.Close();
            }
            return dt;
        }

        public DataTable FillDGVTopMovieswithTopMovieView()
        {
            DataTable dt = new DataTable();
            using (DataAdaptor = new SqlDataAdapter("select * from TopMovieView ", Connection))
            {
                Connection.Open();
                DataAdaptor.Fill(dt);
                Connection.Close();
            }
            return dt;
        }

        public object IssueMovie(string MovieID, string CustID)
        {
            System.DateTime today = System.DateTime.Now;
            var MyCommand = new SqlCommand("INSERT INTO RentedMovies ( MovieIDFK, CustIDFK, DateRented) " + "VALUES( @movieid, @custID, @daterented)")
            {
                Connection = Connection
            };

            var par = MyCommand.Parameters;
            par.AddWithValue("movieid", MovieID);
            par.AddWithValue("custid", CustID);
            par.AddWithValue("daterented", today);

            Connection.Open();
            MyCommand.ExecuteNonQuery();
            Connection.Close();

            return null;

        }

        public void ReturnMovie(string ID)
        {
            System.DateTime today = System.DateTime.Now;
            var myCommand = new SqlCommand();
            myCommand = new SqlCommand("UPDATE RentedMovies SET DateReturned=@today WHERE RMID = @ID");
            myCommand.Connection = Connection;

            var par = myCommand.Parameters;
            par.AddWithValue("today", today);
            par.AddWithValue("ID", ID);
            //par.AddWithValue("DateReturned", today);
            Connection.Open();
            myCommand.ExecuteNonQuery();
            Connection.Close();
        }


        public string InsertOrUpdateOwner(string FirstName, String LastName, string Address, string Phone, string ID, string AddorUpdate)
        {
            try
            {
                if (AddorUpdate == "Add")
                {
                    string query = "INSERT INTO customer (FirstName, LastName, Address, Phone) " + "Values(@FirstName, @LastName, @Address, @Phone)";
                    var myCommand = new SqlCommand(query, Connection);

                    myCommand.Parameters.AddWithValue("FirstName", FirstName);
                    myCommand.Parameters.AddWithValue("LastName", LastName);
                    myCommand.Parameters.AddWithValue("Address", Address);
                    myCommand.Parameters.AddWithValue("Phone", Phone);
                    Connection.Open();
                    myCommand.ExecuteNonQuery();
                    Connection.Close();

                }
                else if (AddorUpdate == "Update")
                {

                    var myCommand = new SqlCommand("UPDATE Customer set FirstName = @FirstName, LastName=@LastName, Address=@Address, Phone=@Phone where CustID = @ID ", Connection);

                    myCommand.Parameters.AddWithValue("FirstName", FirstName);
                    myCommand.Parameters.AddWithValue("LastName", LastName);
                    myCommand.Parameters.AddWithValue("Address", Address);
                    myCommand.Parameters.AddWithValue("Phone", Phone);
                    myCommand.Parameters.AddWithValue("ID", ID);
                    Connection.Open();
                    myCommand.ExecuteNonQuery();
                    Connection.Close();
                }
                return " is Successful";
            }
            catch (Exception e)

            {
                Connection.Close();
                return " has failed with " + e;
            }
        }

        public string DeleteCustomer(string ID)
        {
            var myCommand = new SqlCommand("DELETE FROM Customer WHERE CustID =@ID", Connection);

            myCommand.Parameters.AddWithValue("ID", ID);
            Connection.Open();
            myCommand.ExecuteNonQuery();
            Connection.Close();
            return "Success";

        }
    }



}








    
    
     
    


