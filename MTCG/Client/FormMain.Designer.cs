namespace Client
{
    partial class FormMain
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
            this.lalName = new System.Windows.Forms.Label();
            this.lalGold = new System.Windows.Forms.Label();
            this.lalToken = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDeck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lalName
            // 
            this.lalName.AutoSize = true;
            this.lalName.Location = new System.Drawing.Point(170, 126);
            this.lalName.Name = "lalName";
            this.lalName.Size = new System.Drawing.Size(35, 13);
            this.lalName.TabIndex = 0;
            this.lalName.Text = "label1";
            // 
            // lalGold
            // 
            this.lalGold.AutoSize = true;
            this.lalGold.Location = new System.Drawing.Point(170, 187);
            this.lalGold.Name = "lalGold";
            this.lalGold.Size = new System.Drawing.Size(35, 13);
            this.lalGold.TabIndex = 1;
            this.lalGold.Text = "label2";
            // 
            // lalToken
            // 
            this.lalToken.AutoSize = true;
            this.lalToken.Location = new System.Drawing.Point(170, 252);
            this.lalToken.Name = "lalToken";
            this.lalToken.Size = new System.Drawing.Size(35, 13);
            this.lalToken.TabIndex = 2;
            this.lalToken.Text = "label3";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(200, 315);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDeck
            // 
            this.btnDeck.Location = new System.Drawing.Point(441, 315);
            this.btnDeck.Name = "btnDeck";
            this.btnDeck.Size = new System.Drawing.Size(75, 23);
            this.btnDeck.TabIndex = 4;
            this.btnDeck.Text = "Deck";
            this.btnDeck.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeck);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lalToken);
            this.Controls.Add(this.lalGold);
            this.Controls.Add(this.lalName);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lalName;
        private System.Windows.Forms.Label lalGold;
        private System.Windows.Forms.Label lalToken;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDeck;
    }
}