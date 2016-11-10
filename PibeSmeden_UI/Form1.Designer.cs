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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tilføj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(165, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(286, 88);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox4.Location = new System.Drawing.Point(43, 70);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(82, 13);
            this.textBox4.TabIndex = 7;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "Mærke";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.WordWrap = false;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox5.Location = new System.Drawing.Point(165, 70);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(82, 13);
            this.textBox5.TabIndex = 8;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "Type";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.WordWrap = false;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox6.Location = new System.Drawing.Point(286, 69);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(82, 13);
            this.textBox6.TabIndex = 9;
            this.textBox6.TabStop = false;
            this.textBox6.Text = "Pris";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox6.WordWrap = false;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(407, 88);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 10;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox8.Location = new System.Drawing.Point(407, 70);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(82, 13);
            this.textBox8.TabIndex = 11;
            this.textBox8.TabStop = false;
            this.textBox8.Text = "Styk/Vægt";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox8.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 281);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
    }
}

