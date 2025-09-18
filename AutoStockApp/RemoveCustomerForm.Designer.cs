
namespace AutoStockApp
{
    partial class frm_RemoveCustomerForm
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
            this.txt_RemoveCustomerLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_RemoveCustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgw_RemoveCustomer = new System.Windows.Forms.DataGridView();
            this.btn_DeleteCustomer = new System.Windows.Forms.Button();
            this.txt_RemoveCustomerId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_RemoveCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_RemoveCustomerLastName
            // 
            this.txt_RemoveCustomerLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_RemoveCustomerLastName.Location = new System.Drawing.Point(540, 45);
            this.txt_RemoveCustomerLastName.Name = "txt_RemoveCustomerLastName";
            this.txt_RemoveCustomerLastName.Size = new System.Drawing.Size(217, 30);
            this.txt_RemoveCustomerLastName.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(459, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Soyad:";
            // 
            // txt_RemoveCustomerName
            // 
            this.txt_RemoveCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_RemoveCustomerName.Location = new System.Drawing.Point(540, 9);
            this.txt_RemoveCustomerName.Name = "txt_RemoveCustomerName";
            this.txt_RemoveCustomerName.Size = new System.Drawing.Size(217, 30);
            this.txt_RemoveCustomerName.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(491, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Ad:";
            // 
            // dgw_RemoveCustomer
            // 
            this.dgw_RemoveCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_RemoveCustomer.Location = new System.Drawing.Point(18, 152);
            this.dgw_RemoveCustomer.Name = "dgw_RemoveCustomer";
            this.dgw_RemoveCustomer.RowHeadersWidth = 51;
            this.dgw_RemoveCustomer.RowTemplate.Height = 24;
            this.dgw_RemoveCustomer.Size = new System.Drawing.Size(750, 244);
            this.dgw_RemoveCustomer.TabIndex = 45;
            // 
            // btn_DeleteCustomer
            // 
            this.btn_DeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_DeleteCustomer.Location = new System.Drawing.Point(653, 98);
            this.btn_DeleteCustomer.Name = "btn_DeleteCustomer";
            this.btn_DeleteCustomer.Size = new System.Drawing.Size(115, 31);
            this.btn_DeleteCustomer.TabIndex = 46;
            this.btn_DeleteCustomer.Text = "Sil";
            this.btn_DeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // txt_RemoveCustomerId
            // 
            this.txt_RemoveCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_RemoveCustomerId.Location = new System.Drawing.Point(65, 15);
            this.txt_RemoveCustomerId.Name = "txt_RemoveCustomerId";
            this.txt_RemoveCustomerId.ReadOnly = true;
            this.txt_RemoveCustomerId.Size = new System.Drawing.Size(217, 30);
            this.txt_RemoveCustomerId.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(16, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "ID:";
            // 
            // frm_RemoveCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(787, 425);
            this.Controls.Add(this.txt_RemoveCustomerId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_DeleteCustomer);
            this.Controls.Add(this.dgw_RemoveCustomer);
            this.Controls.Add(this.txt_RemoveCustomerLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_RemoveCustomerName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_RemoveCustomerForm";
            this.Text = "Müşteri Silme Paneli";
            ((System.ComponentModel.ISupportInitialize)(this.dgw_RemoveCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_RemoveCustomerLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_RemoveCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgw_RemoveCustomer;
        private System.Windows.Forms.Button btn_DeleteCustomer;
        private System.Windows.Forms.TextBox txt_RemoveCustomerId;
        private System.Windows.Forms.Label label3;
    }
}