namespace WindowsFormsApp1
{
    partial class frmUserList
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
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.btnRmv = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBFamily = new System.Windows.Forms.TextBox();
            this.txtBName = new System.Windows.Forms.TextBox();
            this.RBtnMale = new System.Windows.Forms.RadioButton();
            this.RBtnFemale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.numBAge = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.numID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBAge)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(12, 12);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.Size = new System.Drawing.Size(644, 150);
            this.dgvUser.TabIndex = 0;
            this.dgvUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnRmv
            // 
            this.btnRmv.Location = new System.Drawing.Point(94, 411);
            this.btnRmv.Name = "btnRmv";
            this.btnRmv.Size = new System.Drawing.Size(115, 37);
            this.btnRmv.TabIndex = 3;
            this.btnRmv.Text = "remove user";
            this.btnRmv.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(2, 416);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(86, 32);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(215, 411);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 37);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "add user";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Family:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Age:";
            // 
            // txtBFamily
            // 
            this.txtBFamily.Location = new System.Drawing.Point(56, 234);
            this.txtBFamily.Name = "txtBFamily";
            this.txtBFamily.Size = new System.Drawing.Size(100, 20);
            this.txtBFamily.TabIndex = 13;
            // 
            // txtBName
            // 
            this.txtBName.Location = new System.Drawing.Point(56, 202);
            this.txtBName.Name = "txtBName";
            this.txtBName.Size = new System.Drawing.Size(100, 20);
            this.txtBName.TabIndex = 14;
            // 
            // RBtnMale
            // 
            this.RBtnMale.AutoSize = true;
            this.RBtnMale.Location = new System.Drawing.Point(66, 276);
            this.RBtnMale.Name = "RBtnMale";
            this.RBtnMale.Size = new System.Drawing.Size(48, 17);
            this.RBtnMale.TabIndex = 15;
            this.RBtnMale.TabStop = true;
            this.RBtnMale.Text = "Male";
            this.RBtnMale.UseVisualStyleBackColor = true;
            // 
            // RBtnFemale
            // 
            this.RBtnFemale.AutoSize = true;
            this.RBtnFemale.Location = new System.Drawing.Point(120, 276);
            this.RBtnFemale.Name = "RBtnFemale";
            this.RBtnFemale.Size = new System.Drawing.Size(56, 17);
            this.RBtnFemale.TabIndex = 16;
            this.RBtnFemale.TabStop = true;
            this.RBtnFemale.Text = "female";
            this.RBtnFemale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "National ID:";
            // 
            // numBAge
            // 
            this.numBAge.Location = new System.Drawing.Point(268, 203);
            this.numBAge.Name = "numBAge";
            this.numBAge.Size = new System.Drawing.Size(120, 20);
            this.numBAge.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Gender: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(495, 203);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 21;
            // 
            // numID
            // 
            this.numID.Location = new System.Drawing.Point(268, 238);
            this.numID.Name = "numID";
            this.numID.Size = new System.Drawing.Size(120, 20);
            this.numID.TabIndex = 22;
            // 
            // frmUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.Controls.Add(this.numID);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numBAge);
            this.Controls.Add(this.label4);
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
            this.Controls.Add(this.dgvUser);
            this.Name = "frmUserList";
            this.Text = "frmUserList";
            this.Load += new System.EventHandler(this.frmUserList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Button btnRmv;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBFamily;
        private System.Windows.Forms.TextBox txtBName;
        private System.Windows.Forms.RadioButton RBtnMale;
        private System.Windows.Forms.RadioButton RBtnFemale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numBAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox numID;
    }
}