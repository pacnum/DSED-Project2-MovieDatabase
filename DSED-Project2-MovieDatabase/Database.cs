using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DSED_Project2_MovieDatabase
{
    //Connection to the MOVIE  database – Setup SQL Connections, Command and DataAdaptor
    public class Database
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


        //Connect to the Customer table in the database, and then fill the DataGridView table – Customer with these details
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

        //Connect to the Movies table in the database, and then fill the DataGridView table – Movie with these details
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

        //Connect to the CustomerandMoviesRented view in the database, and then fill the DataGridView table – Rentals with these details

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

        //Connect to the MoviesReturned view in the database, and then fill the DataGridView table – Movies Not Returned with these details
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

        //Connect to the TopCustomerView view in the database, and then fill the DataGridView table – Top Customers with these details

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

        //Connect to the TopMovieView view in the database, and then fill the DataGridView table – Top Movies with these details

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


        //Connect to the Movies database and INSERT INTO the RentedMovies table values for issuing a movie to a customer

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

        //Connect to the Movies database and UPDATE the RentedMovies table values for returning  a movie from a customer

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


        //Connect to the Movies database and INSERT INTO ( modify ) the table values for customers in order to change their details, such as phone number, address, or name. 

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

        //Connect to the Movies database and DELETE FROM the table values for the customer – to remove/delete them from the database

        public string DeleteCustomer(string ID)
        {
            var myCommand = new SqlCommand("DELETE FROM Customer WHERE CustID =@ID", Connection);

            myCommand.Parameters.AddWithValue("ID", ID);
            Connection.Open();
            myCommand.ExecuteNonQuery();
            Connection.Close();
            return "Success";

        }

        //For Unit testing

        public int SelectAllCustomers()
        {
            var myCommand = new SqlCommand("SELECT * FROM Customer");
            myCommand.Connection = Connection;
            Connection.Open();
            int row = myCommand.ExecuteNonQuery();
            Connection.Close();
            return row;
        }

        public int SelectAllMovies()
        {
            var myCommand = new SqlCommand("SELECT * FROM MOVIES");
            myCommand.Connection = Connection;
            Connection.Open();
            int row = myCommand.ExecuteNonQuery();
            Connection.Close();
            return row;
        }
    }



}








    
    
     
    


