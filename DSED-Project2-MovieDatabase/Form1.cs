using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSED_Project2_MovieDatabase
{
    #region ToDo List / Complete 

    //todo Insert Update and Delete entires in Database
    //Show All Videos - Complete
    //Show Moives not returned - Complete
    //Use a Database Class - Complete
    //todo Issue Movies - Issue Complete 
    //todo Return Movie - 
    //List who are top customers - Complete
    //List what are top movies - Complete
    //todo 2x Unit Tests
    //1 Procedure - ( Check with Gary ) - Not required - Not enough time to learn b4 Project Started ( will be covered at a later date )
    //At least 1 Veiw - Complete
    //Display Database Details on Form - Customer / Movie / Rentals - Complete
    //Host on GitHub

    #endregion


    public partial class Form1 : Form
    {
        Database myDatabase = new Database();
        public Form1()
        {
            InitializeComponent();
            this.dateTimePicker1.Value = DateTime.Now;
            LoadDB();
        }

        public void LoadDB()
        {
            DisplayDataGridViewCustomer();
            DisplayDataGridViewMovies();
            DisplayDataGridViewRentals();
            DisplayDataGridViewTopCustomerView();
            DisplayDataGridViewTopMovieView();
            DisplayDataGridViewMoviesNOtReturned();

        }

        public void ClearTextBoxes()
        {
            txbTitle.Text = string.Empty;
            txbFirstName.Text = string.Empty;
            txbSurname.Text = string.Empty;
            txbPhoneNumber.Text = string.Empty;
            txbPlot.Text = string.Empty;
            txbGenre.Text = string.Empty;
            txbRating.Text = string.Empty;


        }


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

        #region Rental Database View Details to Form

        private void DGVRentals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int RMID = 0;
            ClearTextBoxes();

            try
            {
                RMID = (int)DGVRentals.Rows[e.RowIndex].Cells[0].Value;
                txbFirstName.Text = DGVRentals.Rows[e.RowIndex].Cells[1].Value.ToString();
                txbSurname.Text = DGVRentals.Rows[e.RowIndex].Cells[2].Value.ToString();
                txbAddress.Text = DGVRentals.Rows[e.RowIndex].Cells[3].Value.ToString();
                txbTitle.Text = DGVRentals.Rows[e.RowIndex].Cells[4].Value.ToString();
                txbIssuedDate.Text = DGVRentals.Rows[e.RowIndex].Cells[6].Value.ToString();

            }
            catch (Exception)
            {
                throw;
            }

        }


        #endregion

        #region Issue Movie

     

        private void BTNIssueMovie_Click_1(object sender, EventArgs e)
        {
            myDatabase.IssueMovie(txbMovieID.Text, txbCustID.Text);
            MessageBox.Show("Movie Issued Succesfully");
        }
        #endregion

        private void BTNReturnMovie_Click(object sender, EventArgs e)
        {
            myDatabase.ReturnMovie(txbMovieID.Text);
            MessageBox.Show("Movie Returned Successfully");
            LoadDB();

        }
    }



}
