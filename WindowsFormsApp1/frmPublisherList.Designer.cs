namespace WindowsFormsApp1
{
    partial class frmPublisherList
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
            this.dgvPublisher = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublisher)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(134, 177);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 37);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "add publisher";
            this.btnAdd.UseVisualStyleBackColor = true;
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
            this.btnRmv.Location = new System.Drawing.Point(13, 177);
            this.btnRmv.Name = "btnRmv";
            this.btnRmv.Size = new System.Drawing.Size(115, 37);
            this.btnRmv.TabIndex = 14;
            this.btnRmv.Text = "remove publisher";
            this.btnRmv.UseVisualStyleBackColor = true;
            // 
            // dgvPublisher
            // 
            this.dgvPublisher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPublisher.Location = new System.Drawing.Point(12, 12);
            this.dgvPublisher.Name = "dgvPublisher";
            this.dgvPublisher.Size = new System.Drawing.Size(644, 150);
            this.dgvPublisher.TabIndex = 13;
            // 
            // frmPublisherList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRmv);
            this.Controls.Add(this.dgvPublisher);
            this.Name = "frmPublisherList";
            this.Text = "Publishers";
            this.Load += new System.EventHandler(this.frmPublisherList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublisher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRmv;
        private System.Windows.Forms.DataGridView dgvPublisher;
    }
}