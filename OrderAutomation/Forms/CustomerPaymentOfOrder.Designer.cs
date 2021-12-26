
namespace OrderAutomation.Forms
{
    partial class CustomerPaymentOfOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerPaymentOfOrder));
            this.cbxCash = new System.Windows.Forms.CheckBox();
            this.tbxCash = new System.Windows.Forms.TextBox();
            this.tbxCredit = new System.Windows.Forms.TextBox();
            this.cbxCredit = new System.Windows.Forms.CheckBox();
            this.tbxCheck = new System.Windows.Forms.TextBox();
            this.cbxCheck = new System.Windows.Forms.CheckBox();
            this.pbxGoBack = new System.Windows.Forms.PictureBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGoBack)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxCash
            // 
            this.cbxCash.AutoSize = true;
            this.cbxCash.Location = new System.Drawing.Point(48, 65);
            this.cbxCash.Name = "cbxCash";
            this.cbxCash.Size = new System.Drawing.Size(51, 17);
            this.cbxCash.TabIndex = 0;
            this.cbxCash.Text = "Nakit";
            this.cbxCash.UseVisualStyleBackColor = true;
            this.cbxCash.CheckedChanged += new System.EventHandler(this.cbxCash_CheckedChanged);
            // 
            // tbxCash
            // 
            this.tbxCash.Location = new System.Drawing.Point(143, 63);
            this.tbxCash.Name = "tbxCash";
            this.tbxCash.Size = new System.Drawing.Size(100, 20);
            this.tbxCash.TabIndex = 1;
            this.tbxCash.TextChanged += new System.EventHandler(this.tbxCash_TextChanged);
            this.tbxCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCash_KeyPress);
            // 
            // tbxCredit
            // 
            this.tbxCredit.Location = new System.Drawing.Point(143, 96);
            this.tbxCredit.Name = "tbxCredit";
            this.tbxCredit.Size = new System.Drawing.Size(100, 20);
            this.tbxCredit.TabIndex = 3;
            this.tbxCredit.TextChanged += new System.EventHandler(this.tbxCredit_TextChanged);
            this.tbxCredit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCredit_KeyPress);
            // 
            // cbxCredit
            // 
            this.cbxCredit.AutoSize = true;
            this.cbxCredit.Location = new System.Drawing.Point(48, 98);
            this.cbxCredit.Name = "cbxCredit";
            this.cbxCredit.Size = new System.Drawing.Size(73, 17);
            this.cbxCredit.TabIndex = 2;
            this.cbxCredit.Text = "Kredi kartı";
            this.cbxCredit.UseVisualStyleBackColor = true;
            this.cbxCredit.CheckedChanged += new System.EventHandler(this.cbxCredit_CheckedChanged);
            // 
            // tbxCheck
            // 
            this.tbxCheck.Location = new System.Drawing.Point(143, 129);
            this.tbxCheck.Name = "tbxCheck";
            this.tbxCheck.Size = new System.Drawing.Size(100, 20);
            this.tbxCheck.TabIndex = 5;
            this.tbxCheck.TextChanged += new System.EventHandler(this.tbxCheck_TextChanged);
            this.tbxCheck.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCheck_KeyPress);
            // 
            // cbxCheck
            // 
            this.cbxCheck.AutoSize = true;
            this.cbxCheck.Location = new System.Drawing.Point(48, 131);
            this.cbxCheck.Name = "cbxCheck";
            this.cbxCheck.Size = new System.Drawing.Size(45, 17);
            this.cbxCheck.TabIndex = 4;
            this.cbxCheck.Text = "Çek";
            this.cbxCheck.UseVisualStyleBackColor = true;
            this.cbxCheck.CheckedChanged += new System.EventHandler(this.cbxCheck_CheckedChanged);
            // 
            // pbxGoBack
            // 
            this.pbxGoBack.Image = ((System.Drawing.Image)(resources.GetObject("pbxGoBack.Image")));
            this.pbxGoBack.Location = new System.Drawing.Point(269, 11);
            this.pbxGoBack.Margin = new System.Windows.Forms.Padding(2);
            this.pbxGoBack.Name = "pbxGoBack";
            this.pbxGoBack.Size = new System.Drawing.Size(30, 33);
            this.pbxGoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxGoBack.TabIndex = 6;
            this.pbxGoBack.TabStop = false;
            this.pbxGoBack.Click += new System.EventHandler(this.pbxGoBack_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(191, 177);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(107, 23);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Ödemeyi tamamla";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // CustomerPaymentOfOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(310, 212);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.pbxGoBack);
            this.Controls.Add(this.tbxCheck);
            this.Controls.Add(this.cbxCheck);
            this.Controls.Add(this.tbxCredit);
            this.Controls.Add(this.cbxCredit);
            this.Controls.Add(this.tbxCash);
            this.Controls.Add(this.cbxCash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerPaymentOfOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerPaymentOfOrder";
            this.Load += new System.EventHandler(this.CustomerPaymentOfOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxGoBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxCash;
        private System.Windows.Forms.TextBox tbxCash;
        private System.Windows.Forms.TextBox tbxCredit;
        private System.Windows.Forms.CheckBox cbxCredit;
        private System.Windows.Forms.TextBox tbxCheck;
        private System.Windows.Forms.CheckBox cbxCheck;
        private System.Windows.Forms.PictureBox pbxGoBack;
        private System.Windows.Forms.Button btnConfirm;
    }
}