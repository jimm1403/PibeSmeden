namespace UserInterface
{
    partial class FormNewOrder
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
            this.addToOrderBtn = new System.Windows.Forms.Button();
            this.orderLineQuantityLabel = new System.Windows.Forms.Label();
            this.orderLineQuantityTxtBox = new System.Windows.Forms.TextBox();
            this.chooseOrderProductLabel = new System.Windows.Forms.Label();
            this.orderDateTxtBox = new System.Windows.Forms.TextBox();
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.orderDateLabel2 = new System.Windows.Forms.Label();
            this.productSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addToOrderBtn
            // 
            this.addToOrderBtn.Location = new System.Drawing.Point(211, 115);
            this.addToOrderBtn.Name = "addToOrderBtn";
            this.addToOrderBtn.Size = new System.Drawing.Size(135, 42);
            this.addToOrderBtn.TabIndex = 0;
            this.addToOrderBtn.Text = "Tilføj produkt til ordre";
            this.addToOrderBtn.UseVisualStyleBackColor = true;
            this.addToOrderBtn.Click += new System.EventHandler(this.addToOrderBtn_Click);
            // 
            // orderLineQuantityLabel
            // 
            this.orderLineQuantityLabel.AutoSize = true;
            this.orderLineQuantityLabel.Location = new System.Drawing.Point(208, 73);
            this.orderLineQuantityLabel.Name = "orderLineQuantityLabel";
            this.orderLineQuantityLabel.Size = new System.Drawing.Size(111, 13);
            this.orderLineQuantityLabel.TabIndex = 1;
            this.orderLineQuantityLabel.Text = "Antal der skal bestilles";
            // 
            // orderLineQuantityTxtBox
            // 
            this.orderLineQuantityTxtBox.Location = new System.Drawing.Point(211, 89);
            this.orderLineQuantityTxtBox.Name = "orderLineQuantityTxtBox";
            this.orderLineQuantityTxtBox.Size = new System.Drawing.Size(100, 20);
            this.orderLineQuantityTxtBox.TabIndex = 2;
            // 
            // chooseOrderProductLabel
            // 
            this.chooseOrderProductLabel.AutoSize = true;
            this.chooseOrderProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseOrderProductLabel.Location = new System.Drawing.Point(207, 31);
            this.chooseOrderProductLabel.Name = "chooseOrderProductLabel";
            this.chooseOrderProductLabel.Size = new System.Drawing.Size(151, 13);
            this.chooseOrderProductLabel.TabIndex = 3;
            this.chooseOrderProductLabel.Text = "Vælg produkt der skal bestilles";
            // 
            // orderDateTxtBox
            // 
            this.orderDateTxtBox.Location = new System.Drawing.Point(15, 60);
            this.orderDateTxtBox.Name = "orderDateTxtBox";
            this.orderDateTxtBox.Size = new System.Drawing.Size(100, 20);
            this.orderDateTxtBox.TabIndex = 11;
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Location = new System.Drawing.Point(12, 31);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(157, 13);
            this.orderDateLabel.TabIndex = 12;
            this.orderDateLabel.Text = "Hvilken dato er ordren oprettet?";
            // 
            // orderDateLabel2
            // 
            this.orderDateLabel2.AutoSize = true;
            this.orderDateLabel2.Location = new System.Drawing.Point(12, 44);
            this.orderDateLabel2.Name = "orderDateLabel2";
            this.orderDateLabel2.Size = new System.Drawing.Size(61, 13);
            this.orderDateLabel2.TabIndex = 13;
            this.orderDateLabel2.Text = "mm-dd-yyyy";
            // 
            // productSelectionComboBox
            // 
            this.productSelectionComboBox.FormattingEnabled = true;
            this.productSelectionComboBox.Location = new System.Drawing.Point(210, 49);
            this.productSelectionComboBox.Name = "productSelectionComboBox";
            this.productSelectionComboBox.Size = new System.Drawing.Size(121, 21);
            this.productSelectionComboBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Opret en ny ordre eller tilføj til en allerede eksisterende.";
            // 
            // newOrderButton
            // 
            this.newOrderButton.Location = new System.Drawing.Point(15, 115);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(135, 42);
            this.newOrderButton.TabIndex = 18;
            this.newOrderButton.Text = "Opret ny ordre";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // FormNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 168);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productSelectionComboBox);
            this.Controls.Add(this.orderDateLabel2);
            this.Controls.Add(this.orderDateLabel);
            this.Controls.Add(this.orderDateTxtBox);
            this.Controls.Add(this.chooseOrderProductLabel);
            this.Controls.Add(this.orderLineQuantityTxtBox);
            this.Controls.Add(this.orderLineQuantityLabel);
            this.Controls.Add(this.addToOrderBtn);
            this.Name = "FormNewOrder";
            this.Text = "FormOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addToOrderBtn;
        private System.Windows.Forms.Label orderLineQuantityLabel;
        private System.Windows.Forms.TextBox orderLineQuantityTxtBox;
        private System.Windows.Forms.Label chooseOrderProductLabel;
        private System.Windows.Forms.TextBox orderDateTxtBox;
        private System.Windows.Forms.Label orderDateLabel;
        private System.Windows.Forms.Label orderDateLabel2;
        private System.Windows.Forms.ComboBox productSelectionComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newOrderButton;
    }
}