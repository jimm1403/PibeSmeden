namespace UserInterface
{
    partial class FormAdd
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
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtBrandType = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtPieces = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblBrandType = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPieces = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboCategory
            // 
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Items.AddRange(new object[] {
            "Røg Tobak",
            "Cigaretter",
            "Rullepapir",
            "Filtre",
            "Cigar",
            "Tobak Pestiller"});
            this.comboCategory.Location = new System.Drawing.Point(11, 25);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(100, 21);
            this.comboCategory.TabIndex = 0;
            this.comboCategory.SelectedIndexChanged += new System.EventHandler(this.comboCategory_SelectedIndexChanged);
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(11, 69);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(100, 20);
            this.txtBrand.TabIndex = 1;
            this.txtBrand.TextChanged += new System.EventHandler(this.txtBrand_TextChanged);
            // 
            // txtBrandType
            // 
            this.txtBrandType.Location = new System.Drawing.Point(11, 111);
            this.txtBrandType.Name = "txtBrandType";
            this.txtBrandType.Size = new System.Drawing.Size(100, 20);
            this.txtBrandType.TabIndex = 2;
            this.txtBrandType.TextChanged += new System.EventHandler(this.txtBrandType_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(11, 150);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // txtPieces
            // 
            this.txtPieces.Location = new System.Drawing.Point(11, 193);
            this.txtPieces.Name = "txtPieces";
            this.txtPieces.Size = new System.Drawing.Size(100, 20);
            this.txtPieces.TabIndex = 4;
            this.txtPieces.TextChanged += new System.EventHandler(this.txtPieces_TextChanged);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(11, 236);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 5;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(11, 275);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 6;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(12, 9);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(46, 13);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "Kategori";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(12, 53);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(41, 13);
            this.lblBrand.TabIndex = 8;
            this.lblBrand.Text = "Mærke";
            // 
            // lblBrandType
            // 
            this.lblBrandType.AutoSize = true;
            this.lblBrandType.Location = new System.Drawing.Point(12, 95);
            this.lblBrandType.Name = "lblBrandType";
            this.lblBrandType.Size = new System.Drawing.Size(31, 13);
            this.lblBrandType.TabIndex = 9;
            this.lblBrandType.Text = "Type";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(12, 134);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(24, 13);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Pris";
            // 
            // lblPieces
            // 
            this.lblPieces.AutoSize = true;
            this.lblPieces.Location = new System.Drawing.Point(12, 177);
            this.lblPieces.Name = "lblPieces";
            this.lblPieces.Size = new System.Drawing.Size(28, 13);
            this.lblPieces.TabIndex = 11;
            this.lblPieces.Text = "Styk";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(12, 220);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(33, 13);
            this.lblWeight.TabIndex = 12;
            this.lblWeight.Text = "Vægt";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(12, 259);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(31, 13);
            this.lblAmount.TabIndex = 13;
            this.lblAmount.Text = "Antal";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(24, 301);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 14;
            this.btnAddItem.Text = "Tilføj";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(123, 333);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblPieces);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblBrandType);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtPieces);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtBrandType);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.comboCategory);
            this.Name = "FormAdd";
            this.Text = "FormAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtBrandType;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtPieces;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblBrandType;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPieces;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnAddItem;
    }
}