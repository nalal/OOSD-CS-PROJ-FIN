namespace OOSD_CS_PROJ
{
    partial class Main1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main1));
            this.btnPrdctSupps = new System.Windows.Forms.Button();
            this.btnSupps = new System.Windows.Forms.Button();
            this.btnPrdts = new System.Windows.Forms.Button();
            this.btnPkgs = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.lblAgencyComm = new System.Windows.Forms.Label();
            this.txtAgencyComm = new System.Windows.Forms.TextBox();
            this.packagesBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.travelExpertsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelExpertsDataSet = new OOSD_CS_PROJ.TravelExpertsDataSet();
            this.packagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packagesTableAdapter = new OOSD_CS_PROJ.TravelExpertsDataSetTableAdapters.PackagesTableAdapter();
            this.packagesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.packagesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.packagesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.cBName = new System.Windows.Forms.ComboBox();
            this.dTPStartDate = new System.Windows.Forms.DateTimePicker();
            this.dTPEndDate = new System.Windows.Forms.DateTimePicker();
            this.cBID = new System.Windows.Forms.ComboBox();
            this.txtSupID = new System.Windows.Forms.TextBox();
            this.txtProdID = new System.Windows.Forms.TextBox();
            this.lblSearchFor = new System.Windows.Forms.Label();
            this.packages_Products_SuppliersTableAdapter1 = new OOSD_CS_PROJ.TravelExpertsDataSetTableAdapters.Packages_Products_SuppliersTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.btnAddSup = new System.Windows.Forms.Button();
            this.btnAddProdSup = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 

            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddNew.Location = new System.Drawing.Point(282, 337);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(142, 43);
            this.btnAddNew.TabIndex = 54;
            this.btnAddNew.Text = "Add New Package(s)";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 

            // btnPrdctSupps
            // 
            this.btnPrdctSupps.BackColor = System.Drawing.Color.Crimson;
            this.btnPrdctSupps.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrdctSupps.Location = new System.Drawing.Point(451, 75);
            this.btnPrdctSupps.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrdctSupps.Name = "btnPrdctSupps";
            this.btnPrdctSupps.Size = new System.Drawing.Size(134, 41);
            this.btnPrdctSupps.TabIndex = 53;
            this.btnPrdctSupps.Text = "Product Suppliers\r\n";
            this.btnPrdctSupps.UseVisualStyleBackColor = false;
            this.btnPrdctSupps.Click += new System.EventHandler(this.btnPrdctSupps_Click);
            // 
            // btnSupps
            // 
            this.btnSupps.BackColor = System.Drawing.Color.Crimson;
            this.btnSupps.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupps.Location = new System.Drawing.Point(335, 75);
            this.btnSupps.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupps.Name = "btnSupps";
            this.btnSupps.Size = new System.Drawing.Size(96, 41);
            this.btnSupps.TabIndex = 52;
            this.btnSupps.Text = "Suppliers";
            this.btnSupps.UseVisualStyleBackColor = false;
            this.btnSupps.Click += new System.EventHandler(this.btnSupps_Click);
            // 
            // btnPrdts
            // 
            this.btnPrdts.BackColor = System.Drawing.Color.Crimson;
            this.btnPrdts.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrdts.Location = new System.Drawing.Point(195, 75);
            this.btnPrdts.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrdts.Name = "btnPrdts";
            this.btnPrdts.Size = new System.Drawing.Size(96, 41);
            this.btnPrdts.TabIndex = 51;
            this.btnPrdts.Text = "Products";
            this.btnPrdts.UseVisualStyleBackColor = false;
            this.btnPrdts.Click += new System.EventHandler(this.btnPrdts_Click);
            // 
            // btnPkgs
            // 
            this.btnPkgs.BackColor = System.Drawing.Color.Crimson;
            this.btnPkgs.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPkgs.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPkgs.Location = new System.Drawing.Point(53, 75);
            this.btnPkgs.Margin = new System.Windows.Forms.Padding(2);
            this.btnPkgs.Name = "btnPkgs";
            this.btnPkgs.Size = new System.Drawing.Size(96, 41);
            this.btnPkgs.TabIndex = 50;
            this.btnPkgs.Text = "Packages";
            this.btnPkgs.UseVisualStyleBackColor = false;
            this.btnPkgs.Click += new System.EventHandler(this.btnPkgs_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Thistle;
            this.btnSearch.Location = new System.Drawing.Point(428, 270);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 31);
            this.btnSearch.TabIndex = 49;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(414, 233);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(98, 20);
            this.txtSearch.TabIndex = 48;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(368, 163);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(193, 25);
            this.lblSearch.TabIndex = 45;
            this.lblSearch.Text = "Search Packages: ";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(77, 146);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(168, 25);
            this.lblDetails.TabIndex = 44;
            this.lblDetails.Text = "Package Details";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(35, 192);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(30, 13);
            this.lblID.TabIndex = 30;
            this.lblID.Text = "   ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(131, 190);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(114, 20);
            this.txtID.TabIndex = 31;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(35, 223);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 32;
            this.lblName.Text = "Name:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(35, 254);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblStartDate.TabIndex = 34;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(35, 288);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(55, 13);
            this.lblEndDate.TabIndex = 35;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(35, 324);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(60, 13);
            this.lblDesc.TabIndex = 36;
            this.lblDesc.Text = "Description";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(131, 320);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(114, 20);
            this.txtDesc.TabIndex = 37;
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Location = new System.Drawing.Point(35, 352);
            this.lblBasePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(61, 13);
            this.lblBasePrice.TabIndex = 38;
            this.lblBasePrice.Text = "Base Price:";
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(131, 349);
            this.txtBasePrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(114, 20);
            this.txtBasePrice.TabIndex = 39;
            // 
            // lblAgencyComm
            // 
            this.lblAgencyComm.AutoSize = true;
            this.lblAgencyComm.Location = new System.Drawing.Point(23, 383);
            this.lblAgencyComm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAgencyComm.Name = "lblAgencyComm";
            this.lblAgencyComm.Size = new System.Drawing.Size(104, 13);
            this.lblAgencyComm.TabIndex = 40;
            this.lblAgencyComm.Text = "Agency Commission:";
            // 
            // txtAgencyComm
            // 
            this.txtAgencyComm.Location = new System.Drawing.Point(131, 382);
            this.txtAgencyComm.Margin = new System.Windows.Forms.Padding(2);
            this.txtAgencyComm.Name = "txtAgencyComm";
            this.txtAgencyComm.Size = new System.Drawing.Size(114, 20);
            this.txtAgencyComm.TabIndex = 41;
            // 
            // packagesBindingSource4
            // 
            this.packagesBindingSource4.DataMember = "Packages";
            this.packagesBindingSource4.DataSource = this.travelExpertsDataSetBindingSource;
            // 
            // travelExpertsDataSetBindingSource
            // 
            this.travelExpertsDataSetBindingSource.DataSource = this.travelExpertsDataSet;
            this.travelExpertsDataSetBindingSource.Position = 0;
            // 
            // travelExpertsDataSet
            // 
            this.travelExpertsDataSet.DataSetName = "TravelExpertsDataSet";
            this.travelExpertsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // packagesBindingSource
            // 
            this.packagesBindingSource.DataMember = "Packages";
            this.packagesBindingSource.DataSource = this.travelExpertsDataSet;
            // 
            // packagesTableAdapter
            // 
            this.packagesTableAdapter.ClearBeforeFill = true;
            // 
            // packagesBindingSource1
            // 
            this.packagesBindingSource1.DataMember = "Packages";
            this.packagesBindingSource1.DataSource = this.travelExpertsDataSetBindingSource;
            // 
            // packagesBindingSource2
            // 
            this.packagesBindingSource2.DataMember = "Packages";
            this.packagesBindingSource2.DataSource = this.travelExpertsDataSetBindingSource;
            // 
            // packagesBindingSource3
            // 
            this.packagesBindingSource3.DataMember = "Packages";
            this.packagesBindingSource3.DataSource = this.travelExpertsDataSetBindingSource;
            // 
            // cBName
            // 
            this.cBName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBName.FormattingEnabled = true;
            this.cBName.Location = new System.Drawing.Point(131, 223);
            this.cBName.Name = "cBName";
            this.cBName.Size = new System.Drawing.Size(121, 21);
            this.cBName.TabIndex = 55;
            this.cBName.SelectedIndexChanged += new System.EventHandler(this.cBPkgName_SelectedIndexChanged);
            // 
            // dTPStartDate
            // 
            this.dTPStartDate.Location = new System.Drawing.Point(131, 257);
            this.dTPStartDate.Name = "dTPStartDate";
            this.dTPStartDate.Size = new System.Drawing.Size(200, 20);
            this.dTPStartDate.TabIndex = 56;
            // 
            // dTPEndDate
            // 
            this.dTPEndDate.Location = new System.Drawing.Point(131, 288);
            this.dTPEndDate.Name = "dTPEndDate";
            this.dTPEndDate.Size = new System.Drawing.Size(200, 20);
            this.dTPEndDate.TabIndex = 57;
            // 
            // cBID
            // 
            this.cBID.FormattingEnabled = true;
            this.cBID.Location = new System.Drawing.Point(131, 190);
            this.cBID.Name = "cBID";
            this.cBID.Size = new System.Drawing.Size(121, 21);
            this.cBID.TabIndex = 58;
            this.cBID.SelectedIndexChanged += new System.EventHandler(this.cBID_SelectedIndexChanged);
            // 
            // txtSupID
            // 
            this.txtSupID.Location = new System.Drawing.Point(131, 257);
            this.txtSupID.Name = "txtSupID";
            this.txtSupID.Size = new System.Drawing.Size(114, 20);
            this.txtSupID.TabIndex = 59;
            // 
            // txtProdID
            // 
            this.txtProdID.Location = new System.Drawing.Point(131, 223);
            this.txtProdID.Name = "txtProdID";
            this.txtProdID.Size = new System.Drawing.Size(114, 20);
            this.txtProdID.TabIndex = 60;
            // 
            // lblSearchFor
            // 
            this.lblSearchFor.AutoSize = true;
            this.lblSearchFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchFor.Location = new System.Drawing.Point(418, 195);
            this.lblSearchFor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchFor.Name = "lblSearchFor";
            this.lblSearchFor.Size = new System.Drawing.Size(79, 25);
            this.lblSearchFor.TabIndex = 61;
            this.lblSearchFor.Text = "Names";
            // 
            // packages_Products_SuppliersTableAdapter1
            // 
            this.packages_Products_SuppliersTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnPrdctSupps);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Controls.Add(this.btnPkgs);
            this.panel1.Controls.Add(this.btnPrdts);
            this.panel1.Controls.Add(this.btnSupps);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 123);
            this.panel1.TabIndex = 62;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Calibri", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblHeader.Location = new System.Drawing.Point(122, -6);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(350, 79);
            this.lblHeader.TabIndex = 54;
            this.lblHeader.Text = "Travel Experts";
            this.lblHeader.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 441);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(601, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddProd
            // 
            this.btnAddProd.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddProd.Location = new System.Drawing.Point(430, 309);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(67, 43);
            this.btnAddProd.TabIndex = 64;
            this.btnAddProd.Text = "Add New Products";
            this.btnAddProd.UseVisualStyleBackColor = false;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // btnAddSup
            // 
            this.btnAddSup.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddSup.Location = new System.Drawing.Point(503, 320);
            this.btnAddSup.Name = "btnAddSup";
            this.btnAddSup.Size = new System.Drawing.Size(85, 43);
            this.btnAddSup.TabIndex = 65;
            this.btnAddSup.Text = "Add New Suppliers";
            this.btnAddSup.UseVisualStyleBackColor = false;
            this.btnAddSup.Click += new System.EventHandler(this.btnAddSup_Click);
            // 
            // btnAddProdSup
            // 
            this.btnAddProdSup.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddProdSup.Location = new System.Drawing.Point(451, 370);
            this.btnAddProdSup.Name = "btnAddProdSup";
            this.btnAddProdSup.Size = new System.Drawing.Size(110, 43);
            this.btnAddProdSup.TabIndex = 66;
            this.btnAddProdSup.Text = "Add New Product Suppliers";
            this.btnAddProdSup.UseVisualStyleBackColor = false;
            this.btnAddProdSup.Click += new System.EventHandler(this.btnAddProdSup_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 67);
            this.button1.TabIndex = 67;
            this.button1.Text = "Add New Packages";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(596, 528);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddProdSup);
            this.Controls.Add(this.btnAddSup);
            this.Controls.Add(this.btnAddProd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSearchFor);
            this.Controls.Add(this.txtProdID);
            this.Controls.Add(this.txtSupID);
            this.Controls.Add(this.dTPStartDate);
            this.Controls.Add(this.cBID);
            this.Controls.Add(this.dTPEndDate);
            this.Controls.Add(this.cBName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblBasePrice);
            this.Controls.Add(this.txtBasePrice);
            this.Controls.Add(this.lblAgencyComm);
            this.Controls.Add(this.txtAgencyComm);
            this.Name = "Main1";
            this.Text = "Main1";
            this.Load += new System.EventHandler(this.Main1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrdctSupps;
        private System.Windows.Forms.Button btnSupps;
        private System.Windows.Forms.Button btnPrdts;
        private System.Windows.Forms.Button btnPkgs;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.Label lblAgencyComm;
        private System.Windows.Forms.TextBox txtAgencyComm;
        private TravelExpertsDataSet travelExpertsDataSet;
        private System.Windows.Forms.BindingSource packagesBindingSource;
        private TravelExpertsDataSetTableAdapters.PackagesTableAdapter packagesTableAdapter;
        private System.Windows.Forms.BindingSource travelExpertsDataSetBindingSource;
        private System.Windows.Forms.BindingSource packagesBindingSource1;
        private System.Windows.Forms.BindingSource packagesBindingSource4;
        private System.Windows.Forms.BindingSource packagesBindingSource2;
        private System.Windows.Forms.BindingSource packagesBindingSource3;
        private System.Windows.Forms.ComboBox cBName;
        private System.Windows.Forms.DateTimePicker dTPStartDate;
        private System.Windows.Forms.DateTimePicker dTPEndDate;
        private System.Windows.Forms.ComboBox cBID;
        private System.Windows.Forms.TextBox txtSupID;
        private System.Windows.Forms.TextBox txtProdID;
        private System.Windows.Forms.Label lblSearchFor;
        private TravelExpertsDataSetTableAdapters.Packages_Products_SuppliersTableAdapter packages_Products_SuppliersTableAdapter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Button btnAddSup;
        private System.Windows.Forms.Button btnAddProdSup;
        private System.Windows.Forms.Button button1;
    }
}