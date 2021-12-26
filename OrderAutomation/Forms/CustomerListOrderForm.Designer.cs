
namespace OrderAutomation.Forms
{
    partial class CustomerListOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerListOrderForm));
            this.dgwOrder = new System.Windows.Forms.DataGridView();
            this.btnToOrder = new System.Windows.Forms.Button();
            this.dgwOrderDetail = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwOrder
            // 
            this.dgwOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOrder.Location = new System.Drawing.Point(12, 12);
            this.dgwOrder.Name = "dgwOrder";
            this.dgwOrder.RowHeadersWidth = 62;
            this.dgwOrder.Size = new System.Drawing.Size(729, 198);
            this.dgwOrder.TabIndex = 0;
            this.dgwOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwOrder_CellClick);
            // 
            // btnToOrder
            // 
            this.btnToOrder.Location = new System.Drawing.Point(768, 45);
            this.btnToOrder.Name = "btnToOrder";
            this.btnToOrder.Size = new System.Drawing.Size(182, 73);
            this.btnToOrder.TabIndex = 1;
            this.btnToOrder.Text = "Yeni sipariş oluştur";
            this.btnToOrder.UseVisualStyleBackColor = true;
            this.btnToOrder.Click += new System.EventHandler(this.btnToOrder_Click);
            // 
            // dgwOrderDetail
            // 
            this.dgwOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOrderDetail.Location = new System.Drawing.Point(12, 240);
            this.dgwOrderDetail.Name = "dgwOrderDetail";
            this.dgwOrderDetail.RowHeadersWidth = 62;
            this.dgwOrderDetail.Size = new System.Drawing.Size(729, 198);
            this.dgwOrderDetail.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(973, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CustomerListOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1030, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgwOrderDetail);
            this.Controls.Add(this.btnToOrder);
            this.Controls.Add(this.dgwOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerListOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerListOrderForm";
            this.Load += new System.EventHandler(this.CustomerListOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwOrder;
        private System.Windows.Forms.Button btnToOrder;
        private System.Windows.Forms.DataGridView dgwOrderDetail;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}