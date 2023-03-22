namespace AssetWarehouseManagement
{
    partial class FrmDuyuru
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
            this.lstvDuyuru = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnListegeridon = new System.Windows.Forms.Button();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstvDuyuru
            // 
            this.lstvDuyuru.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstvDuyuru.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstvDuyuru.HideSelection = false;
            this.lstvDuyuru.Location = new System.Drawing.Point(0, 128);
            this.lstvDuyuru.Name = "lstvDuyuru";
            this.lstvDuyuru.Size = new System.Drawing.Size(964, 612);
            this.lstvDuyuru.TabIndex = 0;
            this.lstvDuyuru.UseCompatibleStateImageBehavior = false;
            this.lstvDuyuru.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tarih";
            this.columnHeader1.Width = 117;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Başlık";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Açıklama";
            this.columnHeader3.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listeye Geri Dön";
            // 
            // btnListegeridon
            // 
            this.btnListegeridon.Location = new System.Drawing.Point(15, 54);
            this.btnListegeridon.Name = "btnListegeridon";
            this.btnListegeridon.Size = new System.Drawing.Size(75, 23);
            this.btnListegeridon.TabIndex = 2;
            this.btnListegeridon.Text = "<<";
            this.btnListegeridon.UseVisualStyleBackColor = true;
            this.btnListegeridon.Click += new System.EventHandler(this.btnListegeridon_Click);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Duyurular";
            this.columnHeader4.Width = 102;
            // 
            // FrmDuyuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 740);
            this.Controls.Add(this.btnListegeridon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstvDuyuru);
            this.Name = "FrmDuyuru";
            this.Text = "FrmDuyuru";
            this.Load += new System.EventHandler(this.FrmDuyuru_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvDuyuru;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListegeridon;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}