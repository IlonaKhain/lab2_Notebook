namespace lab_Notebook
{
    partial class ForAddRow
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbSurName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbBirth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(104, 48);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 20);
            this.txbName.TabIndex = 2;
            this.txbName.Text = "John";
            // 
            // txbSurName
            // 
            this.txbSurName.Location = new System.Drawing.Point(104, 75);
            this.txbSurName.Name = "txbSurName";
            this.txbSurName.Size = new System.Drawing.Size(100, 20);
            this.txbSurName.TabIndex = 4;
            this.txbSurName.Text = "Smith";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "SurName";
            // 
            // txbCity
            // 
            this.txbCity.Location = new System.Drawing.Point(104, 97);
            this.txbCity.Name = "txbCity";
            this.txbCity.Size = new System.Drawing.Size(100, 20);
            this.txbCity.TabIndex = 6;
            this.txbCity.Text = "Madrid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "City";
            // 
            // txbPhone
            // 
            this.txbPhone.Location = new System.Drawing.Point(104, 123);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(100, 20);
            this.txbPhone.TabIndex = 8;
            this.txbPhone.Text = "201000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "PhoneNumber";
            // 
            // txbBirth
            // 
            this.txbBirth.Location = new System.Drawing.Point(104, 145);
            this.txbBirth.Name = "txbBirth";
            this.txbBirth.Size = new System.Drawing.Size(100, 20);
            this.txbBirth.TabIndex = 10;
            this.txbBirth.Text = "24-05-1996";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "BirthDate";
            // 
            // ForAddRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txbBirth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbSurName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "ForAddRow";
            this.Text = "ForAddRow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ForAddRow_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txbName;
        public System.Windows.Forms.TextBox txbSurName;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txbCity;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txbBirth;
        private System.Windows.Forms.Label label5;
    }
}