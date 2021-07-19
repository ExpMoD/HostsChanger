namespace hosts_changer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ButtonSortUp = new System.Windows.Forms.Button();
            this.ButtonSortDown = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.GridViewHosts = new System.Windows.Forms.DataGridView();
            this.ColumnIp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDomain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewHosts)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSortUp
            // 
            this.ButtonSortUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonSortUp.BackgroundImage")));
            this.ButtonSortUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonSortUp.Location = new System.Drawing.Point(284, 12);
            this.ButtonSortUp.Name = "ButtonSortUp";
            this.ButtonSortUp.Padding = new System.Windows.Forms.Padding(25);
            this.ButtonSortUp.Size = new System.Drawing.Size(45, 45);
            this.ButtonSortUp.TabIndex = 2;
            this.ButtonSortUp.UseVisualStyleBackColor = true;
            this.ButtonSortUp.Click += new System.EventHandler(this.ButtonSortUp_Click);
            // 
            // ButtonSortDown
            // 
            this.ButtonSortDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonSortDown.BackgroundImage")));
            this.ButtonSortDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonSortDown.Location = new System.Drawing.Point(335, 12);
            this.ButtonSortDown.Name = "ButtonSortDown";
            this.ButtonSortDown.Padding = new System.Windows.Forms.Padding(25);
            this.ButtonSortDown.Size = new System.Drawing.Size(45, 45);
            this.ButtonSortDown.TabIndex = 3;
            this.ButtonSortDown.UseVisualStyleBackColor = true;
            this.ButtonSortDown.Click += new System.EventHandler(this.ButtonSortDown_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSave.Location = new System.Drawing.Point(63, 12);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(215, 45);
            this.ButtonSave.TabIndex = 4;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonRefresh.BackgroundImage")));
            this.ButtonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonRefresh.Location = new System.Drawing.Point(12, 12);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Padding = new System.Windows.Forms.Padding(25);
            this.ButtonRefresh.Size = new System.Drawing.Size(45, 45);
            this.ButtonRefresh.TabIndex = 5;
            this.ButtonRefresh.UseVisualStyleBackColor = true;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // GridViewHosts
            // 
            this.GridViewHosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewHosts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIp,
            this.ColumnDomain});
            this.GridViewHosts.Location = new System.Drawing.Point(12, 63);
            this.GridViewHosts.Name = "GridViewHosts";
            this.GridViewHosts.Size = new System.Drawing.Size(368, 389);
            this.GridViewHosts.TabIndex = 6;
            // 
            // ColumnIp
            // 
            this.ColumnIp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.NullValue = "127.0.0.1";
            this.ColumnIp.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnIp.Frozen = true;
            this.ColumnIp.HeaderText = "IP";
            this.ColumnIp.Name = "ColumnIp";
            this.ColumnIp.Width = 115;
            // 
            // ColumnDomain
            // 
            this.ColumnDomain.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnDomain.Frozen = true;
            this.ColumnDomain.HeaderText = "Domain";
            this.ColumnDomain.Name = "ColumnDomain";
            this.ColumnDomain.Width = 210;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 464);
            this.Controls.Add(this.GridViewHosts);
            this.Controls.Add(this.ButtonRefresh);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonSortDown);
            this.Controls.Add(this.ButtonSortUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Редактор Hosts";
            ((System.ComponentModel.ISupportInitialize)(this.GridViewHosts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonSortUp;
        private System.Windows.Forms.Button ButtonSortDown;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonRefresh;
        private System.Windows.Forms.DataGridView GridViewHosts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDomain;
    }
}

