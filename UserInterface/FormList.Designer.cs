namespace UserInterface
{
    partial class FormList
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
            this.button1 = new System.Windows.Forms.Button();
            this.InventoryListBox = new System.Windows.Forms.ListBox();
            this.IncButton = new System.Windows.Forms.Button();
            this.DecButton = new System.Windows.Forms.Button();
            this.IncTextBox = new System.Windows.Forms.TextBox();
            this.DecTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Vis Lager";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InventoryListBox
            // 
            this.InventoryListBox.FormattingEnabled = true;
            this.InventoryListBox.Location = new System.Drawing.Point(13, 43);
            this.InventoryListBox.Name = "InventoryListBox";
            this.InventoryListBox.Size = new System.Drawing.Size(259, 212);
            this.InventoryListBox.TabIndex = 1;
            // 
            // IncButton
            // 
            this.IncButton.Location = new System.Drawing.Point(278, 43);
            this.IncButton.Name = "IncButton";
            this.IncButton.Size = new System.Drawing.Size(103, 23);
            this.IncButton.TabIndex = 2;
            this.IncButton.Text = "Tilføj Til Antal";
            this.IncButton.UseVisualStyleBackColor = true;
            this.IncButton.Click += new System.EventHandler(this.IncButton_Click);
            // 
            // DecButton
            // 
            this.DecButton.Location = new System.Drawing.Point(278, 72);
            this.DecButton.Name = "DecButton";
            this.DecButton.Size = new System.Drawing.Size(103, 23);
            this.DecButton.TabIndex = 3;
            this.DecButton.Text = "Træk Fra Antal";
            this.DecButton.UseVisualStyleBackColor = true;
            this.DecButton.Click += new System.EventHandler(this.DecButton_Click);
            // 
            // IncTextBox
            // 
            this.IncTextBox.Location = new System.Drawing.Point(387, 45);
            this.IncTextBox.Name = "IncTextBox";
            this.IncTextBox.Size = new System.Drawing.Size(45, 20);
            this.IncTextBox.TabIndex = 4;
            // 
            // DecTextBox
            // 
            this.DecTextBox.Location = new System.Drawing.Point(387, 74);
            this.DecTextBox.Name = "DecTextBox";
            this.DecTextBox.Size = new System.Drawing.Size(45, 20);
            this.DecTextBox.TabIndex = 5;
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 261);
            this.Controls.Add(this.DecTextBox);
            this.Controls.Add(this.IncTextBox);
            this.Controls.Add(this.DecButton);
            this.Controls.Add(this.IncButton);
            this.Controls.Add(this.InventoryListBox);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(456, 300);
            this.MinimumSize = new System.Drawing.Size(456, 300);
            this.Name = "FormList";
            this.Text = "FormList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox InventoryListBox;
        private System.Windows.Forms.Button IncButton;
        private System.Windows.Forms.Button DecButton;
        private System.Windows.Forms.TextBox IncTextBox;
        private System.Windows.Forms.TextBox DecTextBox;
    }
}