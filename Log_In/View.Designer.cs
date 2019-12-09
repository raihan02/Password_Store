namespace Log_In
{
    partial class View
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enterText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordShowButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(65, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Item";
            // 
            // comboBox
            // 
            this.comboBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(201, 175);
            this.comboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(180, 26);
            this.comboBox.TabIndex = 2;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(411, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // enterText
            // 
            this.enterText.Location = new System.Drawing.Point(528, 176);
            this.enterText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enterText.Name = "enterText";
            this.enterText.PasswordChar = '*';
            this.enterText.Size = new System.Drawing.Size(126, 25);
            this.enterText.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(547, 309);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password is here ";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // passwordShowButton
            // 
            this.passwordShowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.passwordShowButton.ForeColor = System.Drawing.Color.Blue;
            this.passwordShowButton.Location = new System.Drawing.Point(340, 341);
            this.passwordShowButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordShowButton.Name = "passwordShowButton";
            this.passwordShowButton.Size = new System.Drawing.Size(150, 62);
            this.passwordShowButton.TabIndex = 6;
            this.passwordShowButton.Text = "Show Password";
            this.passwordShowButton.UseVisualStyleBackColor = false;
            this.passwordShowButton.Click += new System.EventHandler(this.PinShowButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(65, 280);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter pin to show the password";
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(340, 280);
            this.text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text.Name = "text";
            this.text.PasswordChar = '*';
            this.text.Size = new System.Drawing.Size(148, 25);
            this.text.TabIndex = 8;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.backButton.ForeColor = System.Drawing.Color.Blue;
            this.backButton.Location = new System.Drawing.Point(340, 450);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(150, 62);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Home Page";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(772, 589);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordShowButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.enterText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View";
            this.Load += new System.EventHandler(this.View_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enterText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button passwordShowButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Button backButton;
    }
}