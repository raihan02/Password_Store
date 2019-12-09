namespace Log_In
{
    partial class ItemsAdd
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
            this.itemText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.itemPasswordText = new System.Windows.Forms.TextBox();
            this.itemSubmitButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name";
            // 
            // itemText
            // 
            this.itemText.Location = new System.Drawing.Point(439, 111);
            this.itemText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.itemText.Name = "itemText";
            this.itemText.Size = new System.Drawing.Size(217, 25);
            this.itemText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // itemPasswordText
            // 
            this.itemPasswordText.Location = new System.Drawing.Point(439, 182);
            this.itemPasswordText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.itemPasswordText.Name = "itemPasswordText";
            this.itemPasswordText.Size = new System.Drawing.Size(217, 25);
            this.itemPasswordText.TabIndex = 3;
            // 
            // itemSubmitButton
            // 
            this.itemSubmitButton.Location = new System.Drawing.Point(257, 260);
            this.itemSubmitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.itemSubmitButton.Name = "itemSubmitButton";
            this.itemSubmitButton.Size = new System.Drawing.Size(141, 56);
            this.itemSubmitButton.TabIndex = 4;
            this.itemSubmitButton.Text = "Submit";
            this.itemSubmitButton.UseVisualStyleBackColor = true;
            this.itemSubmitButton.Click += new System.EventHandler(this.ItemSubmitButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(481, 254);
            this.homeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(122, 62);
            this.homeButton.TabIndex = 5;
            this.homeButton.Text = "Home Page";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // ItemsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(840, 424);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.itemSubmitButton);
            this.Controls.Add(this.itemPasswordText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemText);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ItemsAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Items ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemPasswordText;
        private System.Windows.Forms.Button itemSubmitButton;
        private System.Windows.Forms.Button homeButton;
    }
}