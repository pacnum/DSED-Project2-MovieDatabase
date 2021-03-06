﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSED_Project2_MovieDatabase
{
    //To Do list for project 
    #region ToDo List / Complete 

    //Insert Update and Delete entires in Database - Complete
    //Show All Videos - Complete
    //Show Moives not returned - Complete
    //Use a Database Class - Complete
    //Issue Movies - Issue Complete 
    //Return Movie - Complete
    //List who are top customers - Complete
    //List what are top movies - Complete
    //todo 2x Unit Tests - Not Complete
    //1 Procedure - ( Check with Gary ) - Not required - Not enough time to learn b4 Project Started ( will be covered at a later date )
    //At least 1 Veiw - Complete
    //Display Database Details on Form - Customer / Movie / Rentals - Complete
    //Host on GitHub - Complete - removed *.mdf and *.ldf lines from gitignore file
    //Comments need to be clear and explainable - Complete
    #endregion


    public partial class Form1 : Form
    {
        //Create values for myDatabase

        Database myDatabase = new Database();

        //Initilizing the application, and getting todays date
        public Form1()
        {
            InitializeComponent();
            this.dateTimePicker1.Value = DateTime.Now;
            LoadDB();
        }

        //Method for Loading the DataBase ( LoadDB )
        public void LoadDB()
        {
            DisplayDataGridViewCustomer();
            DisplayDataGridViewMovies();
            DisplayDataGridViewRentals();
            DisplayDataGridViewTopCustomerView();
            DisplayDataGridViewTopMovieView();
            DisplayDataGridViewMoviesNOtReturned();

        }

        //Method to clear text boxes  
        public void ClearTextBoxes()
        {
            txbTitle.Text = string.Empty;
            txbFirstName.Text = string.Empty;
            txbSurname.Text = string.Empty;
            txbPhoneNumber.Text = string.Empty;
            txbPlot.Text = string.Empty;
            txbGenre.Text = string.Empty;
            txbRating.Text = string.Empty;
            txbReturnMovieID.Text = string.Empty;
            txbMovieID.Text = string.Empty;
            txbCustID.Text = string.Empty;


        }

        //Display Customer details in DataGrid Veiw 
        #region Tab Customer

        private void DisplayDataGridViewCustomer()
        {
            DGVCustomers.DataSource = null;
            try
            {
                DGVCustomers.DataSource = myDatabase.FillDGVCustomerWithCustomer();
                DGVCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         }

        #endregion

        //Display Movies details in DataGrid Veiw 
        #region Tab Movies

        private void DisplayDataGridViewMovies()
        {
            DGVMovies.DataSource = null;
            try
            {
                DGVMovies.DataSource = myDatabase.FillDGVMoviesWithMovies();
                DGVMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        //Display Rentals details in DataGrid Veiw 
        #region Tab Rentals
        private void DisplayDataGridViewRentals()
        {
            DGVRentals.DataSource = null;
            try
            {
                DGVRentals.DataSource = myDatabase.FillDGVRentalsWithCustomerAndMoviesRented();
                DGVRentals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        #endregion

        //Display Movies not Returned details in DataGrid Veiw 
        #region Tab Movies Not Returned
        private void DisplayDataGridViewMoviesNOtReturned()
        {
            DGVNotReturned.DataSource = null;

            try
            {
                DGVNotReturned.DataSource = myDatabase.FillDGVNotReturnedwithMovieReturned();
                DGVNotReturned.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        //Display Top Customer View details in DataGrid Veiw 
        #region Tab TopCustomerView
        private void DisplayDataGridViewTopCustomerView()
        {
            //DGVMoviesNotReturned.DataSource = null;
            try
            {
                DGVTopCustomers.DataSource = myDatabase.FillDGVTopCustomerswithTopCustomerView();
                DGVTopCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        #endregion

        //Display Top Movie View details in DataGrid View
        #region Tab TopMovieView
        private void DisplayDataGridViewTopMovieView()
        {
            DGVTopMovies.DataSource = null;
            try
            {
                DGVTopMovies.DataSource = myDatabase.FillDGVTopMovieswithTopMovieView();
                DGVTopMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }





        #endregion

        //Place customer details from Data Grid into Customer Details section of the Form
        #region Customer Database Details to Form

        private void DGVCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string CustID;
            try
            {
                CustID = DGVCustomers.Rows[e.RowIndex].Cells[0].Value.ToString();
                txbFirstName.Text = DGVCustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
                txbSurname.Text = DGVCustomers.Rows[e.RowIndex].Cells[2].Value.ToString();
                txbAddress.Text = DGVCustomers.Rows[e.RowIndex].Cells[3].Value.ToString();
                txbPhoneNumber.Text = DGVCustomers.Rows[e.RowIndex].Cells[4].Value.ToString();
                txbCustID.Text = CustID;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }


        #endregion

        //Place movie details from Data Grid into the Movie Deatils section of the Form
        #region Movie Database View Details to Form
        private void DGVMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string MovieID; 
            try
            {
                MovieID = DGVMovies.Rows[e.RowIndex].Cells[0].Value.ToString();
                txbTitle.Text = DGVMovies.Rows[e.RowIndex].Cells[3].Value.ToString();
                txbRating.Text = DGVMovies.Rows[e.RowIndex].Cells[1].Value.ToString();
                txbGenre.Text = DGVMovies.Rows[e.RowIndex].Cells[5].Value.ToString();
                txbPlot.Text = DGVMovies.Rows[e.RowIndex].Cells[4].Value.ToString();
                txbMovieID.Text = MovieID;

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

        }
        #endregion

        //Place rental details from Data Grid into both Customer and Movie Deatils section of the Form
        #region Rental Database View Details to Form

        private void DGVRentals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string RMID;
            ClearTextBoxes();

            try
            {
                
                RMID = DGVRentals.Rows[e.RowIndex].Cells[0].Value.ToString();
                txbFirstName.Text = DGVRentals.Rows[e.RowIndex].Cells[1].Value.ToString();
                txbSurname.Text = DGVRentals.Rows[e.RowIndex].Cells[2].Value.ToString();
                txbAddress.Text = DGVRentals.Rows[e.RowIndex].Cells[3].Value.ToString();
                txbTitle.Text = DGVRentals.Rows[e.RowIndex].Cells[4].Value.ToString();
                txbIssuedDate.Text = DGVRentals.Rows[e.RowIndex].Cells[6].Value.ToString();
                txbReturnMovieID.Text = RMID;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

        }


        #endregion

        //Button Click action to Issue a movie to a customer ( Select a Customer, then Select a Movie)
        #region Issue Movie

     

        private void BTNIssueMovie_Click_1(object sender, EventArgs e)
        {
            myDatabase.IssueMovie(txbMovieID.Text, txbCustID.Text);
            MessageBox.Show("Movie Issued Succesfully");
            LoadDB();
        }
        #endregion

        //Button Click action to return a movie from a customer ( Click on Rentals and select a movie that has not been returned - then click on Return Movie)
        #region Return Movie
        private void BTNReturnMovie_Click(object sender, EventArgs e)
        {
            
            myDatabase.ReturnMovie(txbReturnMovieID.Text);
            MessageBox.Show("Movie Returned Successfully");
            LoadDB();

        }

        #endregion

        //Button CLick action when modifying customer details in the Customer Details form
        //(Update Name, Address, Phone Number)
        //Success messages for Add / Update and Delete of customer details
        #region Update Customer Details

        private void BTNAddCustomer_Click(object sender, EventArgs e)
        {
            myDatabase.InsertOrUpdateOwner(txbFirstName.Text, txbSurname.Text, txbAddress.Text, txbPhoneNumber.Text, "","Add");
            MessageBox.Show("Customer Add Successful");
            LoadDB();
        }

        private void BTNUpdateCustomer_Click(object sender, EventArgs e)
        {
            myDatabase.InsertOrUpdateOwner(txbFirstName.Text, txbSurname.Text, txbAddress.Text, txbPhoneNumber.Text, txbCustID.Text, "Update");
            MessageBox.Show("Customer Update Successful");
            LoadDB();
        }

        private void BTNDeleteCustomer_Click(object sender, EventArgs e)
        {
            myDatabase.DeleteCustomer(txbCustID.Text);
            MessageBox.Show("Customer Deleteion Successful");
            LoadDB();
        }
        #endregion


    }



}
