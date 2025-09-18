
namespace AutoStockApp
{
    partial class frm_UpdateEmployeeForm
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
            this.cmb_UpdateEmployeeRole = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_UpdateEmployeePassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_UpdateEmployeeUserName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_UpdateEmployeePhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_UpdateEmployeeEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_UpdateEmployeeLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgw_UpdateEmployee = new System.Windows.Forms.DataGridView();
            this.btn_UpdateEmployee = new System.Windows.Forms.Button();
            this.txt_UpdateEmployeeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_UpdateEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_UpdateEmployeeRole
            // 
            this.cmb_UpdateEmployeeRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_UpdateEmployeeRole.FormattingEnabled = true;
            this.cmb_UpdateEmployeeRole.Items.AddRange(new object[] {
            "Yönetici",
            "Çalışan"});
            this.cmb_UpdateEmployeeRole.Location = new System.Drawing.Point(557, 97);
            this.cmb_UpdateEmployeeRole.Name = "cmb_UpdateEmployeeRole";
            this.cmb_UpdateEmployeeRole.Size = new System.Drawing.Size(217, 33);
            this.cmb_UpdateEmployeeRole.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(496, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 25);
            this.label5.TabIndex = 77;
            this.label5.Text = "Rol:";
            // 
            // txt_UpdateEmployeePassword
            // 
            this.txt_UpdateEmployeePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_UpdateEmployeePassword.Location = new System.Drawing.Point(557, 56);
            this.txt_UpdateEmployeePassword.Name = "txt_UpdateEmployeePassword";
            this.txt_UpdateEmployeePassword.Size = new System.Drawing.Size(217, 30);
            this.txt_UpdateEmployeePassword.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(484, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 25);
            this.label6.TabIndex = 75;
            this.label6.Text = "Şifre:";
            // 
            // txt_UpdateEmployeeUserName
            // 
            this.txt_UpdateEmployeeUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_UpdateEmployeeUserName.Location = new System.Drawing.Point(557, 20);
            this.txt_UpdateEmployeeUserName.Name = "txt_UpdateEmployeeUserName";
            this.txt_UpdateEmployeeUserName.Size = new System.Drawing.Size(217, 30);
            this.txt_UpdateEmployeeUserName.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(417, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 25);
            this.label7.TabIndex = 73;
            this.label7.Text = "Kullanıcı Adı:";
            // 
            // txt_UpdateEmployeePhone
            // 
            this.txt_UpdateEmployeePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_UpdateEmployeePhone.Location = new System.Drawing.Point(102, 130);
            this.txt_UpdateEmployeePhone.Name = "txt_UpdateEmployeePhone";
            this.txt_UpdateEmployeePhone.Size = new System.Drawing.Size(217, 30);
            this.txt_UpdateEmployeePhone.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 71;
            this.label3.Text = "Telefon:";
            // 
            // txt_UpdateEmployeeEmail
            // 
            this.txt_UpdateEmployeeEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_UpdateEmployeeEmail.Location = new System.Drawing.Point(102, 90);
            this.txt_UpdateEmployeeEmail.Name = "txt_UpdateEmployeeEmail";
            this.txt_UpdateEmployeeEmail.Size = new System.Drawing.Size(217, 30);
            this.txt_UpdateEmployeeEmail.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(30, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 69;
            this.label4.Text = "Email:";
            // 
            // txt_UpdateEmployeeLastName
            // 
            this.txt_UpdateEmployeeLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_UpdateEmployeeLastName.Location = new System.Drawing.Point(102, 54);
            this.txt_UpdateEmployeeLastName.Name = "txt_UpdateEmployeeLastName";
            this.txt_UpdateEmployeeLastName.Size = new System.Drawing.Size(217, 30);
            this.txt_UpdateEmployeeLastName.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 67;
            this.label2.Text = "Soyad:";
            // 
            // dgw_UpdateEmployee
            // 
            this.dgw_UpdateEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_UpdateEmployee.Location = new System.Drawing.Point(24, 209);
            this.dgw_UpdateEmployee.Name = "dgw_UpdateEmployee";
            this.dgw_UpdateEmployee.RowHeadersWidth = 51;
            this.dgw_UpdateEmployee.RowTemplate.Height = 24;
            this.dgw_UpdateEmployee.Size = new System.Drawing.Size(750, 244);
            this.dgw_UpdateEmployee.TabIndex = 66;
            // 
            // btn_UpdateEmployee
            // 
            this.btn_UpdateEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_UpdateEmployee.Location = new System.Drawing.Point(659, 156);
            this.btn_UpdateEmployee.Name = "btn_UpdateEmployee";
            this.btn_UpdateEmployee.Size = new System.Drawing.Size(115, 31);
            this.btn_UpdateEmployee.TabIndex = 65;
            this.btn_UpdateEmployee.Text = "Güncelle";
            this.btn_UpdateEmployee.UseVisualStyleBackColor = true;
            // 
            // txt_UpdateEmployeeName
            // 
            this.txt_UpdateEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_UpdateEmployeeName.Location = new System.Drawing.Point(102, 18);
            this.txt_UpdateEmployeeName.Name = "txt_UpdateEmployeeName";
            this.txt_UpdateEmployeeName.Size = new System.Drawing.Size(217, 30);
            this.txt_UpdateEmployeeName.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 25);
            this.label1.TabIndex = 63;
            this.label1.Text = "Ad:";
            // 
            // frm_UpdateEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(802, 465);
            this.Controls.Add(this.cmb_UpdateEmployeeRole);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_UpdateEmployeePassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_UpdateEmployeeUserName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_UpdateEmployeePhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_UpdateEmployeeEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_UpdateEmployeeLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgw_UpdateEmployee);
            this.Controls.Add(this.btn_UpdateEmployee);
            this.Controls.Add(this.txt_UpdateEmployeeName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_UpdateEmployeeForm";
            this.Text = "Çalışan Güncelleme Paneli";
            ((System.ComponentModel.ISupportInitialize)(this.dgw_UpdateEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_UpdateEmployeeRole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_UpdateEmployeePassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_UpdateEmployeeUserName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_UpdateEmployeePhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_UpdateEmployeeEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_UpdateEmployeeLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgw_UpdateEmployee;
        private System.Windows.Forms.Button btn_UpdateEmployee;
        private System.Windows.Forms.TextBox txt_UpdateEmployeeName;
        private System.Windows.Forms.Label label1;
    }
}