
namespace AutoStockApp
{
    partial class frm_LocationForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgw_Location = new System.Windows.Forms.DataGridView();
            this.grb_Location = new System.Windows.Forms.GroupBox();
            this.chb_Part = new System.Windows.Forms.CheckBox();
            this.chb_Vehicle = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_SearchLocation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Location)).BeginInit();
            this.grb_Location.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(70, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 30);
            this.textBox1.TabIndex = 1;
            // 
            // dgw_Location
            // 
            this.dgw_Location.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Location.Location = new System.Drawing.Point(12, 188);
            this.dgw_Location.Name = "dgw_Location";
            this.dgw_Location.RowHeadersWidth = 51;
            this.dgw_Location.RowTemplate.Height = 24;
            this.dgw_Location.Size = new System.Drawing.Size(776, 238);
            this.dgw_Location.TabIndex = 2;
            // 
            // grb_Location
            // 
            this.grb_Location.Controls.Add(this.chb_Vehicle);
            this.grb_Location.Controls.Add(this.chb_Part);
            this.grb_Location.Location = new System.Drawing.Point(291, 12);
            this.grb_Location.Name = "grb_Location";
            this.grb_Location.Size = new System.Drawing.Size(497, 92);
            this.grb_Location.TabIndex = 3;
            this.grb_Location.TabStop = false;
            // 
            // chb_Part
            // 
            this.chb_Part.AutoSize = true;
            this.chb_Part.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chb_Part.Location = new System.Drawing.Point(27, 21);
            this.chb_Part.Name = "chb_Part";
            this.chb_Part.Size = new System.Drawing.Size(190, 29);
            this.chb_Part.TabIndex = 0;
            this.chb_Part.Text = "Parçaya Göre Ara";
            this.chb_Part.UseVisualStyleBackColor = true;
            // 
            // chb_Vehicle
            // 
            this.chb_Vehicle.AutoSize = true;
            this.chb_Vehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chb_Vehicle.Location = new System.Drawing.Point(289, 21);
            this.chb_Vehicle.Name = "chb_Vehicle";
            this.chb_Vehicle.Size = new System.Drawing.Size(170, 29);
            this.chb_Vehicle.TabIndex = 1;
            this.chb_Vehicle.Text = "Araca Göre Ara";
            this.chb_Vehicle.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(70, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 30);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yeri:";
            // 
            // btn_SearchLocation
            // 
            this.btn_SearchLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_SearchLocation.Location = new System.Drawing.Point(696, 122);
            this.btn_SearchLocation.Name = "btn_SearchLocation";
            this.btn_SearchLocation.Size = new System.Drawing.Size(92, 34);
            this.btn_SearchLocation.TabIndex = 6;
            this.btn_SearchLocation.Text = "Ara";
            this.btn_SearchLocation.UseVisualStyleBackColor = true;
            // 
            // frm_LocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_SearchLocation);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grb_Location);
            this.Controls.Add(this.dgw_Location);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_LocationForm";
            this.Text = "Lokasyon Paneli";
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Location)).EndInit();
            this.grb_Location.ResumeLayout(false);
            this.grb_Location.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgw_Location;
        private System.Windows.Forms.GroupBox grb_Location;
        private System.Windows.Forms.CheckBox chb_Vehicle;
        private System.Windows.Forms.CheckBox chb_Part;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_SearchLocation;
    }
}