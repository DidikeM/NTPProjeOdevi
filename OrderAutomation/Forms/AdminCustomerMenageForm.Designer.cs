
namespace OrderAutomation.Forms
{
    partial class AdminCustomerMenageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCustomerMenageForm));
            this.dgwCustomer = new System.Windows.Forms.DataGridView();
            this.dgwOrder = new System.Windows.Forms.DataGridView();
            this.dgwOrderDetail = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwCustomer
            // 
            this.dgwCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCustomer.Location = new System.Drawing.Point(12, 68);
            this.dgwCustomer.Name = "dgwCustomer";
            this.dgwCustomer.RowHeadersWidth = 62;
            this.dgwCustomer.Size = new System.Drawing.Size(776, 154);
            this.dgwCustomer.TabIndex = 0;
            this.dgwCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCustomer_CellClick);
            // 
            // dgwOrder
            // 
            this.dgwOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOrder.Location = new System.Drawing.Point(12, 228);
            this.dgwOrder.Name = "dgwOrder";
            this.dgwOrder.RowHeadersWidth = 62;
            this.dgwOrder.Size = new System.Drawing.Size(776, 154);
            this.dgwOrder.TabIndex = 1;
            this.dgwOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwOrder_CellClick);
            // 
            // dgwOrderDetail
            // 
            this.dgwOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOrderDetail.Location = new System.Drawing.Point(12, 388);
            this.dgwOrderDetail.Name = "dgwOrderDetail";
            this.dgwOrderDetail.RowHeadersWidth = 62;
            this.dgwOrderDetail.Size = new System.Drawing.Size(776, 154);
            this.dgwOrderDetail.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(746, 11);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // AdminCustomerMenageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(797, 576);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.dgwOrderDetail);
            this.Controls.Add(this.dgwOrder);
            this.Controls.Add(this.dgwCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminCustomerMenageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminCustomerMenageForm";
            this.Load += new System.EventHandler(this.AdminCustomerMenageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCustomer;
        private System.Windows.Forms.DataGridView dgwOrder;
        private System.Windows.Forms.DataGridView dgwOrderDetail;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}