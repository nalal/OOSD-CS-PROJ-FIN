namespace OOSD_CS_PROJ
{
    partial class Main
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.lblAgencyComm = new System.Windows.Forms.Label();
            this.dGView = new System.Windows.Forms.DataGridView();
            this.travelExpertsDataSet = new OOSD_CS_PROJ.TravelExpertsDataSet();
            this.packagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packagesTableAdapter = new OOSD_CS_PROJ.TravelExpertsDataSetTableAdapters.PackagesTableAdapter();
            this.tableAdapterManager = new OOSD_CS_PROJ.TravelExpertsDataSetTableAdapters.TableAdapterManager();
            this.packagesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.packagesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.txtAgencyComm = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dDLSearch = new System.Windows.Forms.ComboBox();
            this.lblFor = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPkgs = new System.Windows.Forms.Button();
            this.btnPrdts = new System.Windows.Forms.Button();
            this.btnSupps = new System.Windows.Forms.Button();
            this.btnPrdctSupps = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingNavigator)).BeginInit();
            this.packagesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(156, 104);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(156, 135);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(156, 166);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblStartDate.TabIndex = 6;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(156, 200);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(55, 13);
            this.lblEndDate.TabIndex = 8;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(156, 236);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(60, 13);
            this.lblDesc.TabIndex = 10;
            this.lblDesc.Text = "Description";
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Location = new System.Drawing.Point(156, 264);
            this.lblBasePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(61, 13);
            this.lblBasePrice.TabIndex = 12;
            this.lblBasePrice.Text = "Base Price:";
            // 
            // lblAgencyComm
            // 
            this.lblAgencyComm.AutoSize = true;
            this.lblAgencyComm.Location = new System.Drawing.Point(144, 295);
            this.lblAgencyComm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAgencyComm.Name = "lblAgencyComm";
            this.lblAgencyComm.Size = new System.Drawing.Size(104, 13);
            this.lblAgencyComm.TabIndex = 14;
            this.lblAgencyComm.Text = "Agency Commission:";
            // 
            // dGView
            // 
            this.dGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGView.Location = new System.Drawing.Point(45, 344);
            this.dGView.Margin = new System.Windows.Forms.Padding(2);
            this.dGView.MultiSelect = false;
            this.dGView.Name = "dGView";
            this.dGView.Size = new System.Drawing.Size(688, 99);
            this.dGView.TabIndex = 0;
            this.dGView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTest_CellContentClick);
            this.dGView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dGView_DataError);
            this.dGView.SelectionChanged += new System.EventHandler(this.DGVTest_SelectionChanged);
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Packages_Products_SuppliersTableAdapter = null;
            this.tableAdapterManager.PackagesTableAdapter = this.packagesTableAdapter;
            this.tableAdapterManager.Products_SuppliersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OOSD_CS_PROJ.TravelExpertsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // packagesBindingNavigator
            // 
            this.packagesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.packagesBindingNavigator.BindingSource = this.packagesBindingSource;
            this.packagesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.packagesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.packagesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.packagesBindingNavigatorSaveItem});
            this.packagesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.packagesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.packagesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.packagesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.packagesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.packagesBindingNavigator.Name = "packagesBindingNavigator";
            this.packagesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.packagesBindingNavigator.Size = new System.Drawing.Size(839, 25);
            this.packagesBindingNavigator.TabIndex = 1;
            this.packagesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // packagesBindingNavigatorSaveItem
            // 
            this.packagesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.packagesBindingNavigatorSaveItem.Name = "packagesBindingNavigatorSaveItem";
            this.packagesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.packagesBindingNavigatorSaveItem.Text = "Save Data";
            this.packagesBindingNavigatorSaveItem.Click += new System.EventHandler(this.packagesBindingNavigatorSaveItem_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(252, 102);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(114, 20);
            this.txtID.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(252, 132);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(114, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(252, 232);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(114, 20);
            this.txtDesc.TabIndex = 11;
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(252, 261);
            this.txtBasePrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(114, 20);
            this.txtBasePrice.TabIndex = 13;
            // 
            // txtAgencyComm
            // 
            this.txtAgencyComm.Location = new System.Drawing.Point(252, 294);
            this.txtAgencyComm.Margin = new System.Windows.Forms.Padding(2);
            this.txtAgencyComm.Name = "txtAgencyComm";
            this.txtAgencyComm.Size = new System.Drawing.Size(114, 20);
            this.txtAgencyComm.TabIndex = 15;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(252, 164);
            this.txtStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(114, 20);
            this.txtStartDate.TabIndex = 16;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(252, 197);
            this.txtEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(114, 20);
            this.txtEndDate.TabIndex = 17;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(198, 58);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(168, 25);
            this.lblDetails.TabIndex = 18;
            this.lblDetails.Text = "Package Details";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(482, 75);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(193, 25);
            this.lblSearch.TabIndex = 19;
            this.lblSearch.Text = "Search Packages: ";
            // 
            // dDLSearch
            // 
            this.dDLSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dDLSearch.FormattingEnabled = true;
            this.dDLSearch.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Start Date",
            "End Date",
            "Description",
            "Base Price",
            "Agency Commission"});
            this.dDLSearch.Location = new System.Drawing.Point(483, 120);
            this.dDLSearch.Margin = new System.Windows.Forms.Padding(2);
            this.dDLSearch.Name = "dDLSearch";
            this.dDLSearch.Size = new System.Drawing.Size(70, 21);
            this.dDLSearch.TabIndex = 20;
            this.dDLSearch.SelectedIndexChanged += new System.EventHandler(this.dDLSearchPkg_SelectedIndexChanged);
            // 
            // lblFor
            // 
            this.lblFor.AutoSize = true;
            this.lblFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFor.Location = new System.Drawing.Point(565, 118);
            this.lblFor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFor.Name = "lblFor";
            this.lblFor.Size = new System.Drawing.Size(37, 25);
            this.lblFor.TabIndex = 21;
            this.lblFor.Text = "for";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(608, 120);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(56, 20);
            this.txtSearch.TabIndex = 22;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(546, 173);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 19);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPkgs
            // 
            this.btnPkgs.Location = new System.Drawing.Point(19, 77);
            this.btnPkgs.Margin = new System.Windows.Forms.Padding(2);
            this.btnPkgs.Name = "btnPkgs";
            this.btnPkgs.Size = new System.Drawing.Size(65, 34);
            this.btnPkgs.TabIndex = 24;
            this.btnPkgs.Text = "Packages";
            this.btnPkgs.UseVisualStyleBackColor = true;
            // 
            // btnPrdts
            // 
            this.btnPrdts.Location = new System.Drawing.Point(19, 124);
            this.btnPrdts.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrdts.Name = "btnPrdts";
            this.btnPrdts.Size = new System.Drawing.Size(65, 34);
            this.btnPrdts.TabIndex = 25;
            this.btnPrdts.Text = "Products";
            this.btnPrdts.UseVisualStyleBackColor = true;
            this.btnPrdts.Click += new System.EventHandler(this.btnPrdts_Click_1);
            // 
            // btnSupps
            // 
            this.btnSupps.Location = new System.Drawing.Point(19, 169);
            this.btnSupps.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupps.Name = "btnSupps";
            this.btnSupps.Size = new System.Drawing.Size(65, 34);
            this.btnSupps.TabIndex = 26;
            this.btnSupps.Text = "Suppliers";
            this.btnSupps.UseVisualStyleBackColor = true;
            this.btnSupps.Click += new System.EventHandler(this.btnSupps_Click_1);
            // 
            // btnPrdctSupps
            // 
            this.btnPrdctSupps.Location = new System.Drawing.Point(19, 218);
            this.btnPrdctSupps.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrdctSupps.Name = "btnPrdctSupps";
            this.btnPrdctSupps.Size = new System.Drawing.Size(65, 34);
            this.btnPrdctSupps.TabIndex = 27;
            this.btnPrdctSupps.Text = "Product\r\nSuppliers\r\n";
            this.btnPrdctSupps.UseVisualStyleBackColor = true;
            this.btnPrdctSupps.Click += new System.EventHandler(this.btnPrdctSupps_Click_1);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(460, 218);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(142, 43);
            this.btnAddNew.TabIndex = 28;
            this.btnAddNew.Text = "Add New Package";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 507);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnPrdctSupps);
            this.Controls.Add(this.btnSupps);
            this.Controls.Add(this.btnPrdts);
            this.Controls.Add(this.btnPkgs);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblFor);
            this.Controls.Add(this.dDLSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblBasePrice);
            this.Controls.Add(this.txtBasePrice);
            this.Controls.Add(this.lblAgencyComm);
            this.Controls.Add(this.txtAgencyComm);
            this.Controls.Add(this.packagesBindingNavigator);
            this.Controls.Add(this.dGView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingNavigator)).EndInit();
            this.packagesBindingNavigator.ResumeLayout(false);
            this.packagesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGView;
        private TravelExpertsDataSet travelExpertsDataSet;
        private System.Windows.Forms.BindingSource packagesBindingSource;
        private TravelExpertsDataSetTableAdapters.PackagesTableAdapter packagesTableAdapter;
        private TravelExpertsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator packagesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton packagesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.TextBox txtAgencyComm;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox dDLSearch;
        private System.Windows.Forms.Label lblFor;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPkgs;
        private System.Windows.Forms.Button btnPrdts;
        private System.Windows.Forms.Button btnSupps;
        private System.Windows.Forms.Button btnPrdctSupps;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Label lblAgencyComm;
        private System.Windows.Forms.Button btnAddNew;
    }
}

