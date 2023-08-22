namespace WindowsFormsApp1
{
    partial class frmCustomerList
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRmv = new System.Windows.Forms.Button();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.numBAge = new System.Windows.Forms.NumericUpDown();
            this.RBtnFemale = new System.Windows.Forms.RadioButton();
            this.RBtnMale = new System.Windows.Forms.RadioButton();
            this.txtBName = new System.Windows.Forms.TextBox();
            this.txtBFamily = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBAge)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(219, 411);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 37);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "add Customer";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(2, 416);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(86, 32);
            this.btnReturn.TabIndex = 15;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRmv
            // 
            this.btnRmv.Location = new System.Drawing.Point(98, 411);
            this.btnRmv.Name = "btnRmv";
            this.btnRmv.Size = new System.Drawing.Size(115, 37);
            this.btnRmv.TabIndex = 14;
            this.btnRmv.Text = "remove Customer";
            this.btnRmv.UseVisualStyleBackColor = true;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(12, 12);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.Size = new System.Drawing.Size(644, 150);
            this.dgvCustomer.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Gender: ";
            // 
            // numBAge
            // 
            this.numBAge.Location = new System.Drawing.Point(267, 178);
            this.numBAge.Name = "numBAge";
            this.numBAge.Size = new System.Drawing.Size(120, 20);
            this.numBAge.TabIndex = 31;
            // 
            // RBtnFemale
            // 
            this.RBtnFemale.AutoSize = true;
            this.RBtnFemale.Location = new System.Drawing.Point(119, 251);
            this.RBtnFemale.Name = "RBtnFemale";
            this.RBtnFemale.Size = new System.Drawing.Size(56, 17);
            this.RBtnFemale.TabIndex = 29;
            this.RBtnFemale.TabStop = true;
            this.RBtnFemale.Text = "female";
            this.RBtnFemale.UseVisualStyleBackColor = true;
            // 
            // RBtnMale
            // 
            this.RBtnMale.AutoSize = true;
            this.RBtnMale.Location = new System.Drawing.Point(65, 251);
            this.RBtnMale.Name = "RBtnMale";
            this.RBtnMale.Size = new System.Drawing.Size(48, 17);
            this.RBtnMale.TabIndex = 28;
            this.RBtnMale.TabStop = true;
            this.RBtnMale.Text = "Male";
            this.RBtnMale.UseVisualStyleBackColor = true;
            // 
            // txtBName
            // 
            this.txtBName.Location = new System.Drawing.Point(55, 177);
            this.txtBName.Name = "txtBName";
            this.txtBName.Size = new System.Drawing.Size(100, 20);
            this.txtBName.TabIndex = 27;
            // 
            // txtBFamily
            // 
            this.txtBFamily.Location = new System.Drawing.Point(55, 209);
            this.txtBFamily.Name = "txtBFamily";
            this.txtBFamily.Size = new System.Drawing.Size(100, 20);
            this.txtBFamily.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Age:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Family:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Name:";
            // 
            // frmCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numBAge);
            this.Controls.Add(this.RBtnFemale);
            this.Controls.Add(this.RBtnMale);
            this.Controls.Add(this.txtBName);
            this.Controls.Add(this.txtBFamily);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRmv);
            this.Controls.Add(this.dgvCustomer);
            this.Name = "frmCustomerList";
            this.Text = "frmCustomerList";
            this.Load += new System.EventHandler(this.frmCustomerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRmv;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numBAge;
        private System.Windows.Forms.RadioButton RBtnFemale;
        private System.Windows.Forms.RadioButton RBtnMale;
        private System.Windows.Forms.TextBox txtBName;
        private System.Windows.Forms.TextBox txtBFamily;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}