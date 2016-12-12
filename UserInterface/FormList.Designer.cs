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
            this.InventoryListBox = new System.Windows.Forms.ListBox();
            this.IncButton = new System.Windows.Forms.Button();
            this.DecButton = new System.Windows.Forms.Button();
            this.IncTextBox = new System.Windows.Forms.TextBox();
            this.DecTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.showTobakBtn = new System.Windows.Forms.Button();
            this.showCigBtn = new System.Windows.Forms.Button();
            this.showElse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InventoryListBox
            // 
            this.InventoryListBox.FormattingEnabled = true;
            this.InventoryListBox.Location = new System.Drawing.Point(14, 42);
            this.InventoryListBox.Name = "InventoryListBox";
            this.InventoryListBox.Size = new System.Drawing.Size(303, 303);
            this.InventoryListBox.TabIndex = 1;
            // 
            // IncButton
            // 
            this.IncButton.Location = new System.Drawing.Point(323, 42);
            this.IncButton.Name = "IncButton";
            this.IncButton.Size = new System.Drawing.Size(103, 23);
            this.IncButton.TabIndex = 2;
            this.IncButton.Text = "Tilføj Til Antal";
            this.IncButton.UseVisualStyleBackColor = true;
            this.IncButton.Click += new System.EventHandler(this.IncButton_Click);
            // 
            // DecButton
            // 
            this.DecButton.Location = new System.Drawing.Point(323, 71);
            this.DecButton.Name = "DecButton";
            this.DecButton.Size = new System.Drawing.Size(103, 23);
            this.DecButton.TabIndex = 3;
            this.DecButton.Text = "Træk Fra Antal";
            this.DecButton.UseVisualStyleBackColor = true;
            this.DecButton.Click += new System.EventHandler(this.DecButton_Click);
            // 
            // IncTextBox
            // 
            this.IncTextBox.Location = new System.Drawing.Point(432, 44);
            this.IncTextBox.Name = "IncTextBox";
            this.IncTextBox.Size = new System.Drawing.Size(45, 20);
            this.IncTextBox.TabIndex = 4;
            // 
            // DecTextBox
            // 
            this.DecTextBox.Location = new System.Drawing.Point(432, 73);
            this.DecTextBox.Name = "DecTextBox";
            this.DecTextBox.Size = new System.Drawing.Size(45, 20);
            this.DecTextBox.TabIndex = 5;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(323, 322);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(102, 23);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Søg";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(323, 296);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(100, 20);
            this.SearchTextBox.TabIndex = 7;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // showTobakBtn
            // 
            this.showTobakBtn.Location = new System.Drawing.Point(14, 12);
            this.showTobakBtn.Name = "showTobakBtn";
            this.showTobakBtn.Size = new System.Drawing.Size(97, 23);
            this.showTobakBtn.TabIndex = 8;
            this.showTobakBtn.Text = "Vis Tobak";
            this.showTobakBtn.UseVisualStyleBackColor = true;
            // 
            // showCigBtn
            // 
            this.showCigBtn.Location = new System.Drawing.Point(117, 12);
            this.showCigBtn.Name = "showCigBtn";
            this.showCigBtn.Size = new System.Drawing.Size(97, 23);
            this.showCigBtn.TabIndex = 9;
            this.showCigBtn.Text = "Vis Cigaretter";
            this.showCigBtn.UseVisualStyleBackColor = true;
            // 
            // showElse
            // 
            this.showElse.Location = new System.Drawing.Point(220, 12);
            this.showElse.Name = "showElse";
            this.showElse.Size = new System.Drawing.Size(97, 23);
            this.showElse.TabIndex = 10;
            this.showElse.Text = "Vis Andet";
            this.showElse.UseVisualStyleBackColor = true;
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 357);
            this.Controls.Add(this.showElse);
            this.Controls.Add(this.showCigBtn);
            this.Controls.Add(this.showTobakBtn);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.DecTextBox);
            this.Controls.Add(this.IncTextBox);
            this.Controls.Add(this.DecButton);
            this.Controls.Add(this.IncButton);
            this.Controls.Add(this.InventoryListBox);
            this.Name = "FormList";
            this.Text = "FormList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox InventoryListBox;
        private System.Windows.Forms.Button IncButton;
        private System.Windows.Forms.Button DecButton;
        private System.Windows.Forms.TextBox IncTextBox;
        private System.Windows.Forms.TextBox DecTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button showTobakBtn;
        private System.Windows.Forms.Button showCigBtn;
        private System.Windows.Forms.Button showElse;
    }
}