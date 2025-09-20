
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
            this.txt_ColorId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Color)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_Color
            // 
            this.dgw_Color.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_Color.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Color.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgw_Color.Location = new System.Drawing.Point(0, 164);
            this.dgw_Color.Name = "dgw_Color";
            this.dgw_Color.RowHeadersWidth = 51;
            this.dgw_Color.RowTemplate.Height = 24;
            this.dgw_Color.Size = new System.Drawing.Size(479, 210);
            this.dgw_Color.TabIndex = 19;
            this.dgw_Color.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_Color_CellDoubleClick);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Delete.Location = new System.Drawing.Point(334, 99);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(115, 31);
            this.btn_Delete.TabIndex = 18;
            this.btn_Delete.Text = "Sil";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // txt_AddColor
            // 
            this.txt_AddColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_AddColor.Location = new System.Drawing.Point(99, 43);
            this.txt_AddColor.Name = "txt_AddColor";
            this.txt_AddColor.Size = new System.Drawing.Size(224, 30);
            this.txt_AddColor.TabIndex = 21;
            this.txt_AddColor.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(35, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Renk:";
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Add.Location = new System.Drawing.Point(32, 99);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(115, 31);
            this.btn_Add.TabIndex = 22;
            this.btn_Add.Text = "Ekle";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Update.Location = new System.Drawing.Point(186, 99);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(115, 31);
            this.btn_Update.TabIndex = 23;
            this.btn_Update.Text = "Güncelle";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // txt_ColorId
            // 
            this.txt_ColorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ColorId.Location = new System.Drawing.Point(100, 7);
            this.txt_ColorId.Name = "txt_ColorId";
            this.txt_ColorId.Size = new System.Drawing.Size(224, 30);
            this.txt_ColorId.TabIndex = 25;
            this.txt_ColorId.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Renk ID:";
            // 
            // frm_ColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(479, 374);
            this.Controls.Add(this.txt_ColorId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_AddColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgw_Color);
            this.Controls.Add(this.btn_Delete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_ColorForm";
            this.Text = "Renk Paneli";
            this.Load += new System.EventHandler(this.frm_ColorForm_Load);
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
        private System.Windows.Forms.TextBox txt_ColorId;
        private System.Windows.Forms.Label label1;
    }
}