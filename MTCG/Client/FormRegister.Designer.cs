namespace Client
{
    partial class FormRegister
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lalEmail = new System.Windows.Forms.Label();
            this.lalPasswod = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lalName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(100, 286);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(232, 286);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 10;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(158, 130);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(162, 20);
            this.txtPassword.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(158, 62);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(162, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // lalEmail
            // 
            this.lalEmail.AutoSize = true;
            this.lalEmail.Location = new System.Drawing.Point(65, 62);
            this.lalEmail.Name = "lalEmail";
            this.lalEmail.Size = new System.Drawing.Size(35, 13);
            this.lalEmail.TabIndex = 7;
            this.lalEmail.Text = "E-mail";
            // 
            // lalPasswod
            // 
            this.lalPasswod.AutoSize = true;
            this.lalPasswod.Location = new System.Drawing.Point(65, 130);
            this.lalPasswod.Name = "lalPasswod";
            this.lalPasswod.Size = new System.Drawing.Size(50, 13);
            this.lalPasswod.TabIndex = 6;
            this.lalPasswod.Text = "Passwod";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(158, 194);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(162, 20);
            this.txtName.TabIndex = 13;
            // 
            // lalName
            // 
            this.lalName.AutoSize = true;
            this.lalName.Location = new System.Drawing.Point(65, 194);
            this.lalName.Name = "lalName";
            this.lalName.Size = new System.Drawing.Size(35, 13);
            this.lalName.TabIndex = 12;
            this.lalName.Text = "Name";
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 470);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lalName);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lalEmail);
            this.Controls.Add(this.lalPasswod);
            this.Name = "FormRegister";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lalEmail;
        private System.Windows.Forms.Label lalPasswod;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lalName;
    }
}