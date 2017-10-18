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
            myCommand = new SqlCommand("Update RentedMovies SET dateReturned=@today WHERE RMID = @ID");

            myCommand.Connection = Connection;

            var par = myCommand.Parameters;
            par.AddWithValue("today", today);
            par.AddWithValue("ID", ID);
            Connection.Open();
            myCommand.ExecuteNonQuery();
            Connection.Close();
        }
    }
}







    
    
     
    


