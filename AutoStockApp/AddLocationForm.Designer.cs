
namespace AutoStockApp
{
    partial class frm_AddLocationForm
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
            this.txt_AddLocationAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_AddLocationName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddLocation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_AddLocationAddress
            // 
            this.txt_AddLocationAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_AddLocationAddress.Location = new System.Drawing.Point(95, 96);
            this.txt_AddLocationAddress.Name = "txt_AddLocationAddress";
            this.txt_AddLocationAddress.Size = new System.Drawing.Size(185, 30);
            this.txt_AddLocationAddress.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(37, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Yeri:";
            // 
            // txt_AddLocationName
            // 
            this.txt_AddLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_AddLocationName.Location = new System.Drawing.Point(95, 48);
            this.txt_AddLocationName.Name = "txt_AddLocationName";
            this.txt_AddLocationName.Size = new System.Drawing.Size(185, 30);
            this.txt_AddLocationName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(42, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adı:";
            // 
            // btn_AddLocation
            // 
            this.btn_AddLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AddLocation.Location = new System.Drawing.Point(95, 150);
            this.btn_AddLocation.Name = "btn_AddLocation";
            this.btn_AddLocation.Size = new System.Drawing.Size(185, 34);
            this.btn_AddLocation.TabIndex = 11;
            this.btn_AddLocation.Text = "Ekle";
            this.btn_AddLocation.UseVisualStyleBackColor = true;
            this.btn_AddLocation.Click += new System.EventHandler(this.btn_AddLocation_Click);
            // 
            // frm_AddLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(358, 292);
            this.Controls.Add(this.btn_AddLocation);
            this.Controls.Add(this.txt_AddLocationAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_AddLocationName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_AddLocationForm";
            this.Text = "Lokasyon Ekleme Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_AddLocationAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_AddLocationName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddLocation;
    }
}