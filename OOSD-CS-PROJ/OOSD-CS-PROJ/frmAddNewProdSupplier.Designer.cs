namespace OOSD_CS_PROJ
{
    partial class frmAddNewProdSupplier
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
            this.txtProdSupId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveProdSup = new System.Windows.Forms.Button();
            this.cboProdID = new System.Windows.Forms.ComboBox();
            this.cboSupID = new System.Windows.Forms.ComboBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Supplier ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product ID: ";
            // 
            // txtProdSupId
            // 
            this.txtProdSupId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdSupId.Location = new System.Drawing.Point(298, 126);
            this.txtProdSupId.Name = "txtProdSupId";
            this.txtProdSupId.ReadOnly = true;
            this.txtProdSupId.Size = new System.Drawing.Size(138, 31);
            this.txtProdSupId.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Supplier ID: ";
            // 
            // btnSaveProdSup
            // 
            this.btnSaveProdSup.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSaveProdSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProdSup.Location = new System.Drawing.Point(487, 410);
            this.btnSaveProdSup.Name = "btnSaveProdSup";
            this.btnSaveProdSup.Size = new System.Drawing.Size(144, 102);
            this.btnSaveProdSup.TabIndex = 6;
            this.btnSaveProdSup.Text = "S&ave New Product Supplier";
            this.btnSaveProdSup.UseVisualStyleBackColor = false;
            this.btnSaveProdSup.Click += new System.EventHandler(this.btnSaveProdSup_Click_1);
            // 
            // cboProdID
            // 
            this.cboProdID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProdID.FormattingEnabled = true;
            this.cboProdID.Location = new System.Drawing.Point(298, 231);
            this.cboProdID.Name = "cboProdID";
            this.cboProdID.Size = new System.Drawing.Size(138, 33);
            this.cboProdID.TabIndex = 7;
            // 
            // cboSupID
            // 
            this.cboSupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSupID.FormattingEnabled = true;
            this.cboSupID.Location = new System.Drawing.Point(298, 342);
            this.cboSupID.Name = "cboSupID";
            this.cboSupID.Size = new System.Drawing.Size(138, 33);
            this.cboSupID.TabIndex = 8;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(143, 32);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(321, 37);
            this.lblDetails.TabIndex = 45;
            this.lblDetails.Text = "Add Product Supplier";
            // 
            // frmAddNewProdSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(682, 541);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.cboSupID);
            this.Controls.Add(this.cboProdID);
            this.Controls.Add(this.btnSaveProdSup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProdSupId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddNewProdSupplier";
            this.Text = "frmAddNewProdSupplier";
            this.Load += new System.EventHandler(this.frmAddNewProdSupplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProdSupId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveProdSup;
        private System.Windows.Forms.ComboBox cboProdID;
        private System.Windows.Forms.ComboBox cboSupID;
        private System.Windows.Forms.Label lblDetails;
    }
}
