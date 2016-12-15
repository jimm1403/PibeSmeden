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

            this.gridProductList = new System.Windows.Forms.DataGridView();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marketPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductList)).BeginInit();

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

            this.IncButton.Location = new System.Drawing.Point(661, 48);

            this.IncButton.Name = "IncButton";
            this.IncButton.Size = new System.Drawing.Size(103, 23);
            this.IncButton.TabIndex = 2;
            this.IncButton.Text = "Tilføj Til Antal";
            this.IncButton.UseVisualStyleBackColor = true;
            this.IncButton.Click += new System.EventHandler(this.IncButton_Click);
            // 
            // DecButton
            // 

            this.DecButton.Location = new System.Drawing.Point(661, 77);

            this.DecButton.Name = "DecButton";
            this.DecButton.Size = new System.Drawing.Size(103, 23);
            this.DecButton.TabIndex = 3;
            this.DecButton.Text = "Træk Fra Antal";
            this.DecButton.UseVisualStyleBackColor = true;
            this.DecButton.Click += new System.EventHandler(this.DecButton_Click);
            // 
            // IncTextBox
            // 

            this.IncTextBox.Location = new System.Drawing.Point(770, 50);

            this.IncTextBox.Name = "IncTextBox";
            this.IncTextBox.Size = new System.Drawing.Size(45, 20);
            this.IncTextBox.TabIndex = 4;
            // 
            // DecTextBox
            // 

            this.DecTextBox.Location = new System.Drawing.Point(770, 79);

            this.DecTextBox.Name = "DecTextBox";
            this.DecTextBox.Size = new System.Drawing.Size(45, 20);
            this.DecTextBox.TabIndex = 5;
            // 
            // SearchButton
            // 

            this.SearchButton.Location = new System.Drawing.Point(682, 274);

            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(110, 23);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Søg";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 

            this.SearchTextBox.Location = new System.Drawing.Point(662, 248);

            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(153, 20);
            this.SearchTextBox.TabIndex = 7;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 

            // gridProductList
            // 
            this.gridProductList.AllowUserToOrderColumns = true;
            this.gridProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.category,
            this.name,
            this.salesPrice,
            this.marketPrice,
            this.weight,
            this.amount});
            this.gridProductList.Location = new System.Drawing.Point(12, 4);
            this.gridProductList.Name = "gridProductList";
            this.gridProductList.Size = new System.Drawing.Size(644, 293);
            this.gridProductList.TabIndex = 8;
            // 
            // category
            // 
            this.category.HeaderText = "Kategori";
            this.category.Name = "category";
            // 
            // name
            // 
            this.name.HeaderText = "Navn";
            this.name.Name = "name";
            // 
            // salesPrice
            // 
            this.salesPrice.HeaderText = "Udsalgspris";
            this.salesPrice.Name = "salesPrice";
            // 
            // marketPrice
            // 
            this.marketPrice.HeaderText = "Indkøbspris";
            this.marketPrice.Name = "marketPrice";
            // 
            // weight
            // 
            this.weight.HeaderText = "Vægt";
            this.weight.Name = "weight";
            // 
            // amount
            // 
            this.amount.HeaderText = "Antal";
            this.amount.Name = "amount";

            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(822, 302);
            this.Controls.Add(this.gridProductList);

            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.DecTextBox);
            this.Controls.Add(this.IncTextBox);
            this.Controls.Add(this.DecButton);
            this.Controls.Add(this.IncButton);
            this.Controls.Add(this.InventoryListBox);
            this.Name = "FormList";
            this.Text = "FormList";
            ((System.ComponentModel.ISupportInitialize)(this.gridProductList)).EndInit();
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

        private System.Windows.Forms.DataGridView gridProductList;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn marketPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;

    }
}