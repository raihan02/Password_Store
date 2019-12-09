namespace Log_In
{
    partial class Pin
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
            this.pinText = new System.Windows.Forms.TextBox();
            this.pinSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(78, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Pin";
            // 
            // pinText
            // 
            this.pinText.Location = new System.Drawing.Point(180, 63);
            this.pinText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pinText.Name = "pinText";
            this.pinText.PasswordChar = '*';
            this.pinText.Size = new System.Drawing.Size(148, 25);
            this.pinText.TabIndex = 1;
            // 
            // pinSubmit
            // 
            this.pinSubmit.BackColor = System.Drawing.Color.Lime;
            this.pinSubmit.Location = new System.Drawing.Point(138, 144);
            this.pinSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pinSubmit.Name = "pinSubmit";
            this.pinSubmit.Size = new System.Drawing.Size(132, 52);
            this.pinSubmit.TabIndex = 2;
            this.pinSubmit.Text = "Submit";
            this.pinSubmit.UseVisualStyleBackColor = false;
            this.pinSubmit.Click += new System.EventHandler(this.PinSubmit_Click);
            // 
            // Pin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(355, 239);
            this.Controls.Add(this.pinSubmit);
            this.Controls.Add(this.pinText);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Pin";
            this.Text = "Pin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pinText;
        private System.Windows.Forms.Button pinSubmit;
    }
}