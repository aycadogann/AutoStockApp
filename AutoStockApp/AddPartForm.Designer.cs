
namespace AutoStockApp
{
    partial class frm_AddPartForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SupplierPart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PartNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_PartName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SalePricePart = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_PurchasePricePart = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_StockQuantityPart = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_LocationPart = new System.Windows.Forms.ComboBox();
            this.btn_AddPart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(68, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tedarikçi:";
            // 
            // txt_SupplierPart
            // 
            this.txt_SupplierPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_SupplierPart.Location = new System.Drawing.Point(170, 48);
            this.txt_SupplierPart.Name = "txt_SupplierPart";
            this.txt_SupplierPart.Size = new System.Drawing.Size(220, 30);
            this.txt_SupplierPart.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(118, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yer:";
            // 
            // txt_PartNumber
            // 
            this.txt_PartNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_PartNumber.Location = new System.Drawing.Point(170, 159);
            this.txt_PartNumber.Name = "txt_PartNumber";
            this.txt_PartNumber.Size = new System.Drawing.Size(220, 30);
            this.txt_PartNumber.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parça Numarası:";
            // 
            // txt_PartName
            // 
            this.txt_PartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_PartName.Location = new System.Drawing.Point(170, 123);
            this.txt_PartName.Name = "txt_PartName";
            this.txt_PartName.Size = new System.Drawing.Size(220, 30);
            this.txt_PartName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(57, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Parça İsmi:";
            // 
            // txt_SalePricePart
            // 
            this.txt_SalePricePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_SalePricePart.Location = new System.Drawing.Point(170, 267);
            this.txt_SalePricePart.Name = "txt_SalePricePart";
            this.txt_SalePricePart.Size = new System.Drawing.Size(220, 30);
            this.txt_SalePricePart.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(53, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Satış Fiyatı:";
            // 
            // txt_PurchasePricePart
            // 
            this.txt_PurchasePricePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_PurchasePricePart.Location = new System.Drawing.Point(170, 231);
            this.txt_PurchasePricePart.Name = "txt_PurchasePricePart";
            this.txt_PurchasePricePart.Size = new System.Drawing.Size(220, 30);
            this.txt_PurchasePricePart.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(65, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Alış Fiyatı:";
            // 
            // txt_StockQuantityPart
            // 
            this.txt_StockQuantityPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_StockQuantityPart.Location = new System.Drawing.Point(170, 195);
            this.txt_StockQuantityPart.Name = "txt_StockQuantityPart";
            this.txt_StockQuantityPart.Size = new System.Drawing.Size(220, 30);
            this.txt_StockQuantityPart.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(46, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Stok Miktarı:";
            // 
            // cmb_LocationPart
            // 
            this.cmb_LocationPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_LocationPart.FormattingEnabled = true;
            this.cmb_LocationPart.Location = new System.Drawing.Point(170, 84);
            this.cmb_LocationPart.Name = "cmb_LocationPart";
            this.cmb_LocationPart.Size = new System.Drawing.Size(220, 33);
            this.cmb_LocationPart.TabIndex = 14;
            // 
            // btn_AddPart
            // 
            this.btn_AddPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AddPart.Location = new System.Drawing.Point(170, 316);
            this.btn_AddPart.Name = "btn_AddPart";
            this.btn_AddPart.Size = new System.Drawing.Size(220, 38);
            this.btn_AddPart.TabIndex = 15;
            this.btn_AddPart.Text = "Ekle";
            this.btn_AddPart.UseVisualStyleBackColor = true;
            // 
            // frm_AddPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 440);
            this.Controls.Add(this.btn_AddPart);
            this.Controls.Add(this.cmb_LocationPart);
            this.Controls.Add(this.txt_SalePricePart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_PurchasePricePart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_StockQuantityPart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_PartNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_PartName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_SupplierPart);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_AddPartForm";
            this.Text = "Parça Ekleme Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SupplierPart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_PartNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_PartName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_SalePricePart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_PurchasePricePart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_StockQuantityPart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_LocationPart;
        private System.Windows.Forms.Button btn_AddPart;
    }
}