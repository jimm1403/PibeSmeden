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
            this.label1 = new System.Windows.Forms.Label();
            this.orderLineListBox = new System.Windows.Forms.ListBox();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Denne ordre indeholder";
            // 
            // orderLineListBox
            // 
            this.orderLineListBox.FormattingEnabled = true;
            this.orderLineListBox.Location = new System.Drawing.Point(367, 70);
            this.orderLineListBox.Name = "orderLineListBox";
            this.orderLineListBox.Size = new System.Drawing.Size(120, 95);
            this.orderLineListBox.TabIndex = 11;
            // 
            // FormShowOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 385);
            this.Controls.Add(this.orderLineListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridOrderList);
            this.Name = "FormShowOrders";
            this.Text = "FormShowOrders";
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridOrderList;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn marketPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox orderLineListBox;
    }
}