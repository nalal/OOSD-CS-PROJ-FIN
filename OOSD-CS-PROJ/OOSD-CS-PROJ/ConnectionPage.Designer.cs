namespace OOSD_CS_PROJ
{
    partial class ConnectionPage
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
            this.TBUser = new System.Windows.Forms.TextBox();
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BLogin = new System.Windows.Forms.Button();
            this.RBLocal = new System.Windows.Forms.RadioButton();
            this.RBRemote = new System.Windows.Forms.RadioButton();
            this.BClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBUser
            // 
            this.TBUser.Location = new System.Drawing.Point(76, 38);
            this.TBUser.Name = "TBUser";
            this.TBUser.Size = new System.Drawing.Size(100, 20);
            this.TBUser.TabIndex = 1;
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(76, 12);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(100, 20);
            this.TBName.TabIndex = 0;
            this.TBName.Text = "ELF8OOSD197690\\SQLEXPRESS";
            // 
            // TBPass
            // 
            this.TBPass.Location = new System.Drawing.Point(76, 64);
            this.TBPass.Name = "TBPass";
            this.TBPass.Size = new System.Drawing.Size(100, 20);
            this.TBPass.TabIndex = 2;
            this.TBPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name/IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // BLogin
            // 
            this.BLogin.Location = new System.Drawing.Point(12, 136);
            this.BLogin.Name = "BLogin";
            this.BLogin.Size = new System.Drawing.Size(75, 23);
            this.BLogin.TabIndex = 6;
            this.BLogin.Text = "Login";
            this.BLogin.UseVisualStyleBackColor = true;
            this.BLogin.Click += new System.EventHandler(this.BLogin_Click);
            // 
            // RBLocal
            // 
            this.RBLocal.AutoSize = true;
            this.RBLocal.Checked = true;
            this.RBLocal.Location = new System.Drawing.Point(15, 90);
            this.RBLocal.Name = "RBLocal";
            this.RBLocal.Size = new System.Drawing.Size(51, 17);
            this.RBLocal.TabIndex = 7;
            this.RBLocal.TabStop = true;
            this.RBLocal.Text = "Local";
            this.RBLocal.UseVisualStyleBackColor = true;
            this.RBLocal.Click += new System.EventHandler(this.RBLocal_Click);
            // 
            // RBRemote
            // 
            this.RBRemote.AutoSize = true;
            this.RBRemote.Location = new System.Drawing.Point(15, 113);
            this.RBRemote.Name = "RBRemote";
            this.RBRemote.Size = new System.Drawing.Size(62, 17);
            this.RBRemote.TabIndex = 8;
            this.RBRemote.Text = "Remote";
            this.RBRemote.UseVisualStyleBackColor = true;
            this.RBRemote.Click += new System.EventHandler(this.RBRemote_Click);
            // 
            // BClose
            // 
            this.BClose.Location = new System.Drawing.Point(101, 136);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(75, 23);
            this.BClose.TabIndex = 9;
            this.BClose.Text = "Close";
            this.BClose.UseVisualStyleBackColor = true;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // ConnectionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 181);
            this.Controls.Add(this.BClose);
            this.Controls.Add(this.RBRemote);
            this.Controls.Add(this.RBLocal);
            this.Controls.Add(this.BLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBPass);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.TBUser);
            this.Name = "ConnectionPage";
            this.Text = "ConnectionPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBUser;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.TextBox TBPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BLogin;
        private System.Windows.Forms.RadioButton RBLocal;
        private System.Windows.Forms.RadioButton RBRemote;
        private System.Windows.Forms.Button BClose;
    }
}