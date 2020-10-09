namespace watermark
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btDrawWatermark = new System.Windows.Forms.Button();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelFileName = new System.Windows.Forms.Label();
            this.labelNumAuction = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.btOpenFile = new System.Windows.Forms.Button();
            this.tbClient = new System.Windows.Forms.TextBox();
            this.tbNumAuction = new System.Windows.Forms.TextBox();
            this.labelCatalog = new System.Windows.Forms.Label();
            this.tbCatalog = new System.Windows.Forms.TextBox();
            this.btSelCatalog = new System.Windows.Forms.Button();
            this.labelINN = new System.Windows.Forms.Label();
            this.tbINN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btDrawWatermark
            // 
            this.btDrawWatermark.Location = new System.Drawing.Point(343, 111);
            this.btDrawWatermark.Name = "btDrawWatermark";
            this.btDrawWatermark.Size = new System.Drawing.Size(75, 23);
            this.btDrawWatermark.TabIndex = 0;
            this.btDrawWatermark.Text = "Создать";
            this.btDrawWatermark.UseVisualStyleBackColor = true;
            this.btDrawWatermark.Click += new System.EventHandler(this.btDrawWatermark_Click);
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(13, 62);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(43, 13);
            this.labelClient.TabIndex = 1;
            this.labelClient.Text = "Клиент";
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelFileName.Location = new System.Drawing.Point(13, 9);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(36, 13);
            this.labelFileName.TabIndex = 2;
            this.labelFileName.Text = "Файл";
            // 
            // labelNumAuction
            // 
            this.labelNumAuction.AutoSize = true;
            this.labelNumAuction.Location = new System.Drawing.Point(13, 88);
            this.labelNumAuction.Name = "labelNumAuction";
            this.labelNumAuction.Size = new System.Drawing.Size(63, 13);
            this.labelNumAuction.TabIndex = 3;
            this.labelNumAuction.Text = "Аукцион №";
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(82, 6);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.ReadOnly = true;
            this.tbFileName.Size = new System.Drawing.Size(300, 20);
            this.tbFileName.TabIndex = 4;
            // 
            // btOpenFile
            // 
            this.btOpenFile.Location = new System.Drawing.Point(387, 5);
            this.btOpenFile.Name = "btOpenFile";
            this.btOpenFile.Size = new System.Drawing.Size(31, 23);
            this.btOpenFile.TabIndex = 5;
            this.btOpenFile.Text = "...";
            this.btOpenFile.UseVisualStyleBackColor = true;
            this.btOpenFile.Click += new System.EventHandler(this.btOpenFile_Click);
            // 
            // tbClient
            // 
            this.tbClient.Location = new System.Drawing.Point(82, 59);
            this.tbClient.Name = "tbClient";
            this.tbClient.Size = new System.Drawing.Size(193, 20);
            this.tbClient.TabIndex = 6;
            // 
            // tbNumAuction
            // 
            this.tbNumAuction.Location = new System.Drawing.Point(82, 85);
            this.tbNumAuction.Name = "tbNumAuction";
            this.tbNumAuction.Size = new System.Drawing.Size(336, 20);
            this.tbNumAuction.TabIndex = 7;
            // 
            // labelCatalog
            // 
            this.labelCatalog.AutoSize = true;
            this.labelCatalog.Location = new System.Drawing.Point(12, 36);
            this.labelCatalog.Name = "labelCatalog";
            this.labelCatalog.Size = new System.Drawing.Size(48, 13);
            this.labelCatalog.TabIndex = 8;
            this.labelCatalog.Text = "Каталог";
            // 
            // tbCatalog
            // 
            this.tbCatalog.Location = new System.Drawing.Point(83, 33);
            this.tbCatalog.Name = "tbCatalog";
            this.tbCatalog.ReadOnly = true;
            this.tbCatalog.Size = new System.Drawing.Size(299, 20);
            this.tbCatalog.TabIndex = 9;
            // 
            // btSelCatalog
            // 
            this.btSelCatalog.Location = new System.Drawing.Point(387, 31);
            this.btSelCatalog.Name = "btSelCatalog";
            this.btSelCatalog.Size = new System.Drawing.Size(31, 23);
            this.btSelCatalog.TabIndex = 10;
            this.btSelCatalog.Text = "...";
            this.btSelCatalog.UseVisualStyleBackColor = true;
            this.btSelCatalog.Click += new System.EventHandler(this.btSelCatalog_Click);
            // 
            // labelINN
            // 
            this.labelINN.AutoSize = true;
            this.labelINN.Location = new System.Drawing.Point(281, 62);
            this.labelINN.Name = "labelINN";
            this.labelINN.Size = new System.Drawing.Size(31, 13);
            this.labelINN.TabIndex = 11;
            this.labelINN.Text = "ИНН";
            // 
            // tbINN
            // 
            this.tbINN.Location = new System.Drawing.Point(318, 59);
            this.tbINN.Name = "tbINN";
            this.tbINN.Size = new System.Drawing.Size(100, 20);
            this.tbINN.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 141);
            this.Controls.Add(this.tbINN);
            this.Controls.Add(this.labelINN);
            this.Controls.Add(this.btSelCatalog);
            this.Controls.Add(this.tbCatalog);
            this.Controls.Add(this.labelCatalog);
            this.Controls.Add(this.tbNumAuction);
            this.Controls.Add(this.tbClient);
            this.Controls.Add(this.btOpenFile);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.labelNumAuction);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.btDrawWatermark);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDrawWatermark;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label labelNumAuction;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Button btOpenFile;
        private System.Windows.Forms.TextBox tbClient;
        private System.Windows.Forms.TextBox tbNumAuction;
        private System.Windows.Forms.Label labelCatalog;
        private System.Windows.Forms.TextBox tbCatalog;
        private System.Windows.Forms.Button btSelCatalog;
        private System.Windows.Forms.Label labelINN;
        private System.Windows.Forms.TextBox tbINN;
    }
}

