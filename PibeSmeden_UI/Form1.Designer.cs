namespace PibeSmeden_UI
{
    partial class Form1
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
            this.ChooseProduct = new System.Windows.Forms.ComboBox();
            this.txtChooseProduct = new System.Windows.Forms.TextBox();
            this.txtChosenProduct = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChooseProduct
            // 
            this.ChooseProduct.AllowDrop = true;
            this.ChooseProduct.FormattingEnabled = true;
            this.ChooseProduct.ItemHeight = 13;
            this.ChooseProduct.Items.AddRange(new object[] {
            "Røg Tobak",
            "Cigaretter",
            "Rullepapir",
            "Filtre",
            "Cigar",
            "Tobak Pestiller"});
            this.ChooseProduct.Location = new System.Drawing.Point(196, 36);
            this.ChooseProduct.MaxDropDownItems = 6;
            this.ChooseProduct.Name = "ChooseProduct";
            this.ChooseProduct.Size = new System.Drawing.Size(126, 21);
            this.ChooseProduct.TabIndex = 0;
            this.ChooseProduct.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtChooseProduct
            // 
            this.txtChooseProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChooseProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtChooseProduct.Location = new System.Drawing.Point(196, 10);
            this.txtChooseProduct.Name = "txtChooseProduct";
            this.txtChooseProduct.ReadOnly = true;
            this.txtChooseProduct.Size = new System.Drawing.Size(126, 13);
            this.txtChooseProduct.TabIndex = 1;
            this.txtChooseProduct.TabStop = false;
            this.txtChooseProduct.Text = "Vælg Produkt";
            this.txtChooseProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtChooseProduct.WordWrap = false;
            this.txtChooseProduct.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtChosenProduct
            // 
            this.txtChosenProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChosenProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtChosenProduct.Location = new System.Drawing.Point(196, 63);
            this.txtChosenProduct.Name = "txtChosenProduct";
            this.txtChosenProduct.ReadOnly = true;
            this.txtChosenProduct.Size = new System.Drawing.Size(126, 13);
            this.txtChosenProduct.TabIndex = 2;
            this.txtChosenProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 281);
            this.Controls.Add(this.txtChosenProduct);
            this.Controls.Add(this.txtChooseProduct);
            this.Controls.Add(this.ChooseProduct);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(530, 320);
            this.MinimumSize = new System.Drawing.Size(530, 320);
            this.Name = "Form1";
            this.Text = "Storage Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ChooseProduct;
        private System.Windows.Forms.TextBox txtChooseProduct;
        private System.Windows.Forms.TextBox txtChosenProduct;
    }
}

