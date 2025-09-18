
namespace AutoStockApp
{
    partial class frm_ModelForm
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
            this.dgw_Model = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_ModelBrandName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ModelName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Model)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_Model
            // 
            this.dgw_Model.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Model.Location = new System.Drawing.Point(12, 157);
            this.dgw_Model.Name = "dgw_Model";
            this.dgw_Model.RowHeadersWidth = 51;
            this.dgw_Model.RowTemplate.Height = 24;
            this.dgw_Model.Size = new System.Drawing.Size(515, 210);
            this.dgw_Model.TabIndex = 17;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Delete.Location = new System.Drawing.Point(412, 109);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(115, 31);
            this.btn_Delete.TabIndex = 16;
            this.btn_Delete.Text = "Sil";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Update.Location = new System.Drawing.Point(217, 109);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(115, 31);
            this.btn_Update.TabIndex = 15;
            this.btn_Update.Text = "Güncelle";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Add.Location = new System.Drawing.Point(37, 109);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(115, 31);
            this.btn_Add.TabIndex = 14;
            this.btn_Add.Text = "Ekle";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // txt_ModelBrandName
            // 
            this.txt_ModelBrandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ModelBrandName.Location = new System.Drawing.Point(91, 16);
            this.txt_ModelBrandName.Name = "txt_ModelBrandName";
            this.txt_ModelBrandName.Size = new System.Drawing.Size(217, 30);
            this.txt_ModelBrandName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Marka:";
            // 
            // txt_ModelName
            // 
            this.txt_ModelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ModelName.Location = new System.Drawing.Point(91, 52);
            this.txt_ModelName.Name = "txt_ModelName";
            this.txt_ModelName.Size = new System.Drawing.Size(217, 30);
            this.txt_ModelName.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Model:";
            // 
            // frm_ModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(548, 379);
            this.Controls.Add(this.txt_ModelName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgw_Model);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_ModelBrandName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_ModelForm";
            this.Text = "Model Paneli";
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Model)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_Model;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_ModelBrandName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ModelName;
        private System.Windows.Forms.Label label2;
    }
}