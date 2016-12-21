namespace UserInterface
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.lblLastAction = new System.Windows.Forms.Label();
            this.btnRecieve = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.newOrderBtn = new System.Windows.Forms.Button();
            this.showOrdersBtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 178);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Tilføj Vare";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(12, 33);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(128, 30);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "Vis Lager";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // lblLastAction
            // 
            this.lblLastAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastAction.Location = new System.Drawing.Point(0, 9);
            this.lblLastAction.Name = "lblLastAction";
            this.lblLastAction.Size = new System.Drawing.Size(152, 13);
            this.lblLastAction.TabIndex = 2;
            this.lblLastAction.Text = "Velkommen";
            this.lblLastAction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRecieve
            // 
            this.btnRecieve.Location = new System.Drawing.Point(12, 142);
            this.btnRecieve.Name = "btnRecieve";
            this.btnRecieve.Size = new System.Drawing.Size(128, 30);
            this.btnRecieve.TabIndex = 3;
            this.btnRecieve.Text = "Varemodtagelse";
            this.btnRecieve.UseVisualStyleBackColor = true;
            this.btnRecieve.Click += new System.EventHandler(this.btnRecieve_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 214);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(128, 30);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Fjern Vare";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // newOrderBtn
            // 
            this.newOrderBtn.Location = new System.Drawing.Point(13, 70);
            this.newOrderBtn.Name = "newOrderBtn";
            this.newOrderBtn.Size = new System.Drawing.Size(127, 30);
            this.newOrderBtn.TabIndex = 5;
            this.newOrderBtn.Text = "Ny ordre";
            this.newOrderBtn.UseVisualStyleBackColor = true;
            this.newOrderBtn.Click += new System.EventHandler(this.newOrderBtn_Click);
            // 
            // showOrdersBtn
            // 
            this.showOrdersBtn.Location = new System.Drawing.Point(13, 106);
            this.showOrdersBtn.Name = "showOrdersBtn";
            this.showOrdersBtn.Size = new System.Drawing.Size(127, 30);
            this.showOrdersBtn.TabIndex = 6;
            this.showOrdersBtn.Text = "Vis ordrer";
            this.showOrdersBtn.UseVisualStyleBackColor = true;
            this.showOrdersBtn.Click += new System.EventHandler(this.showOrdersBtn_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(13, 250);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(128, 30);
            this.LogOutBtn.TabIndex = 7;
            this.LogOutBtn.Text = "Log af";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(152, 289);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.showOrdersBtn);
            this.Controls.Add(this.newOrderBtn);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnRecieve);
            this.Controls.Add(this.lblLastAction);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label lblLastAction;
        private System.Windows.Forms.Button btnRecieve;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button newOrderBtn;
        private System.Windows.Forms.Button showOrdersBtn;
        private System.Windows.Forms.Button LogOutBtn;
    }
}

