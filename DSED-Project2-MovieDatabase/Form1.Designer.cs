namespace DSED_Project2_MovieDatabase
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DGVCustomers = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGVMovies = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DGVRentals = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVTopMovies = new System.Windows.Forms.DataGridView();
            this.DGVTopCustomers = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.DGVNotReturned = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTNAddCustomer = new System.Windows.Forms.Button();
            this.BTNDeleteCustomer = new System.Windows.Forms.Button();
            this.BTNUpdateCustomer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BTNReturnMovie = new System.Windows.Forms.Button();
            this.BTNIssueMovie = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.txbPlot = new System.Windows.Forms.TextBox();
            this.txbRating = new System.Windows.Forms.TextBox();
            this.txbGenre = new System.Windows.Forms.TextBox();
            this.txbPhoneNumber = new System.Windows.Forms.TextBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.txbTitle = new System.Windows.Forms.TextBox();
            this.txbSurname = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbIssuedDate = new System.Windows.Forms.TextBox();
            this.LBLMovieDetails = new System.Windows.Forms.Label();
            this.LBLCustomerDetails = new System.Windows.Forms.Label();
            this.txbCustID = new System.Windows.Forms.TextBox();
            this.txbMovieID = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomers)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMovies)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRentals)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTopMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTopCustomers)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNotReturned)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(70, 93);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(870, 407);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGVCustomers);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(862, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DGVCustomers
            // 
            this.DGVCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCustomers.Location = new System.Drawing.Point(3, 3);
            this.DGVCustomers.Name = "DGVCustomers";
            this.DGVCustomers.RowTemplate.Height = 24;
            this.DGVCustomers.Size = new System.Drawing.Size(856, 372);
            this.DGVCustomers.TabIndex = 1;
            this.DGVCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCustomers_CellContentClick);
            this.DGVCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCustomers_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGVMovies);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(862, 378);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movies";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DGVMovies
            // 
            this.DGVMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVMovies.Location = new System.Drawing.Point(3, 3);
            this.DGVMovies.Name = "DGVMovies";
            this.DGVMovies.RowTemplate.Height = 24;
            this.DGVMovies.Size = new System.Drawing.Size(856, 372);
            this.DGVMovies.TabIndex = 2;
            this.DGVMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMovies_CellContentClick);
            this.DGVMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMovies_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DGVRentals);
            this.tabPage3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(862, 378);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rentals";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DGVRentals
            // 
            this.DGVRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRentals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVRentals.Location = new System.Drawing.Point(3, 3);
            this.DGVRentals.Name = "DGVRentals";
            this.DGVRentals.RowTemplate.Height = 24;
            this.DGVRentals.Size = new System.Drawing.Size(856, 372);
            this.DGVRentals.TabIndex = 2;
            this.DGVRentals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRentals_CellContentClick);
            this.DGVRentals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRentals_CellContentClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.DGVTopMovies);
            this.tabPage4.Controls.Add(this.DGVTopCustomers);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(862, 378);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Top 10 Movies and Customers";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(601, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Top Movies";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Top Customers";
            // 
            // DGVTopMovies
            // 
            this.DGVTopMovies.Location = new System.Drawing.Point(466, 41);
            this.DGVTopMovies.Name = "DGVTopMovies";
            this.DGVTopMovies.RowTemplate.Height = 24;
            this.DGVTopMovies.Size = new System.Drawing.Size(375, 319);
            this.DGVTopMovies.TabIndex = 3;
            // 
            // DGVTopCustomers
            // 
            this.DGVTopCustomers.Location = new System.Drawing.Point(40, 41);
            this.DGVTopCustomers.Name = "DGVTopCustomers";
            this.DGVTopCustomers.RowTemplate.Height = 24;
            this.DGVTopCustomers.Size = new System.Drawing.Size(375, 319);
            this.DGVTopCustomers.TabIndex = 2;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.DGVNotReturned);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(862, 378);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Movies Not Returned";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // DGVNotReturned
            // 
            this.DGVNotReturned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVNotReturned.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVNotReturned.Location = new System.Drawing.Point(3, 3);
            this.DGVNotReturned.Name = "DGVNotReturned";
            this.DGVNotReturned.RowTemplate.Height = 24;
            this.DGVNotReturned.Size = new System.Drawing.Size(856, 372);
            this.DGVNotReturned.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DSED_Project2_MovieDatabase.Properties.Resources.computer_screen;
            this.pictureBox1.Location = new System.Drawing.Point(30, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(960, 676);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // BTNAddCustomer
            // 
            this.BTNAddCustomer.Location = new System.Drawing.Point(1437, 75);
            this.BTNAddCustomer.Name = "BTNAddCustomer";
            this.BTNAddCustomer.Size = new System.Drawing.Size(111, 42);
            this.BTNAddCustomer.TabIndex = 3;
            this.BTNAddCustomer.Text = "Add Customer";
            this.BTNAddCustomer.UseVisualStyleBackColor = true;
            // 
            // BTNDeleteCustomer
            // 
            this.BTNDeleteCustomer.Location = new System.Drawing.Point(1437, 171);
            this.BTNDeleteCustomer.Name = "BTNDeleteCustomer";
            this.BTNDeleteCustomer.Size = new System.Drawing.Size(111, 49);
            this.BTNDeleteCustomer.TabIndex = 4;
            this.BTNDeleteCustomer.Text = "Delete Customer";
            this.BTNDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // BTNUpdateCustomer
            // 
            this.BTNUpdateCustomer.Location = new System.Drawing.Point(1437, 123);
            this.BTNUpdateCustomer.Name = "BTNUpdateCustomer";
            this.BTNUpdateCustomer.Size = new System.Drawing.Size(111, 42);
            this.BTNUpdateCustomer.TabIndex = 5;
            this.BTNUpdateCustomer.Text = "Update Customer";
            this.BTNUpdateCustomer.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(34, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 682);
            this.panel2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(330, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(348, 34);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // BTNReturnMovie
            // 
            this.BTNReturnMovie.Location = new System.Drawing.Point(1126, 146);
            this.BTNReturnMovie.Name = "BTNReturnMovie";
            this.BTNReturnMovie.Size = new System.Drawing.Size(216, 78);
            this.BTNReturnMovie.TabIndex = 8;
            this.BTNReturnMovie.Text = "Return Movie";
            this.BTNReturnMovie.UseVisualStyleBackColor = true;
            this.BTNReturnMovie.Click += new System.EventHandler(this.BTNReturnMovie_Click);
            // 
            // BTNIssueMovie
            // 
            this.BTNIssueMovie.Location = new System.Drawing.Point(1123, 62);
            this.BTNIssueMovie.Name = "BTNIssueMovie";
            this.BTNIssueMovie.Size = new System.Drawing.Size(216, 78);
            this.BTNIssueMovie.TabIndex = 10;
            this.BTNIssueMovie.Text = "Issue Movie";
            this.BTNIssueMovie.UseVisualStyleBackColor = true;
            this.BTNIssueMovie.Click += new System.EventHandler(this.BTNIssueMovie_Click_1);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1308, 62);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(0, 55);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // txbFirstName
            // 
            this.txbFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFirstName.Location = new System.Drawing.Point(44, 82);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(239, 30);
            this.txbFirstName.TabIndex = 14;
            this.txbFirstName.Text = "First Name";
            // 
            // txbPlot
            // 
            this.txbPlot.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPlot.Location = new System.Drawing.Point(289, 283);
            this.txbPlot.Multiline = true;
            this.txbPlot.Name = "txbPlot";
            this.txbPlot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbPlot.Size = new System.Drawing.Size(239, 121);
            this.txbPlot.TabIndex = 15;
            this.txbPlot.Text = "Plot";
            // 
            // txbRating
            // 
            this.txbRating.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRating.Location = new System.Drawing.Point(42, 319);
            this.txbRating.Name = "txbRating";
            this.txbRating.Size = new System.Drawing.Size(239, 30);
            this.txbRating.TabIndex = 16;
            this.txbRating.Text = "Rating";
            // 
            // txbGenre
            // 
            this.txbGenre.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGenre.Location = new System.Drawing.Point(42, 283);
            this.txbGenre.Name = "txbGenre";
            this.txbGenre.Size = new System.Drawing.Size(239, 30);
            this.txbGenre.TabIndex = 17;
            this.txbGenre.Text = "Genre";
            // 
            // txbPhoneNumber
            // 
            this.txbPhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPhoneNumber.Location = new System.Drawing.Point(287, 136);
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.Size = new System.Drawing.Size(239, 30);
            this.txbPhoneNumber.TabIndex = 19;
            this.txbPhoneNumber.Text = "Phone Number";
            // 
            // txbAddress
            // 
            this.txbAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAddress.Location = new System.Drawing.Point(289, 82);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(239, 30);
            this.txbAddress.TabIndex = 20;
            this.txbAddress.Text = "Address";
            // 
            // txbTitle
            // 
            this.txbTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTitle.Location = new System.Drawing.Point(42, 247);
            this.txbTitle.Name = "txbTitle";
            this.txbTitle.Size = new System.Drawing.Size(486, 30);
            this.txbTitle.TabIndex = 22;
            this.txbTitle.Text = "Title";
            // 
            // txbSurname
            // 
            this.txbSurname.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSurname.Location = new System.Drawing.Point(42, 136);
            this.txbSurname.Name = "txbSurname";
            this.txbSurname.Size = new System.Drawing.Size(239, 30);
            this.txbSurname.TabIndex = 23;
            this.txbSurname.Text = "Surname";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbIssuedDate);
            this.panel1.Controls.Add(this.LBLMovieDetails);
            this.panel1.Controls.Add(this.LBLCustomerDetails);
            this.panel1.Controls.Add(this.txbAddress);
            this.panel1.Controls.Add(this.txbSurname);
            this.panel1.Controls.Add(this.txbFirstName);
            this.panel1.Controls.Add(this.txbTitle);
            this.panel1.Controls.Add(this.txbPlot);
            this.panel1.Controls.Add(this.txbRating);
            this.panel1.Controls.Add(this.txbGenre);
            this.panel1.Controls.Add(this.txbPhoneNumber);
            this.panel1.Location = new System.Drawing.Point(1081, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 472);
            this.panel1.TabIndex = 24;
            // 
            // txbIssuedDate
            // 
            this.txbIssuedDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIssuedDate.Location = new System.Drawing.Point(44, 374);
            this.txbIssuedDate.Name = "txbIssuedDate";
            this.txbIssuedDate.Size = new System.Drawing.Size(239, 30);
            this.txbIssuedDate.TabIndex = 26;
            this.txbIssuedDate.Text = "Issued Date";
            // 
            // LBLMovieDetails
            // 
            this.LBLMovieDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LBLMovieDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLMovieDetails.Location = new System.Drawing.Point(187, 191);
            this.LBLMovieDetails.Name = "LBLMovieDetails";
            this.LBLMovieDetails.Size = new System.Drawing.Size(206, 33);
            this.LBLMovieDetails.TabIndex = 25;
            this.LBLMovieDetails.Text = "Movie Details";
            this.LBLMovieDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBLCustomerDetails
            // 
            this.LBLCustomerDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LBLCustomerDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLCustomerDetails.Location = new System.Drawing.Point(187, 22);
            this.LBLCustomerDetails.Name = "LBLCustomerDetails";
            this.LBLCustomerDetails.Size = new System.Drawing.Size(206, 33);
            this.LBLCustomerDetails.TabIndex = 24;
            this.LBLCustomerDetails.Text = "Customer Details";
            this.LBLCustomerDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbCustID
            // 
            this.txbCustID.Location = new System.Drawing.Point(1126, 811);
            this.txbCustID.Name = "txbCustID";
            this.txbCustID.Size = new System.Drawing.Size(134, 22);
            this.txbCustID.TabIndex = 25;
            // 
            // txbMovieID
            // 
            this.txbMovieID.Location = new System.Drawing.Point(1390, 811);
            this.txbMovieID.Name = "txbMovieID";
            this.txbMovieID.Size = new System.Drawing.Size(134, 22);
            this.txbMovieID.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1875, 913);
            this.Controls.Add(this.txbMovieID);
            this.Controls.Add(this.txbCustID);
            this.Controls.Add(this.BTNIssueMovie);
            this.Controls.Add(this.BTNDeleteCustomer);
            this.Controls.Add(this.BTNReturnMovie);
            this.Controls.Add(this.BTNAddCustomer);
            this.Controls.Add(this.BTNUpdateCustomer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomers)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMovies)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRentals)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTopMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTopCustomers)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVNotReturned)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DGVCustomers;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DGVMovies;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView DGVRentals;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTNAddCustomer;
        private System.Windows.Forms.Button BTNDeleteCustomer;
        private System.Windows.Forms.Button BTNUpdateCustomer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTNReturnMovie;
        private System.Windows.Forms.Button BTNIssueMovie;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.TextBox txbPlot;
        private System.Windows.Forms.TextBox txbRating;
        private System.Windows.Forms.TextBox txbGenre;
        private System.Windows.Forms.TextBox txbPhoneNumber;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.TextBox txbTitle;
        private System.Windows.Forms.TextBox txbSurname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBLMovieDetails;
        private System.Windows.Forms.Label LBLCustomerDetails;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView DGVTopCustomers;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVTopMovies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVNotReturned;
        private System.Windows.Forms.TextBox txbIssuedDate;
        private System.Windows.Forms.TextBox txbCustID;
        private System.Windows.Forms.TextBox txbMovieID;
    }
}

