namespace WindowsFormsApp1
{
    partial class frmPanel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBooksList = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCustomersList = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPublishersList = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAuthorsList = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Users";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(0, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(238, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Users List";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBooksList);
            this.groupBox2.Location = new System.Drawing.Point(550, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 183);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Books";
            // 
            // btnBooksList
            // 
            this.btnBooksList.BackColor = System.Drawing.Color.Transparent;
            this.btnBooksList.Location = new System.Drawing.Point(0, 160);
            this.btnBooksList.Name = "btnBooksList";
            this.btnBooksList.Size = new System.Drawing.Size(238, 23);
            this.btnBooksList.TabIndex = 0;
            this.btnBooksList.Text = "Books List";
            this.btnBooksList.UseVisualStyleBackColor = false;
            this.btnBooksList.Click += new System.EventHandler(this.btnBooksList_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCustomersList);
            this.groupBox3.Location = new System.Drawing.Point(550, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 183);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customers";
            // 
            // btnCustomersList
            // 
            this.btnCustomersList.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomersList.Location = new System.Drawing.Point(0, 160);
            this.btnCustomersList.Name = "btnCustomersList";
            this.btnCustomersList.Size = new System.Drawing.Size(238, 23);
            this.btnCustomersList.TabIndex = 1;
            this.btnCustomersList.Text = "Customers List";
            this.btnCustomersList.UseVisualStyleBackColor = false;
            this.btnCustomersList.Click += new System.EventHandler(this.btnCustomersList_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnPublishersList);
            this.groupBox4.Location = new System.Drawing.Point(12, 211);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(238, 183);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Publishers";
            // 
            // btnPublishersList
            // 
            this.btnPublishersList.BackColor = System.Drawing.Color.Transparent;
            this.btnPublishersList.Location = new System.Drawing.Point(0, 160);
            this.btnPublishersList.Name = "btnPublishersList";
            this.btnPublishersList.Size = new System.Drawing.Size(238, 23);
            this.btnPublishersList.TabIndex = 1;
            this.btnPublishersList.Text = "Publishers List";
            this.btnPublishersList.UseVisualStyleBackColor = false;
            this.btnPublishersList.Click += new System.EventHandler(this.btnPublishersList_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnAuthorsList);
            this.groupBox5.Location = new System.Drawing.Point(281, 148);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(238, 183);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Authors";
            // 
            // btnAuthorsList
            // 
            this.btnAuthorsList.BackColor = System.Drawing.Color.Transparent;
            this.btnAuthorsList.Location = new System.Drawing.Point(0, 160);
            this.btnAuthorsList.Name = "btnAuthorsList";
            this.btnAuthorsList.Size = new System.Drawing.Size(238, 23);
            this.btnAuthorsList.TabIndex = 3;
            this.btnAuthorsList.Text = "Authors List";
            this.btnAuthorsList.UseVisualStyleBackColor = false;
            this.btnAuthorsList.Click += new System.EventHandler(this.btnAuthorsList_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(0, 418);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(86, 32);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPanel";
            this.Text = "Panel";
            this.Load += new System.EventHandler(this.frmPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBooksList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCustomersList;
        private System.Windows.Forms.Button btnPublishersList;
        private System.Windows.Forms.Button btnAuthorsList;
        private System.Windows.Forms.Button btnReturn;
    }
}