namespace OOSD_CS_PROJ
{
    partial class frmAddNewSupplier
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSupId = new System.Windows.Forms.TextBox();
            this.txtSupName = new System.Windows.Forms.TextBox();
            this.btnAddSup = new System.Windows.Forms.Button();
            this.lblDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SupplierId: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SupName: ";
            // 
            // txtSupId
            // 
            this.txtSupId.Location = new System.Drawing.Point(113, 98);
            this.txtSupId.Name = "txtSupId";
            this.txtSupId.Size = new System.Drawing.Size(100, 20);
            this.txtSupId.TabIndex = 2;
            // 
            // txtSupName
            // 
            this.txtSupName.Location = new System.Drawing.Point(113, 169);
            this.txtSupName.Name = "txtSupName";
            this.txtSupName.Size = new System.Drawing.Size(100, 20);
            this.txtSupName.TabIndex = 3;
            // 
            // btnAddSup
            // 
            this.btnAddSup.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAddSup.Location = new System.Drawing.Point(328, 234);
            this.btnAddSup.Name = "btnAddSup";
            this.btnAddSup.Size = new System.Drawing.Size(105, 66);
            this.btnAddSup.TabIndex = 5;
            this.btnAddSup.Text = "Add New  Supplier";
            this.btnAddSup.UseVisualStyleBackColor = false;
            this.btnAddSup.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(18, 21);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(153, 25);
            this.lblDetails.TabIndex = 45;
            this.lblDetails.Text = "Add a Supplier";
            // 
            // frmAddNewSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(505, 342);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.btnAddSup);
            this.Controls.Add(this.txtSupName);
            this.Controls.Add(this.txtSupId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddNewSupplier";
            this.Text = "frmAddNewSupplier";
            this.Load += new System.EventHandler(this.frmAddNewSupplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSupId;
        private System.Windows.Forms.TextBox txtSupName;
        private System.Windows.Forms.Button btnAddSup;
        private System.Windows.Forms.Label lblDetails;
    }
}