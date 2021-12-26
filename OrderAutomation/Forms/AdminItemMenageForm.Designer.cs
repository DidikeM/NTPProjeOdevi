
namespace OrderAutomation.Forms
{
    partial class AdminItemMenageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminItemMenageForm));
            this.dgwItem = new System.Windows.Forms.DataGridView();
            this.gbxItemAdd = new System.Windows.Forms.GroupBox();
            this.cbxAddTax = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxAddDescription = new System.Windows.Forms.TextBox();
            this.lblAddDescription = new System.Windows.Forms.Label();
            this.tbxAddPrice = new System.Windows.Forms.TextBox();
            this.lblAddPrice = new System.Windows.Forms.Label();
            this.lblAddTax = new System.Windows.Forms.Label();
            this.tbxAddShippingWeight = new System.Windows.Forms.TextBox();
            this.lblAddShippingWeight = new System.Windows.Forms.Label();
            this.tbxAddItemName = new System.Windows.Forms.TextBox();
            this.lblIAddItemName = new System.Windows.Forms.Label();
            this.gbxItemUpAndDel = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbxUpdateTax = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxUpdateDescription = new System.Windows.Forms.TextBox();
            this.lblUpdateDescription = new System.Windows.Forms.Label();
            this.tbxUpdatePrice = new System.Windows.Forms.TextBox();
            this.lblUpdatePrice = new System.Windows.Forms.Label();
            this.lblUpdateTax = new System.Windows.Forms.Label();
            this.tbxUpdateShippingWeight = new System.Windows.Forms.TextBox();
            this.lblUpdateShippingWeight = new System.Windows.Forms.Label();
            this.tbxUpdateItemName = new System.Windows.Forms.TextBox();
            this.lblUpdateItemName = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItem)).BeginInit();
            this.gbxItemAdd.SuspendLayout();
            this.gbxItemUpAndDel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwItem
            // 
            this.dgwItem.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgwItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwItem.Location = new System.Drawing.Point(21, 59);
            this.dgwItem.Name = "dgwItem";
            this.dgwItem.RowHeadersWidth = 62;
            this.dgwItem.Size = new System.Drawing.Size(776, 198);
            this.dgwItem.TabIndex = 0;
            this.dgwItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwItem_CellClick);
            // 
            // gbxItemAdd
            // 
            this.gbxItemAdd.Controls.Add(this.cbxAddTax);
            this.gbxItemAdd.Controls.Add(this.btnAdd);
            this.gbxItemAdd.Controls.Add(this.tbxAddDescription);
            this.gbxItemAdd.Controls.Add(this.lblAddDescription);
            this.gbxItemAdd.Controls.Add(this.tbxAddPrice);
            this.gbxItemAdd.Controls.Add(this.lblAddPrice);
            this.gbxItemAdd.Controls.Add(this.lblAddTax);
            this.gbxItemAdd.Controls.Add(this.tbxAddShippingWeight);
            this.gbxItemAdd.Controls.Add(this.lblAddShippingWeight);
            this.gbxItemAdd.Controls.Add(this.tbxAddItemName);
            this.gbxItemAdd.Controls.Add(this.lblIAddItemName);
            this.gbxItemAdd.Location = new System.Drawing.Point(21, 263);
            this.gbxItemAdd.Name = "gbxItemAdd";
            this.gbxItemAdd.Size = new System.Drawing.Size(344, 222);
            this.gbxItemAdd.TabIndex = 1;
            this.gbxItemAdd.TabStop = false;
            this.gbxItemAdd.Text = "Ürün Ekle";
            // 
            // cbxAddTax
            // 
            this.cbxAddTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.cbxAddTax.FormattingEnabled = true;
            this.cbxAddTax.Location = new System.Drawing.Point(128, 93);
            this.cbxAddTax.Name = "cbxAddTax";
            this.cbxAddTax.Size = new System.Drawing.Size(110, 21);
            this.cbxAddTax.TabIndex = 3;
            this.cbxAddTax.SelectedIndexChanged += new System.EventHandler(this.cbxAddTax_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdd.Location = new System.Drawing.Point(252, 167);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 49);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Ürün Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxAddDescription
            // 
            this.tbxAddDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.tbxAddDescription.Location = new System.Drawing.Point(128, 167);
            this.tbxAddDescription.Multiline = true;
            this.tbxAddDescription.Name = "tbxAddDescription";
            this.tbxAddDescription.Size = new System.Drawing.Size(110, 49);
            this.tbxAddDescription.TabIndex = 9;
            this.tbxAddDescription.TextChanged += new System.EventHandler(this.tbxAddDescription_TextChanged);
            // 
            // lblAddDescription
            // 
            this.lblAddDescription.AutoSize = true;
            this.lblAddDescription.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDescription.Location = new System.Drawing.Point(5, 170);
            this.lblAddDescription.Name = "lblAddDescription";
            this.lblAddDescription.Size = new System.Drawing.Size(106, 17);
            this.lblAddDescription.TabIndex = 8;
            this.lblAddDescription.Text = "Ürün Açıklaması";
            // 
            // tbxAddPrice
            // 
            this.tbxAddPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.tbxAddPrice.Location = new System.Drawing.Point(128, 129);
            this.tbxAddPrice.Name = "tbxAddPrice";
            this.tbxAddPrice.Size = new System.Drawing.Size(110, 20);
            this.tbxAddPrice.TabIndex = 7;
            this.tbxAddPrice.TextChanged += new System.EventHandler(this.tbxAddPrice_TextChanged);
            this.tbxAddPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAddPrice_KeyPress);
            // 
            // lblAddPrice
            // 
            this.lblAddPrice.AutoSize = true;
            this.lblAddPrice.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPrice.Location = new System.Drawing.Point(67, 129);
            this.lblAddPrice.Name = "lblAddPrice";
            this.lblAddPrice.Size = new System.Drawing.Size(37, 17);
            this.lblAddPrice.TabIndex = 6;
            this.lblAddPrice.Text = "Fiyat";
            // 
            // lblAddTax
            // 
            this.lblAddTax.AutoSize = true;
            this.lblAddTax.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTax.Location = new System.Drawing.Point(24, 96);
            this.lblAddTax.Name = "lblAddTax";
            this.lblAddTax.Size = new System.Drawing.Size(85, 17);
            this.lblAddTax.TabIndex = 4;
            this.lblAddTax.Text = "Vergi Miktarı";
            // 
            // tbxAddShippingWeight
            // 
            this.tbxAddShippingWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.tbxAddShippingWeight.Location = new System.Drawing.Point(128, 58);
            this.tbxAddShippingWeight.Name = "tbxAddShippingWeight";
            this.tbxAddShippingWeight.Size = new System.Drawing.Size(110, 20);
            this.tbxAddShippingWeight.TabIndex = 2;
            this.tbxAddShippingWeight.TextChanged += new System.EventHandler(this.tbxAddShippingWeight_TextChanged);
            this.tbxAddShippingWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAddShippingWeight_KeyPress);
            // 
            // lblAddShippingWeight
            // 
            this.lblAddShippingWeight.AutoSize = true;
            this.lblAddShippingWeight.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddShippingWeight.Location = new System.Drawing.Point(19, 61);
            this.lblAddShippingWeight.Name = "lblAddShippingWeight";
            this.lblAddShippingWeight.Size = new System.Drawing.Size(90, 17);
            this.lblAddShippingWeight.TabIndex = 2;
            this.lblAddShippingWeight.Text = "Kargo Ağırlığı";
            // 
            // tbxAddItemName
            // 
            this.tbxAddItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.tbxAddItemName.Location = new System.Drawing.Point(128, 23);
            this.tbxAddItemName.Name = "tbxAddItemName";
            this.tbxAddItemName.Size = new System.Drawing.Size(110, 20);
            this.tbxAddItemName.TabIndex = 1;
            this.tbxAddItemName.TextChanged += new System.EventHandler(this.tbxAddItemName_TextChanged);
            // 
            // lblIAddItemName
            // 
            this.lblIAddItemName.AutoSize = true;
            this.lblIAddItemName.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIAddItemName.Location = new System.Drawing.Point(42, 26);
            this.lblIAddItemName.Name = "lblIAddItemName";
            this.lblIAddItemName.Size = new System.Drawing.Size(62, 17);
            this.lblIAddItemName.TabIndex = 0;
            this.lblIAddItemName.Text = "Ürün Adı";
            // 
            // gbxItemUpAndDel
            // 
            this.gbxItemUpAndDel.Controls.Add(this.btnDelete);
            this.gbxItemUpAndDel.Controls.Add(this.cbxUpdateTax);
            this.gbxItemUpAndDel.Controls.Add(this.btnUpdate);
            this.gbxItemUpAndDel.Controls.Add(this.tbxUpdateDescription);
            this.gbxItemUpAndDel.Controls.Add(this.lblUpdateDescription);
            this.gbxItemUpAndDel.Controls.Add(this.tbxUpdatePrice);
            this.gbxItemUpAndDel.Controls.Add(this.lblUpdatePrice);
            this.gbxItemUpAndDel.Controls.Add(this.lblUpdateTax);
            this.gbxItemUpAndDel.Controls.Add(this.tbxUpdateShippingWeight);
            this.gbxItemUpAndDel.Controls.Add(this.lblUpdateShippingWeight);
            this.gbxItemUpAndDel.Controls.Add(this.tbxUpdateItemName);
            this.gbxItemUpAndDel.Controls.Add(this.lblUpdateItemName);
            this.gbxItemUpAndDel.Location = new System.Drawing.Point(453, 263);
            this.gbxItemUpAndDel.Name = "gbxItemUpAndDel";
            this.gbxItemUpAndDel.Size = new System.Drawing.Size(344, 222);
            this.gbxItemUpAndDel.TabIndex = 2;
            this.gbxItemUpAndDel.TabStop = false;
            this.gbxItemUpAndDel.Text = "Ürün Düzenle/Sil";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Location = new System.Drawing.Point(252, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 49);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Ürün\'ü Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbxUpdateTax
            // 
            this.cbxUpdateTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.cbxUpdateTax.FormattingEnabled = true;
            this.cbxUpdateTax.Location = new System.Drawing.Point(128, 93);
            this.cbxUpdateTax.Name = "cbxUpdateTax";
            this.cbxUpdateTax.Size = new System.Drawing.Size(110, 21);
            this.cbxUpdateTax.TabIndex = 3;
            this.cbxUpdateTax.SelectedIndexChanged += new System.EventHandler(this.cbxUpdateTax_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.Location = new System.Drawing.Point(252, 167);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 49);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Ürün\'ü Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxUpdateDescription
            // 
            this.tbxUpdateDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.tbxUpdateDescription.Location = new System.Drawing.Point(128, 167);
            this.tbxUpdateDescription.Multiline = true;
            this.tbxUpdateDescription.Name = "tbxUpdateDescription";
            this.tbxUpdateDescription.Size = new System.Drawing.Size(110, 49);
            this.tbxUpdateDescription.TabIndex = 9;
            this.tbxUpdateDescription.TextChanged += new System.EventHandler(this.tbxUpdateDescription_TextChanged);
            // 
            // lblUpdateDescription
            // 
            this.lblUpdateDescription.AutoSize = true;
            this.lblUpdateDescription.Location = new System.Drawing.Point(19, 170);
            this.lblUpdateDescription.Name = "lblUpdateDescription";
            this.lblUpdateDescription.Size = new System.Drawing.Size(83, 13);
            this.lblUpdateDescription.TabIndex = 8;
            this.lblUpdateDescription.Text = "Ürün Açıklaması";
            // 
            // tbxUpdatePrice
            // 
            this.tbxUpdatePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.tbxUpdatePrice.Location = new System.Drawing.Point(128, 129);
            this.tbxUpdatePrice.Name = "tbxUpdatePrice";
            this.tbxUpdatePrice.Size = new System.Drawing.Size(110, 20);
            this.tbxUpdatePrice.TabIndex = 7;
            this.tbxUpdatePrice.TextChanged += new System.EventHandler(this.tbxUpdatePrice_TextChanged);
            this.tbxUpdatePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUpdatePrice_KeyPress);
            // 
            // lblUpdatePrice
            // 
            this.lblUpdatePrice.AutoSize = true;
            this.lblUpdatePrice.Location = new System.Drawing.Point(19, 132);
            this.lblUpdatePrice.Name = "lblUpdatePrice";
            this.lblUpdatePrice.Size = new System.Drawing.Size(29, 13);
            this.lblUpdatePrice.TabIndex = 6;
            this.lblUpdatePrice.Text = "Fiyat";
            // 
            // lblUpdateTax
            // 
            this.lblUpdateTax.AutoSize = true;
            this.lblUpdateTax.Location = new System.Drawing.Point(19, 96);
            this.lblUpdateTax.Name = "lblUpdateTax";
            this.lblUpdateTax.Size = new System.Drawing.Size(65, 13);
            this.lblUpdateTax.TabIndex = 4;
            this.lblUpdateTax.Text = "Vergi Miktarı";
            // 
            // tbxUpdateShippingWeight
            // 
            this.tbxUpdateShippingWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.tbxUpdateShippingWeight.Location = new System.Drawing.Point(128, 58);
            this.tbxUpdateShippingWeight.Name = "tbxUpdateShippingWeight";
            this.tbxUpdateShippingWeight.Size = new System.Drawing.Size(110, 20);
            this.tbxUpdateShippingWeight.TabIndex = 2;
            this.tbxUpdateShippingWeight.TextChanged += new System.EventHandler(this.tbxUpdateShippingWeight_TextChanged);
            this.tbxUpdateShippingWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUpdateShippingWeight_KeyPress);
            // 
            // lblUpdateShippingWeight
            // 
            this.lblUpdateShippingWeight.AutoSize = true;
            this.lblUpdateShippingWeight.Location = new System.Drawing.Point(19, 61);
            this.lblUpdateShippingWeight.Name = "lblUpdateShippingWeight";
            this.lblUpdateShippingWeight.Size = new System.Drawing.Size(68, 13);
            this.lblUpdateShippingWeight.TabIndex = 2;
            this.lblUpdateShippingWeight.Text = "Kargo Ağırlığı";
            // 
            // tbxUpdateItemName
            // 
            this.tbxUpdateItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.tbxUpdateItemName.Location = new System.Drawing.Point(128, 23);
            this.tbxUpdateItemName.Name = "tbxUpdateItemName";
            this.tbxUpdateItemName.Size = new System.Drawing.Size(110, 20);
            this.tbxUpdateItemName.TabIndex = 1;
            this.tbxUpdateItemName.TextChanged += new System.EventHandler(this.tbxUpdateItemName_TextChanged);
            // 
            // lblUpdateItemName
            // 
            this.lblUpdateItemName.AutoSize = true;
            this.lblUpdateItemName.Location = new System.Drawing.Point(19, 26);
            this.lblUpdateItemName.Name = "lblUpdateItemName";
            this.lblUpdateItemName.Size = new System.Drawing.Size(48, 13);
            this.lblUpdateItemName.TabIndex = 0;
            this.lblUpdateItemName.Text = "Ürün Adı";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(757, 11);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // AdminItemMenageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(809, 513);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.gbxItemUpAndDel);
            this.Controls.Add(this.gbxItemAdd);
            this.Controls.Add(this.dgwItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminItemMenageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminİtemMenageForm";
            this.Load += new System.EventHandler(this.AdminİtemMenageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwItem)).EndInit();
            this.gbxItemAdd.ResumeLayout(false);
            this.gbxItemAdd.PerformLayout();
            this.gbxItemUpAndDel.ResumeLayout(false);
            this.gbxItemUpAndDel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwItem;
        private System.Windows.Forms.GroupBox gbxItemAdd;
        private System.Windows.Forms.TextBox tbxAddItemName;
        private System.Windows.Forms.Label lblIAddItemName;
        private System.Windows.Forms.TextBox tbxAddDescription;
        private System.Windows.Forms.Label lblAddDescription;
        private System.Windows.Forms.TextBox tbxAddPrice;
        private System.Windows.Forms.Label lblAddPrice;
        private System.Windows.Forms.ComboBox cbxAddTax;
        private System.Windows.Forms.Label lblAddTax;
        private System.Windows.Forms.TextBox tbxAddShippingWeight;
        private System.Windows.Forms.Label lblAddShippingWeight;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxItemUpAndDel;
        private System.Windows.Forms.ComboBox cbxUpdateTax;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxUpdateDescription;
        private System.Windows.Forms.Label lblUpdateDescription;
        private System.Windows.Forms.TextBox tbxUpdatePrice;
        private System.Windows.Forms.Label lblUpdatePrice;
        private System.Windows.Forms.Label lblUpdateTax;
        private System.Windows.Forms.TextBox tbxUpdateShippingWeight;
        private System.Windows.Forms.Label lblUpdateShippingWeight;
        private System.Windows.Forms.TextBox tbxUpdateItemName;
        private System.Windows.Forms.Label lblUpdateItemName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}