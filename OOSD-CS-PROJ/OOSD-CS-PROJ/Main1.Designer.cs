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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbProdID = new System.Windows.Forms.ComboBox();
            this.cbSupID = new System.Windows.Forms.ComboBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.productsSuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.products_SuppliersTableAdapter = new OOSD_CS_PROJ.TravelExpertsDataSetTableAdapters.Products_SuppliersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsSuppliersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrdctSupps
            // 
            this.btnPrdctSupps.BackColor = System.Drawing.Color.Crimson;
            this.btnPrdctSupps.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrdctSupps.Location = new System.Drawing.Point(824, 83);
            this.btnPrdctSupps.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrdctSupps.Name = "btnPrdctSupps";
            this.btnPrdctSupps.Size = new System.Drawing.Size(150, 54);
            this.btnPrdctSupps.TabIndex = 53;
            this.btnPrdctSupps.Text = "Product Suppliers\r\n";
            this.btnPrdctSupps.UseVisualStyleBackColor = false;
            this.btnPrdctSupps.Click += new System.EventHandler(this.btnPrdctSupps_Click);
            // 
            // btnSupps
            // 
            this.btnSupps.BackColor = System.Drawing.Color.Crimson;
            this.btnSupps.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupps.Location = new System.Drawing.Point(627, 83);
            this.btnSupps.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupps.Name = "btnSupps";
            this.btnSupps.Size = new System.Drawing.Size(135, 54);
            this.btnSupps.TabIndex = 52;
            this.btnSupps.Text = "Suppliers";
            this.btnSupps.UseVisualStyleBackColor = false;
            this.btnSupps.Click += new System.EventHandler(this.btnSupps_Click);
            // 
            // btnPrdts
            // 
            this.btnPrdts.BackColor = System.Drawing.Color.Crimson;
            this.btnPrdts.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrdts.Location = new System.Drawing.Point(432, 83);
            this.btnPrdts.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrdts.Name = "btnPrdts";
            this.btnPrdts.Size = new System.Drawing.Size(135, 54);
            this.btnPrdts.TabIndex = 51;
            this.btnPrdts.Text = "Products";
            this.btnPrdts.UseVisualStyleBackColor = false;
            this.btnPrdts.Click += new System.EventHandler(this.btnPrdts_Click);
            // 
            // btnPkgs
            // 
            this.btnPkgs.BackColor = System.Drawing.Color.Crimson;
            this.btnPkgs.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPkgs.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPkgs.Location = new System.Drawing.Point(243, 83);
            this.btnPkgs.Margin = new System.Windows.Forms.Padding(2);
            this.btnPkgs.Name = "btnPkgs";
            this.btnPkgs.Size = new System.Drawing.Size(135, 54);
            this.btnPkgs.TabIndex = 50;
            this.btnPkgs.Text = "Packages";
            this.btnPkgs.UseVisualStyleBackColor = false;
            this.btnPkgs.Click += new System.EventHandler(this.btnPkgs_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(969, 263);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 41);
            this.btnSearch.TabIndex = 49;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(796, 268);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(149, 31);
            this.txtSearch.TabIndex = 48;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(763, 166);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(259, 33);
            this.lblSearch.TabIndex = 45;
            this.lblSearch.Text = "Search Packages: ";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(264, 161);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(247, 37);
            this.lblDetails.TabIndex = 44;
            this.lblDetails.Text = "Package Details";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(145, 217);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(60, 29);
            this.lblID.TabIndex = 30;
            this.lblID.Text = "   ID:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(339, 215);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(114, 31);
            this.txtID.TabIndex = 31;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(145, 276);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 29);
            this.lblName.TabIndex = 32;
            this.lblName.Text = "Name:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(129, 331);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(124, 29);
            this.lblStartDate.TabIndex = 34;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(129, 385);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(118, 29);
            this.lblEndDate.TabIndex = 35;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(118, 450);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(141, 29);
            this.lblDesc.TabIndex = 36;
            this.lblDesc.Text = "Description:";
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(339, 434);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(283, 74);
            this.txtDesc.TabIndex = 37;
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasePrice.Location = new System.Drawing.Point(117, 527);
            this.lblBasePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(136, 29);
            this.lblBasePrice.TabIndex = 38;
            this.lblBasePrice.Text = "Base Price:";
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasePrice.Location = new System.Drawing.Point(339, 529);
            this.txtBasePrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(114, 31);
            this.txtBasePrice.TabIndex = 39;
            // 
            // lblAgencyComm
            // 
            this.lblAgencyComm.AutoSize = true;
            this.lblAgencyComm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgencyComm.Location = new System.Drawing.Point(76, 576);
            this.lblAgencyComm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAgencyComm.Name = "lblAgencyComm";
            this.lblAgencyComm.Size = new System.Drawing.Size(238, 29);
            this.lblAgencyComm.TabIndex = 40;
            this.lblAgencyComm.Text = "Agency Commission:";
            // 
            // txtAgencyComm
            // 
            this.txtAgencyComm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgencyComm.Location = new System.Drawing.Point(339, 580);
            this.txtAgencyComm.Margin = new System.Windows.Forms.Padding(2);
            this.txtAgencyComm.Name = "txtAgencyComm";
            this.txtAgencyComm.Size = new System.Drawing.Size(114, 31);
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
            this.cBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBName.FormattingEnabled = true;
            this.cBName.Location = new System.Drawing.Point(339, 272);
            this.cBName.Name = "cBName";
            this.cBName.Size = new System.Drawing.Size(247, 33);
            this.cBName.TabIndex = 55;
            this.cBName.SelectedIndexChanged += new System.EventHandler(this.cBPkgName_SelectedIndexChanged);
            // 
            // dTPStartDate
            // 
            this.dTPStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPStartDate.Location = new System.Drawing.Point(339, 329);
            this.dTPStartDate.Name = "dTPStartDate";
            this.dTPStartDate.Size = new System.Drawing.Size(346, 31);
            this.dTPStartDate.TabIndex = 56;
            // 
            // dTPEndDate
            // 
            this.dTPEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPEndDate.Location = new System.Drawing.Point(339, 383);
            this.dTPEndDate.Name = "dTPEndDate";
            this.dTPEndDate.Size = new System.Drawing.Size(346, 31);
            this.dTPEndDate.TabIndex = 57;
            // 
            // cBID
            // 
            this.cBID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBID.FormattingEnabled = true;
            this.cBID.Location = new System.Drawing.Point(339, 215);
            this.cBID.Name = "cBID";
            this.cBID.Size = new System.Drawing.Size(121, 33);
            this.cBID.TabIndex = 58;
            this.cBID.SelectedIndexChanged += new System.EventHandler(this.cBID_SelectedIndexChanged);
            // 
            // txtSupID
            // 
            this.txtSupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupID.Location = new System.Drawing.Point(339, 329);
            this.txtSupID.Name = "txtSupID";
            this.txtSupID.Size = new System.Drawing.Size(114, 31);
            this.txtSupID.TabIndex = 59;
            // 
            // txtProdID
            // 
            this.txtProdID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdID.Location = new System.Drawing.Point(339, 272);
            this.txtProdID.Name = "txtProdID";
            this.txtProdID.Size = new System.Drawing.Size(114, 31);
            this.txtProdID.TabIndex = 60;
            // 
            // lblSearchFor
            // 
            this.lblSearchFor.AutoSize = true;
            this.lblSearchFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchFor.Location = new System.Drawing.Point(825, 211);
            this.lblSearchFor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchFor.Name = "lblSearchFor";
            this.lblSearchFor.Size = new System.Drawing.Size(108, 33);
            this.lblSearchFor.TabIndex = 61;
            this.lblSearchFor.Text = "Names";
            // 
            // packages_Products_SuppliersTableAdapter1
            // 
            this.packages_Products_SuppliersTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnPrdctSupps);
            this.panel1.Controls.Add(this.btnPkgs);
            this.panel1.Controls.Add(this.btnPrdts);
            this.panel1.Controls.Add(this.btnSupps);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 147);
            this.panel1.TabIndex = 62;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OOSD_CS_PROJ.Properties.Resources.THEFINALLOGO;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 147);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 56;
            this.pictureBox2.TabStop = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Calibri", 44.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblHeader.Location = new System.Drawing.Point(410, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(369, 83);
            this.lblHeader.TabIndex = 54;
            this.lblHeader.Text = "Travel Experts";
            this.lblHeader.UseCompatibleTextRendering = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(825, 461);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 40);
            this.btnUpdate.TabIndex = 67;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(825, 527);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 40);
            this.btnSave.TabIndex = 68;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbProdID
            // 
            this.cbProdID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProdID.FormattingEnabled = true;
            this.cbProdID.Location = new System.Drawing.Point(339, 271);
            this.cbProdID.Name = "cbProdID";
            this.cbProdID.Size = new System.Drawing.Size(247, 33);
            this.cbProdID.TabIndex = 69;
            // 
            // cbSupID
            // 
            this.cbSupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSupID.FormattingEnabled = true;
            this.cbSupID.Location = new System.Drawing.Point(339, 329);
            this.cbSupID.Name = "cbSupID";
            this.cbSupID.Size = new System.Drawing.Size(247, 33);
            this.cbSupID.TabIndex = 70;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(821, 358);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(112, 57);
            this.btnAddNew.TabIndex = 71;
            this.btnAddNew.Text = "Add New Package(s)";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // productsSuppliersBindingSource
            // 
            this.productsSuppliersBindingSource.DataMember = "Products_Suppliers";
            this.productsSuppliersBindingSource.DataSource = this.travelExpertsDataSet;
            // 
            // products_SuppliersTableAdapter
            // 
            this.products_SuppliersTableAdapter.ClearBeforeFill = true;
            // 
            // Main1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1172, 670);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.cbSupID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
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
            this.Controls.Add(this.cbProdID);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsSuppliersBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbProdID;
        private System.Windows.Forms.ComboBox cbSupID;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.BindingSource productsSuppliersBindingSource;
        private TravelExpertsDataSetTableAdapters.Products_SuppliersTableAdapter products_SuppliersTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
