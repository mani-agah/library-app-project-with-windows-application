namespace WindowsFormsApp1
{
    partial class frmAuthors
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
            this.dgvAuthor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(134, 177);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 37);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "author";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(2, 416);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(86, 32);
            this.btnReturn.TabIndex = 19;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRmv
            // 
            this.btnRmv.Location = new System.Drawing.Point(13, 177);
            this.btnRmv.Name = "btnRmv";
            this.btnRmv.Size = new System.Drawing.Size(115, 37);
            this.btnRmv.TabIndex = 18;
            this.btnRmv.Text = "remove Author";
            this.btnRmv.UseVisualStyleBackColor = true;
            // 
            // dgvAuthor
            // 
            this.dgvAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthor.Location = new System.Drawing.Point(12, 12);
            this.dgvAuthor.Name = "dgvAuthor";
            this.dgvAuthor.Size = new System.Drawing.Size(644, 150);
            this.dgvAuthor.TabIndex = 17;
            // 
            // frmAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRmv);
            this.Controls.Add(this.dgvAuthor);
            this.Name = "frmAuthors";
            this.Text = "frmAuthors";
            this.Load += new System.EventHandler(this.frmAuthors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRmv;
        private System.Windows.Forms.DataGridView dgvAuthor;
    }
}