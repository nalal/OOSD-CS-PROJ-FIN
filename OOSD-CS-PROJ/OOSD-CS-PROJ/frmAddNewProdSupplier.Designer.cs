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
            this.txtProdId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSupId = new System.Windows.Forms.TextBox();
            this.btnSaveProdSup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProductSupplierId: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ProductId: ";
            // 
            // txtProdSupId
            // 
            this.txtProdSupId.Location = new System.Drawing.Point(167, 89);
            this.txtProdSupId.Name = "txtProdSupId";
            this.txtProdSupId.Size = new System.Drawing.Size(100, 20);
            this.txtProdSupId.TabIndex = 2;
            // 
            // txtProdId
            // 
            this.txtProdId.Location = new System.Drawing.Point(167, 157);
            this.txtProdId.Name = "txtProdId";
            this.txtProdId.Size = new System.Drawing.Size(100, 20);
            this.txtProdId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "SupplierId: ";
            // 
            // txtSupId
            // 
            this.txtSupId.Location = new System.Drawing.Point(167, 217);
            this.txtSupId.Name = "txtSupId";
            this.txtSupId.Size = new System.Drawing.Size(100, 20);
            this.txtSupId.TabIndex = 5;
            // 
            // btnSaveProdSup
            // 
            this.btnSaveProdSup.Location = new System.Drawing.Point(272, 259);
            this.btnSaveProdSup.Name = "btnSaveProdSup";
            this.btnSaveProdSup.Size = new System.Drawing.Size(108, 53);
            this.btnSaveProdSup.TabIndex = 6;
            this.btnSaveProdSup.Text = "Save Product Supplier";
            this.btnSaveProdSup.UseVisualStyleBackColor = true;
            this.btnSaveProdSup.Click += new System.EventHandler(this.btnSaveProdSup_Click);
            // 
            // frmAddNewProdSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 338);
            this.Controls.Add(this.btnSaveProdSup);
            this.Controls.Add(this.txtSupId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProdId);
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
        private System.Windows.Forms.TextBox txtProdId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSupId;
        private System.Windows.Forms.Button btnSaveProdSup;
    }
}