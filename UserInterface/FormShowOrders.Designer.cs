namespace UserInterface
{
    partial class FormShowOrders
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
            this.gridOrderList = new System.Windows.Forms.DataGridView();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marketPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderReceivedButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // gridOrderList
            // 
            this.gridOrderList.AllowUserToOrderColumns = true;
            this.gridOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.category,
            this.name,
            this.marketPrice});
            this.gridOrderList.Location = new System.Drawing.Point(12, 21);
            this.gridOrderList.Name = "gridOrderList";
            this.gridOrderList.Size = new System.Drawing.Size(345, 352);
            this.gridOrderList.TabIndex = 9;
            // 
            // category
            // 
            this.category.HeaderText = "Ordre id";
            this.category.Name = "category";
            // 
            // name
            // 
            this.name.HeaderText = "Ordre dato";
            this.name.Name = "name";
            // 
            // marketPrice
            // 
            this.marketPrice.HeaderText = "Status";
            this.marketPrice.Name = "marketPrice";
            // 
            // orderReceivedButton
            // 
            this.orderReceivedButton.Location = new System.Drawing.Point(364, 21);
            this.orderReceivedButton.Name = "orderReceivedButton";
            this.orderReceivedButton.Size = new System.Drawing.Size(75, 23);
            this.orderReceivedButton.TabIndex = 10;
            this.orderReceivedButton.Text = "Modtaget";
            this.orderReceivedButton.UseVisualStyleBackColor = true;
            this.orderReceivedButton.Click += new System.EventHandler(this.orderReceivedButton_Click);
            // 
            // FormShowOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 379);
            this.Controls.Add(this.orderReceivedButton);
            this.Controls.Add(this.gridOrderList);
            this.Name = "FormShowOrders";
            this.Text = "FormShowOrders";
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridOrderList;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn marketPrice;
        private System.Windows.Forms.Button orderReceivedButton;
    }
}