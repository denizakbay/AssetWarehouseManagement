namespace AssetWarehouseManagement
{
    partial class FrmSıkSorulanSorular
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
            this.btnsss = new System.Windows.Forms.Button();
            this.lstsss = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnsss
            // 
            this.btnsss.Location = new System.Drawing.Point(12, 49);
            this.btnsss.Name = "btnsss";
            this.btnsss.Size = new System.Drawing.Size(65, 47);
            this.btnsss.TabIndex = 0;
            this.btnsss.Text = "sık sorulan sorular";
            this.btnsss.UseVisualStyleBackColor = true;
            this.btnsss.Click += new System.EventHandler(this.btnsss_Click);
            // 
            // lstsss
            // 
            this.lstsss.FormattingEnabled = true;
            this.lstsss.ItemHeight = 16;
            this.lstsss.Location = new System.Drawing.Point(116, 36);
            this.lstsss.Name = "lstsss";
            this.lstsss.Size = new System.Drawing.Size(672, 404);
            this.lstsss.TabIndex = 1;
            this.lstsss.SelectedIndexChanged += new System.EventHandler(this.lstsss_SelectedIndexChanged);
            // 
            // FrmSıkSorulanSorular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstsss);
            this.Controls.Add(this.btnsss);
            this.Name = "FrmSıkSorulanSorular";
            this.Text = "FrmSıkSorulanSorular";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsss;
        private System.Windows.Forms.ListBox lstsss;
    }
}