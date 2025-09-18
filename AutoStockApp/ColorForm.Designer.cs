
namespace AutoStockApp
{
    partial class frm_ColorForm
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
            this.dgw_Color = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.txt_AddColor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Color)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_Color
            // 
            this.dgw_Color.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Color.Location = new System.Drawing.Point(12, 140);
            this.dgw_Color.Name = "dgw_Color";
            this.dgw_Color.RowHeadersWidth = 51;
            this.dgw_Color.RowTemplate.Height = 24;
            this.dgw_Color.Size = new System.Drawing.Size(436, 210);
            this.dgw_Color.TabIndex = 19;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Delete.Location = new System.Drawing.Point(333, 79);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(115, 31);
            this.btn_Delete.TabIndex = 18;
            this.btn_Delete.Text = "Sil";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // txt_AddColor
            // 
            this.txt_AddColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_AddColor.Location = new System.Drawing.Point(76, 15);
            this.txt_AddColor.Name = "txt_AddColor";
            this.txt_AddColor.Size = new System.Drawing.Size(224, 30);
            this.txt_AddColor.TabIndex = 21;
            this.txt_AddColor.Tag = "";
            this.txt_AddColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_AddColor_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Renk:";
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Add.Location = new System.Drawing.Point(31, 79);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(115, 31);
            this.btn_Add.TabIndex = 22;
            this.btn_Add.Text = "Ekle";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Update.Location = new System.Drawing.Point(185, 79);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(115, 31);
            this.btn_Update.TabIndex = 23;
            this.btn_Update.Text = "Güncelle";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // frm_ColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(479, 374);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_AddColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgw_Color);
            this.Controls.Add(this.btn_Delete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_ColorForm";
            this.Text = "Renk Paneli";
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Color)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_Color;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TextBox txt_AddColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
    }
}