namespace AssetWarehouseManagement
{
    partial class FrmFiltreListe
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
            this.lstFiltre = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnKayitNo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKayitNo = new System.Windows.Forms.TextBox();
            this.btnModel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstFiltre
            // 
            this.lstFiltre.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstFiltre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstFiltre.HideSelection = false;
            this.lstFiltre.Location = new System.Drawing.Point(0, 275);
            this.lstFiltre.Margin = new System.Windows.Forms.Padding(4);
            this.lstFiltre.Name = "lstFiltre";
            this.lstFiltre.Size = new System.Drawing.Size(1100, 428);
            this.lstFiltre.TabIndex = 0;
            this.lstFiltre.UseCompatibleStateImageBehavior = false;
            this.lstFiltre.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kayıt Numarası";
            this.columnHeader1.Width = 251;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Barkod";
            this.columnHeader2.Width = 161;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ürün Tipi";
            this.columnHeader3.Width = 155;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ürün Güncel Fiyatı";
            this.columnHeader4.Width = 181;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Markası";
            this.columnHeader5.Width = 134;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Modeli";
            this.columnHeader6.Width = 190;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(12, 41);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(333, 27);
            this.txtBarkod.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Barkod Numarasına Göre Arama Yapın";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(374, 42);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(96, 26);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnKayitNo
            // 
            this.btnKayitNo.Location = new System.Drawing.Point(370, 152);
            this.btnKayitNo.Name = "btnKayitNo";
            this.btnKayitNo.Size = new System.Drawing.Size(96, 26);
            this.btnKayitNo.TabIndex = 6;
            this.btnKayitNo.Text = "Ara";
            this.btnKayitNo.UseVisualStyleBackColor = true;
            this.btnKayitNo.Click += new System.EventHandler(this.btnKayitNo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kayıt Numarasına Göre Arama Yap";
            // 
            // txtKayitNo
            // 
            this.txtKayitNo.Location = new System.Drawing.Point(8, 151);
            this.txtKayitNo.Name = "txtKayitNo";
            this.txtKayitNo.Size = new System.Drawing.Size(333, 27);
            this.txtKayitNo.TabIndex = 4;
            // 
            // btnModel
            // 
            this.btnModel.Location = new System.Drawing.Point(925, 42);
            this.btnModel.Name = "btnModel";
            this.btnModel.Size = new System.Drawing.Size(96, 26);
            this.btnModel.TabIndex = 9;
            this.btnModel.Text = "Ara";
            this.btnModel.UseVisualStyleBackColor = true;
            this.btnModel.Click += new System.EventHandler(this.btnModel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(563, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Modeline Göre Arama Yap";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(563, 41);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(333, 27);
            this.txtModel.TabIndex = 7;
            // 
            // FrmFiltreListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 703);
            this.Controls.Add(this.btnModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.btnKayitNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKayitNo);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.lstFiltre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmFiltreListe";
            this.Text = "FrmFiltreListe";
            this.Load += new System.EventHandler(this.FrmFiltreListe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstFiltre;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnKayitNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKayitNo;
        private System.Windows.Forms.Button btnModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModel;
    }
}