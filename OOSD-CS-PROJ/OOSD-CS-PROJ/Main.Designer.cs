﻿namespace OOSD_CS_PROJ
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
            System.Windows.Forms.Label lblPkgID;
            System.Windows.Forms.Label lblPkgName;
            System.Windows.Forms.Label lblPkgStartDate;
            System.Windows.Forms.Label lblPkgEndDate;
            System.Windows.Forms.Label lblPkgDesc;
            System.Windows.Forms.Label lblPkgBasePrice;
            System.Windows.Forms.Label lblPkgAgencyComm;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
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
            this.txtPkgID = new System.Windows.Forms.TextBox();
            this.txtPkgName = new System.Windows.Forms.TextBox();
            this.txtPkgDesc = new System.Windows.Forms.TextBox();
            this.txtPkgBasePrice = new System.Windows.Forms.TextBox();
            this.txtPkgAgencyComm = new System.Windows.Forms.TextBox();
            this.txtPkgStartDate = new System.Windows.Forms.TextBox();
            this.txtPkgEndDate = new System.Windows.Forms.TextBox();
            this.lblPkgDetails = new System.Windows.Forms.Label();
            this.lblSearchPkg = new System.Windows.Forms.Label();
            this.dDLSearch = new System.Windows.Forms.ComboBox();
            this.lblFor = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPkgs = new System.Windows.Forms.Button();
            this.btnPrdts = new System.Windows.Forms.Button();
            this.btnSupps = new System.Windows.Forms.Button();
            this.btnPrdctSupps = new System.Windows.Forms.Button();
            lblPkgID = new System.Windows.Forms.Label();
            lblPkgName = new System.Windows.Forms.Label();
            lblPkgStartDate = new System.Windows.Forms.Label();
            lblPkgEndDate = new System.Windows.Forms.Label();
            lblPkgDesc = new System.Windows.Forms.Label();
            lblPkgBasePrice = new System.Windows.Forms.Label();
            lblPkgAgencyComm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingNavigator)).BeginInit();
            this.packagesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVTest
            // 
            lblPkgID.AutoSize = true;
            lblPkgID.Location = new System.Drawing.Point(167, 131);
            lblPkgID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPkgID.Name = "lblPkgID";
            lblPkgID.Size = new System.Drawing.Size(21, 13);
            lblPkgID.TabIndex = 2;
            lblPkgID.Text = "ID:";
            // 
            // btnAdd
            // 
            lblPkgName.AutoSize = true;
            lblPkgName.Location = new System.Drawing.Point(167, 153);
            lblPkgName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPkgName.Name = "lblPkgName";
            lblPkgName.Size = new System.Drawing.Size(38, 13);
            lblPkgName.TabIndex = 4;
            lblPkgName.Text = "Name:";
            // 
            // lblPkgStartDate
            // 
            lblPkgStartDate.AutoSize = true;
            lblPkgStartDate.Location = new System.Drawing.Point(167, 174);
            lblPkgStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPkgStartDate.Name = "lblPkgStartDate";
            lblPkgStartDate.Size = new System.Drawing.Size(58, 13);
            lblPkgStartDate.TabIndex = 6;
            lblPkgStartDate.Text = "Start Date:";
            // 
            // lblPkgEndDate
            // 
            lblPkgEndDate.AutoSize = true;
            lblPkgEndDate.Location = new System.Drawing.Point(167, 196);
            lblPkgEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPkgEndDate.Name = "lblPkgEndDate";
            lblPkgEndDate.Size = new System.Drawing.Size(55, 13);
            lblPkgEndDate.TabIndex = 8;
            lblPkgEndDate.Text = "End Date:";
            // 
            // lblPkgDesc
            // 
            lblPkgDesc.AutoSize = true;
            lblPkgDesc.Location = new System.Drawing.Point(167, 216);
            lblPkgDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPkgDesc.Name = "lblPkgDesc";
            lblPkgDesc.Size = new System.Drawing.Size(60, 13);
            lblPkgDesc.TabIndex = 10;
            lblPkgDesc.Text = "Description";
            // 
            // lblPkgBasePrice
            // 
            lblPkgBasePrice.AutoSize = true;
            lblPkgBasePrice.Location = new System.Drawing.Point(167, 237);
            lblPkgBasePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPkgBasePrice.Name = "lblPkgBasePrice";
            lblPkgBasePrice.Size = new System.Drawing.Size(61, 13);
            lblPkgBasePrice.TabIndex = 12;
            lblPkgBasePrice.Text = "Base Price:";
            // 
            // lblPkgAgencyComm
            // 
            lblPkgAgencyComm.AutoSize = true;
            lblPkgAgencyComm.Location = new System.Drawing.Point(151, 256);
            lblPkgAgencyComm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPkgAgencyComm.Name = "lblPkgAgencyComm";
            lblPkgAgencyComm.Size = new System.Drawing.Size(104, 13);
            lblPkgAgencyComm.TabIndex = 14;
            lblPkgAgencyComm.Text = "Agency Commission:";
            // 
            // dGView
            // 
            this.dGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGView.Location = new System.Drawing.Point(197, 341);
            this.dGView.Margin = new System.Windows.Forms.Padding(2);
            this.dGView.MultiSelect = false;
            this.dGView.Name = "dGView";
            this.dGView.Size = new System.Drawing.Size(544, 122);
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
            this.packagesBindingNavigator.Size = new System.Drawing.Size(782, 25);
            this.packagesBindingNavigator.TabIndex = 1;
            this.packagesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
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
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
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
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
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
            this.packagesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("packagesBindingNavigatorSaveItem.Image")));
            this.packagesBindingNavigatorSaveItem.Name = "packagesBindingNavigatorSaveItem";
            this.packagesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.packagesBindingNavigatorSaveItem.Text = "Save Data";
            this.packagesBindingNavigatorSaveItem.Click += new System.EventHandler(this.packagesBindingNavigatorSaveItem_Click);
            // 
            // txtPkgID
            // 
            this.txtPkgID.Location = new System.Drawing.Point(259, 129);
            this.txtPkgID.Margin = new System.Windows.Forms.Padding(2);
            this.txtPkgID.Name = "txtPkgID";
            this.txtPkgID.Size = new System.Drawing.Size(151, 20);
            this.txtPkgID.TabIndex = 3;
            // 
            // txtPkgName
            // 
            this.txtPkgName.Location = new System.Drawing.Point(259, 150);
            this.txtPkgName.Margin = new System.Windows.Forms.Padding(2);
            this.txtPkgName.Name = "txtPkgName";
            this.txtPkgName.Size = new System.Drawing.Size(151, 20);
            this.txtPkgName.TabIndex = 5;
            // 
            // txtPkgDesc
            // 
            this.txtPkgDesc.Location = new System.Drawing.Point(259, 213);
            this.txtPkgDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtPkgDesc.Name = "txtPkgDesc";
            this.txtPkgDesc.Size = new System.Drawing.Size(151, 20);
            this.txtPkgDesc.TabIndex = 11;
            // 
            // txtPkgBasePrice
            // 
            this.txtPkgBasePrice.Location = new System.Drawing.Point(259, 235);
            this.txtPkgBasePrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPkgBasePrice.Name = "txtPkgBasePrice";
            this.txtPkgBasePrice.Size = new System.Drawing.Size(151, 20);
            this.txtPkgBasePrice.TabIndex = 13;
            // 
            // txtPkgAgencyComm
            // 
            this.txtPkgAgencyComm.Location = new System.Drawing.Point(259, 256);
            this.txtPkgAgencyComm.Margin = new System.Windows.Forms.Padding(2);
            this.txtPkgAgencyComm.Name = "txtPkgAgencyComm";
            this.txtPkgAgencyComm.Size = new System.Drawing.Size(151, 20);
            this.txtPkgAgencyComm.TabIndex = 15;
            // 
            // txtPkgStartDate
            // 
            this.txtPkgStartDate.Location = new System.Drawing.Point(259, 172);
            this.txtPkgStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtPkgStartDate.Name = "txtPkgStartDate";
            this.txtPkgStartDate.Size = new System.Drawing.Size(151, 20);
            this.txtPkgStartDate.TabIndex = 16;
            // 
            // txtPkgEndDate
            // 
            this.txtPkgEndDate.Location = new System.Drawing.Point(259, 193);
            this.txtPkgEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtPkgEndDate.Name = "txtPkgEndDate";
            this.txtPkgEndDate.Size = new System.Drawing.Size(151, 20);
            this.txtPkgEndDate.TabIndex = 17;
            // 
            // lblPkgDetails
            // 
            this.lblPkgDetails.AutoSize = true;
            this.lblPkgDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgDetails.Location = new System.Drawing.Point(240, 79);
            this.lblPkgDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPkgDetails.Name = "lblPkgDetails";
            this.lblPkgDetails.Size = new System.Drawing.Size(168, 25);
            this.lblPkgDetails.TabIndex = 18;
            this.lblPkgDetails.Text = "Package Details";
            // 
            // lblSearchPkg
            // 
            this.lblSearchPkg.AutoSize = true;
            this.lblSearchPkg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchPkg.Location = new System.Drawing.Point(496, 86);
            this.lblSearchPkg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchPkg.Name = "lblSearchPkg";
            this.lblSearchPkg.Size = new System.Drawing.Size(182, 25);
            this.lblSearchPkg.TabIndex = 19;
            this.lblSearchPkg.Text = "Search Package: ";
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
            this.dDLSearch.Location = new System.Drawing.Point(512, 117);
            this.dDLSearch.Margin = new System.Windows.Forms.Padding(2);
            this.dDLSearch.Name = "dDLSearch";
            this.dDLSearch.Size = new System.Drawing.Size(92, 21);
            this.dDLSearch.TabIndex = 20;
            this.dDLSearch.SelectedIndexChanged += new System.EventHandler(this.dDLSearchPkg_SelectedIndexChanged);
            // 
            // lblFor
            // 
            this.lblFor.AutoSize = true;
            this.lblFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFor.Location = new System.Drawing.Point(621, 114);
            this.lblFor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFor.Name = "lblFor";
            this.lblFor.Size = new System.Drawing.Size(37, 25);
            this.lblFor.TabIndex = 21;
            this.lblFor.Text = "for";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(667, 117);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(74, 20);
            this.txtSearch.TabIndex = 22;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(603, 171);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPkgs
            // 
            this.btnPkgs.Location = new System.Drawing.Point(25, 95);
            this.btnPkgs.Name = "btnPkgs";
            this.btnPkgs.Size = new System.Drawing.Size(87, 42);
            this.btnPkgs.TabIndex = 24;
            this.btnPkgs.Text = "Packages";
            this.btnPkgs.UseVisualStyleBackColor = true;
            // 
            // btnPrdts
            // 
            this.btnPrdts.Location = new System.Drawing.Point(25, 153);
            this.btnPrdts.Name = "btnPrdts";
            this.btnPrdts.Size = new System.Drawing.Size(87, 42);
            this.btnPrdts.TabIndex = 25;
            this.btnPrdts.Text = "Products";
            this.btnPrdts.UseVisualStyleBackColor = true;
            // 
            // btnSupps
            // 
            this.btnSupps.Location = new System.Drawing.Point(25, 208);
            this.btnSupps.Name = "btnSupps";
            this.btnSupps.Size = new System.Drawing.Size(87, 42);
            this.btnSupps.TabIndex = 26;
            this.btnSupps.Text = "Suppliers";
            this.btnSupps.UseVisualStyleBackColor = true;
            // 
            // btnPrdctSupps
            // 
            this.btnPrdctSupps.Location = new System.Drawing.Point(25, 268);
            this.btnPrdctSupps.Name = "btnPrdctSupps";
            this.btnPrdctSupps.Size = new System.Drawing.Size(87, 42);
            this.btnPrdctSupps.TabIndex = 27;
            this.btnPrdctSupps.Text = "Product\r\nSuppliers\r\n";
            this.btnPrdctSupps.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 486);
            this.Controls.Add(this.btnPrdctSupps);
            this.Controls.Add(this.btnSupps);
            this.Controls.Add(this.btnPrdts);
            this.Controls.Add(this.btnPkgs);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblFor);
            this.Controls.Add(this.dDLSearch);
            this.Controls.Add(this.lblSearchPkg);
            this.Controls.Add(this.lblPkgDetails);
            this.Controls.Add(this.txtPkgEndDate);
            this.Controls.Add(this.txtPkgStartDate);
            this.Controls.Add(lblPkgID);
            this.Controls.Add(this.txtPkgID);
            this.Controls.Add(lblPkgName);
            this.Controls.Add(this.txtPkgName);
            this.Controls.Add(lblPkgStartDate);
            this.Controls.Add(lblPkgEndDate);
            this.Controls.Add(lblPkgDesc);
            this.Controls.Add(this.txtPkgDesc);
            this.Controls.Add(lblPkgBasePrice);
            this.Controls.Add(this.txtPkgBasePrice);
            this.Controls.Add(lblPkgAgencyComm);
            this.Controls.Add(this.txtPkgAgencyComm);
            this.Controls.Add(this.packagesBindingNavigator);
            this.Controls.Add(this.dGView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.DGVTest)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox txtPkgID;
        private System.Windows.Forms.TextBox txtPkgName;
        private System.Windows.Forms.TextBox txtPkgDesc;
        private System.Windows.Forms.TextBox txtPkgBasePrice;
        private System.Windows.Forms.TextBox txtPkgAgencyComm;
        private System.Windows.Forms.TextBox txtPkgStartDate;
        private System.Windows.Forms.TextBox txtPkgEndDate;
        private System.Windows.Forms.Label lblPkgDetails;
        private System.Windows.Forms.Label lblSearchPkg;
        private System.Windows.Forms.ComboBox dDLSearch;
        private System.Windows.Forms.Label lblFor;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPkgs;
        private System.Windows.Forms.Button btnPrdts;
        private System.Windows.Forms.Button btnSupps;
        private System.Windows.Forms.Button btnPrdctSupps;
    }
}

