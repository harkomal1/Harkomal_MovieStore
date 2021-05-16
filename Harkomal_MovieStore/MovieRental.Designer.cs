namespace Harkomal_MovieStore
{
    partial class MovieRental
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
            this.txtRentedCost = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnReturnMovie = new System.Windows.Forms.Button();
            this.DeleteCustomer = new System.Windows.Forms.Button();
            this.UpdateCustomer = new System.Windows.Forms.Button();
            this.gvRental = new System.Windows.Forms.DataGridView();
            this.RentedMovies = new System.Windows.Forms.TabPage();
            this.gvMovies = new System.Windows.Forms.DataGridView();
            this.Movies = new System.Windows.Forms.TabPage();
            this.CustomersDataGridView = new System.Windows.Forms.DataGridView();
            this.Customers = new System.Windows.Forms.TabPage();
            this.btnIssueMovie = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ddlCustomer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.AddCustomer = new System.Windows.Forms.Button();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ddlMovie = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelMOvie = new System.Windows.Forms.Button();
            this.btnAddMOvie = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtIsuue = new System.Windows.Forms.DateTimePicker();
            this.dtReturn = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ddlRentedMovies = new System.Windows.Forms.ComboBox();
            this.btnCustMostMovie = new System.Windows.Forms.Button();
            this.btnMostPopulrMovies = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvRental)).BeginInit();
            this.RentedMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMovies)).BeginInit();
            this.Movies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).BeginInit();
            this.Customers.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRentedCost
            // 
            this.txtRentedCost.Enabled = false;
            this.txtRentedCost.Location = new System.Drawing.Point(669, 55);
            this.txtRentedCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtRentedCost.Name = "txtRentedCost";
            this.txtRentedCost.Size = new System.Drawing.Size(88, 26);
            this.txtRentedCost.TabIndex = 40;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(299, 55);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(85, 26);
            this.txtYear.TabIndex = 39;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(37, 55);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(237, 26);
            this.txtTitle.TabIndex = 38;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(587, 53);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(160, 26);
            this.txtPhone.TabIndex = 32;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(269, 46);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(223, 47);
            this.txtAddress.TabIndex = 31;
            // 
            // btnReturnMovie
            // 
            this.btnReturnMovie.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnReturnMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMovie.Location = new System.Drawing.Point(20, 236);
            this.btnReturnMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturnMovie.Name = "btnReturnMovie";
            this.btnReturnMovie.Size = new System.Drawing.Size(276, 46);
            this.btnReturnMovie.TabIndex = 28;
            this.btnReturnMovie.Text = "Return Movie";
            this.btnReturnMovie.UseVisualStyleBackColor = false;
            this.btnReturnMovie.Click += new System.EventHandler(this.btnReturnMovie_Click);
            // 
            // DeleteCustomer
            // 
            this.DeleteCustomer.Location = new System.Drawing.Point(811, 110);
            this.DeleteCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteCustomer.Name = "DeleteCustomer";
            this.DeleteCustomer.Size = new System.Drawing.Size(161, 33);
            this.DeleteCustomer.TabIndex = 26;
            this.DeleteCustomer.Text = "Delete Customer";
            this.DeleteCustomer.UseVisualStyleBackColor = true;
            this.DeleteCustomer.Click += new System.EventHandler(this.DeleteCustomer_Click);
            // 
            // UpdateCustomer
            // 
            this.UpdateCustomer.Location = new System.Drawing.Point(643, 107);
            this.UpdateCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateCustomer.Name = "UpdateCustomer";
            this.UpdateCustomer.Size = new System.Drawing.Size(161, 33);
            this.UpdateCustomer.TabIndex = 25;
            this.UpdateCustomer.Text = "Update Customer";
            this.UpdateCustomer.UseVisualStyleBackColor = true;
            this.UpdateCustomer.Click += new System.EventHandler(this.UpdateCustomer_Click);
            // 
            // gvRental
            // 
            this.gvRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRental.Location = new System.Drawing.Point(4, 4);
            this.gvRental.Margin = new System.Windows.Forms.Padding(4);
            this.gvRental.Name = "gvRental";
            this.gvRental.RowHeadersWidth = 51;
            this.gvRental.Size = new System.Drawing.Size(1181, 292);
            this.gvRental.TabIndex = 0;
            // 
            // RentedMovies
            // 
            this.RentedMovies.BackColor = System.Drawing.Color.Transparent;
            this.RentedMovies.Controls.Add(this.gvRental);
            this.RentedMovies.Location = new System.Drawing.Point(4, 25);
            this.RentedMovies.Margin = new System.Windows.Forms.Padding(4);
            this.RentedMovies.Name = "RentedMovies";
            this.RentedMovies.Size = new System.Drawing.Size(1192, 302);
            this.RentedMovies.TabIndex = 2;
            this.RentedMovies.Text = "Rented Movies";
            // 
            // gvMovies
            // 
            this.gvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMovies.Location = new System.Drawing.Point(8, 7);
            this.gvMovies.Margin = new System.Windows.Forms.Padding(4);
            this.gvMovies.Name = "gvMovies";
            this.gvMovies.RowHeadersWidth = 51;
            this.gvMovies.Size = new System.Drawing.Size(1173, 288);
            this.gvMovies.TabIndex = 0;
            // 
            // Movies
            // 
            this.Movies.Controls.Add(this.gvMovies);
            this.Movies.Location = new System.Drawing.Point(4, 25);
            this.Movies.Margin = new System.Windows.Forms.Padding(4);
            this.Movies.Name = "Movies";
            this.Movies.Padding = new System.Windows.Forms.Padding(4);
            this.Movies.Size = new System.Drawing.Size(1192, 302);
            this.Movies.TabIndex = 1;
            this.Movies.Text = "Movies";
            this.Movies.UseVisualStyleBackColor = true;
            // 
            // CustomersDataGridView
            // 
            this.CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersDataGridView.Location = new System.Drawing.Point(8, 7);
            this.CustomersDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.CustomersDataGridView.Name = "CustomersDataGridView";
            this.CustomersDataGridView.RowHeadersWidth = 51;
            this.CustomersDataGridView.Size = new System.Drawing.Size(1180, 288);
            this.CustomersDataGridView.TabIndex = 0;
            // 
            // Customers
            // 
            this.Customers.Controls.Add(this.CustomersDataGridView);
            this.Customers.Location = new System.Drawing.Point(4, 25);
            this.Customers.Margin = new System.Windows.Forms.Padding(4);
            this.Customers.Name = "Customers";
            this.Customers.Padding = new System.Windows.Forms.Padding(4);
            this.Customers.Size = new System.Drawing.Size(1192, 302);
            this.Customers.TabIndex = 0;
            this.Customers.Text = "Customers";
            this.Customers.UseVisualStyleBackColor = true;
            // 
            // btnIssueMovie
            // 
            this.btnIssueMovie.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnIssueMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueMovie.Location = new System.Drawing.Point(20, 122);
            this.btnIssueMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btnIssueMovie.Name = "btnIssueMovie";
            this.btnIssueMovie.Size = new System.Drawing.Size(276, 46);
            this.btnIssueMovie.TabIndex = 27;
            this.btnIssueMovie.Text = "Issue Movie";
            this.btnIssueMovie.UseVisualStyleBackColor = false;
            this.btnIssueMovie.Click += new System.EventHandler(this.btnIssueMovie_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Customers);
            this.TabControl.Controls.Add(this.Movies);
            this.TabControl.Controls.Add(this.RentedMovies);
            this.TabControl.Location = new System.Drawing.Point(53, 39);
            this.TabControl.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1200, 331);
            this.TabControl.TabIndex = 21;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ddlCustomer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.AddCustomer);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.DeleteCustomer);
            this.groupBox1.Controls.Add(this.UpdateCustomer);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 468);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1005, 149);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Panel";
            // 
            // ddlCustomer
            // 
            this.ddlCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCustomer.FormattingEnabled = true;
            this.ddlCustomer.Location = new System.Drawing.Point(396, 107);
            this.ddlCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddlCustomer.Name = "ddlCustomer";
            this.ddlCustomer.Size = new System.Drawing.Size(227, 28);
            this.ddlCustomer.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(589, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Phone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(24, 53);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(195, 26);
            this.txtName.TabIndex = 44;
            // 
            // AddCustomer
            // 
            this.AddCustomer.Location = new System.Drawing.Point(811, 46);
            this.AddCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Size = new System.Drawing.Size(161, 33);
            this.AddCustomer.TabIndex = 43;
            this.AddCustomer.Text = "Add Customer";
            this.AddCustomer.UseVisualStyleBackColor = true;
            this.AddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(547, 55);
            this.txtRating.Margin = new System.Windows.Forms.Padding(4);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(89, 26);
            this.txtRating.TabIndex = 47;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(404, 55);
            this.txtGenre.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(121, 26);
            this.txtGenre.TabIndex = 46;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ddlMovie);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnDelMOvie);
            this.groupBox2.Controls.Add(this.btnAddMOvie);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtRating);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtRentedCost);
            this.groupBox2.Controls.Add(this.txtGenre);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTitle);
            this.groupBox2.Controls.Add(this.txtYear);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 638);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1005, 142);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Movie Panel";
            // 
            // ddlMovie
            // 
            this.ddlMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMovie.FormattingEnabled = true;
            this.ddlMovie.Location = new System.Drawing.Point(405, 98);
            this.ddlMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddlMovie.Name = "ddlMovie";
            this.ddlMovie.Size = new System.Drawing.Size(231, 28);
            this.ddlMovie.TabIndex = 55;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(652, 94);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(161, 33);
            this.btnUpdate.TabIndex = 54;
            this.btnUpdate.Text = "Update Movie";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelMOvie
            // 
            this.btnDelMOvie.Location = new System.Drawing.Point(824, 94);
            this.btnDelMOvie.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelMOvie.Name = "btnDelMOvie";
            this.btnDelMOvie.Size = new System.Drawing.Size(161, 33);
            this.btnDelMOvie.TabIndex = 53;
            this.btnDelMOvie.Text = "Delete Movie";
            this.btnDelMOvie.UseVisualStyleBackColor = true;
            this.btnDelMOvie.Click += new System.EventHandler(this.btnDelMOvie_Click);
            // 
            // btnAddMOvie
            // 
            this.btnAddMOvie.Location = new System.Drawing.Point(824, 46);
            this.btnAddMOvie.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMOvie.Name = "btnAddMOvie";
            this.btnAddMOvie.Size = new System.Drawing.Size(161, 33);
            this.btnAddMOvie.TabIndex = 52;
            this.btnAddMOvie.Text = "Add Movie";
            this.btnAddMOvie.UseVisualStyleBackColor = true;
            this.btnAddMOvie.Click += new System.EventHandler(this.btnAddMOvie_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(667, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "Rent cost($):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(544, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Rating (*/10):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Genre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Title:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 49;
            this.label9.Text = "Issue Date:";
            // 
            // dtIsuue
            // 
            this.dtIsuue.Location = new System.Drawing.Point(145, 34);
            this.dtIsuue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtIsuue.Name = "dtIsuue";
            this.dtIsuue.Size = new System.Drawing.Size(200, 26);
            this.dtIsuue.TabIndex = 50;
            // 
            // dtReturn
            // 
            this.dtReturn.Location = new System.Drawing.Point(145, 75);
            this.dtReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtReturn.Name = "dtReturn";
            this.dtReturn.Size = new System.Drawing.Size(200, 26);
            this.dtReturn.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 20);
            this.label10.TabIndex = 52;
            this.label10.Text = "Return Date:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.ddlRentedMovies);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.dtReturn);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.dtIsuue);
            this.groupBox3.Controls.Add(this.btnIssueMovie);
            this.groupBox3.Controls.Add(this.btnReturnMovie);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1045, 470);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(460, 302);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Movie Issue / Return Panel";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 20);
            this.label11.TabIndex = 54;
            this.label11.Text = "Select Rented Movie:";
            // 
            // ddlRentedMovies
            // 
            this.ddlRentedMovies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlRentedMovies.FormattingEnabled = true;
            this.ddlRentedMovies.Location = new System.Drawing.Point(217, 199);
            this.ddlRentedMovies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddlRentedMovies.Name = "ddlRentedMovies";
            this.ddlRentedMovies.Size = new System.Drawing.Size(213, 28);
            this.ddlRentedMovies.TabIndex = 53;
            // 
            // btnCustMostMovie
            // 
            this.btnCustMostMovie.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnCustMostMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustMostMovie.Location = new System.Drawing.Point(107, 402);
            this.btnCustMostMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCustMostMovie.Name = "btnCustMostMovie";
            this.btnCustMostMovie.Size = new System.Drawing.Size(401, 34);
            this.btnCustMostMovie.TabIndex = 55;
            this.btnCustMostMovie.Text = "Show Customers who borrows most movies ";
            this.btnCustMostMovie.UseVisualStyleBackColor = false;
            this.btnCustMostMovie.Click += new System.EventHandler(this.btnCustMostMovie_Click);
            // 
            // btnMostPopulrMovies
            // 
            this.btnMostPopulrMovies.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnMostPopulrMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostPopulrMovies.Location = new System.Drawing.Point(929, 402);
            this.btnMostPopulrMovies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostPopulrMovies.Name = "btnMostPopulrMovies";
            this.btnMostPopulrMovies.Size = new System.Drawing.Size(268, 34);
            this.btnMostPopulrMovies.TabIndex = 56;
            this.btnMostPopulrMovies.Text = "Most popular movies";
            this.btnMostPopulrMovies.UseVisualStyleBackColor = false;
            this.btnMostPopulrMovies.Click += new System.EventHandler(this.btnMostPopulrMovies_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(584, 402);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(288, 34);
            this.btnShow.TabIndex = 57;
            this.btnShow.Text = "Show all rented movies";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // MovieRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1519, 789);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnMostPopulrMovies);
            this.Controls.Add(this.btnCustMostMovie);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MovieRental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Rental Store";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvRental)).EndInit();
            this.RentedMovies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvMovies)).EndInit();
            this.Movies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).EndInit();
            this.Customers.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtRentedCost;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnReturnMovie;
        private System.Windows.Forms.Button DeleteCustomer;
        private System.Windows.Forms.Button UpdateCustomer;
        private System.Windows.Forms.DataGridView gvRental;
        private System.Windows.Forms.TabPage RentedMovies;
        private System.Windows.Forms.DataGridView gvMovies;
        private System.Windows.Forms.TabPage Movies;
        private System.Windows.Forms.DataGridView CustomersDataGridView;
        private System.Windows.Forms.TabPage Customers;
        private System.Windows.Forms.Button btnIssueMovie;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button AddCustomer;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlCustomer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ddlMovie;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelMOvie;
        private System.Windows.Forms.Button btnAddMOvie;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtIsuue;
        private System.Windows.Forms.DateTimePicker dtReturn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ddlRentedMovies;
        private System.Windows.Forms.Button btnCustMostMovie;
        private System.Windows.Forms.Button btnMostPopulrMovies;
        private System.Windows.Forms.Button btnShow;
    }
}

