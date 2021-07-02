
namespace HealStorage
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statistics = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pharmacyStorage = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.supplierGoods = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.itemInfo = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tableUpdate = new System.Windows.Forms.Button();
            this.dayTimeInfo = new System.Windows.Forms.Label();
            this.daysCount = new System.Windows.Forms.Label();
            this.buttonResetDays = new System.Windows.Forms.Button();
            this.buttonNextDay = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statistics)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyStorage)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierGoods)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.statistics);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(668, 464);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Список всех товаров";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // statistics
            // 
            this.statistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statistics.Location = new System.Drawing.Point(3, 3);
            this.statistics.Name = "statistics";
            this.statistics.RowTemplate.Height = 25;
            this.statistics.Size = new System.Drawing.Size(662, 458);
            this.statistics.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pharmacyStorage);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(668, 464);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Аптечный склад";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pharmacyStorage
            // 
            this.pharmacyStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pharmacyStorage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pharmacyStorage.Location = new System.Drawing.Point(3, 3);
            this.pharmacyStorage.Name = "pharmacyStorage";
            this.pharmacyStorage.RowTemplate.Height = 25;
            this.pharmacyStorage.Size = new System.Drawing.Size(662, 458);
            this.pharmacyStorage.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(676, 492);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.supplierGoods);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(668, 464);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Данные о товарах поставщиков";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // supplierGoods
            // 
            this.supplierGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplierGoods.Location = new System.Drawing.Point(3, 3);
            this.supplierGoods.Name = "supplierGoods";
            this.supplierGoods.RowTemplate.Height = 25;
            this.supplierGoods.Size = new System.Drawing.Size(662, 458);
            this.supplierGoods.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.itemInfo);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(668, 464);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Информация о товарах";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // itemInfo
            // 
            this.itemInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemInfo.Location = new System.Drawing.Point(3, 3);
            this.itemInfo.Name = "itemInfo";
            this.itemInfo.RowTemplate.Height = 25;
            this.itemInfo.Size = new System.Drawing.Size(662, 458);
            this.itemInfo.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel1.Controls.Add(this.tableUpdate);
            this.splitContainer1.Panel1.Controls.Add(this.dayTimeInfo);
            this.splitContainer1.Panel1.Controls.Add(this.daysCount);
            this.splitContainer1.Panel1.Controls.Add(this.buttonResetDays);
            this.splitContainer1.Panel1.Controls.Add(this.buttonNextDay);
            this.splitContainer1.Panel1MinSize = 150;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl);
            this.splitContainer1.Size = new System.Drawing.Size(842, 492);
            this.splitContainer1.SplitterDistance = 150;
            this.splitContainer1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.Location = new System.Drawing.Point(0, 163);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(151, 205);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "пусто";
            // 
            // tableUpdate
            // 
            this.tableUpdate.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.tableUpdate.Location = new System.Drawing.Point(12, 430);
            this.tableUpdate.Name = "tableUpdate";
            this.tableUpdate.Size = new System.Drawing.Size(127, 23);
            this.tableUpdate.TabIndex = 5;
            this.tableUpdate.Text = "Обновление таблиц";
            this.tableUpdate.UseVisualStyleBackColor = true;
            this.tableUpdate.Click += new System.EventHandler(this.tableUpdate_Click);
            // 
            // dayTimeInfo
            // 
            this.dayTimeInfo.AutoSize = true;
            this.dayTimeInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.dayTimeInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dayTimeInfo.Location = new System.Drawing.Point(37, 46);
            this.dayTimeInfo.Name = "dayTimeInfo";
            this.dayTimeInfo.Size = new System.Drawing.Size(73, 17);
            this.dayTimeInfo.TabIndex = 4;
            this.dayTimeInfo.Text = "Начало дня";
            this.dayTimeInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // daysCount
            // 
            this.daysCount.AutoSize = true;
            this.daysCount.BackColor = System.Drawing.Color.Gainsboro;
            this.daysCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.daysCount.Location = new System.Drawing.Point(23, 18);
            this.daysCount.Name = "daysCount";
            this.daysCount.Size = new System.Drawing.Size(98, 17);
            this.daysCount.TabIndex = 3;
            this.daysCount.Text = "Дней прошло: 0";
            this.daysCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonResetDays
            // 
            this.buttonResetDays.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResetDays.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonResetDays.Location = new System.Drawing.Point(37, 66);
            this.buttonResetDays.Name = "buttonResetDays";
            this.buttonResetDays.Size = new System.Drawing.Size(24, 23);
            this.buttonResetDays.TabIndex = 2;
            this.buttonResetDays.Text = "↻";
            this.buttonResetDays.UseVisualStyleBackColor = true;
            this.buttonResetDays.Click += new System.EventHandler(this.buttonResetDays_Click);
            // 
            // buttonNextDay
            // 
            this.buttonNextDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNextDay.Location = new System.Drawing.Point(86, 66);
            this.buttonNextDay.Name = "buttonNextDay";
            this.buttonNextDay.Size = new System.Drawing.Size(24, 23);
            this.buttonNextDay.TabIndex = 1;
            this.buttonNextDay.Text = "▷";
            this.buttonNextDay.UseVisualStyleBackColor = true;
            this.buttonNextDay.Click += new System.EventHandler(this.buttonNextDay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 492);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Heal Storage";
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statistics)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyStorage)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.supplierGoods)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemInfo)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonNextDay;
        private System.Windows.Forms.Button buttonResetDays;
        private System.Windows.Forms.Label daysCount;
        private System.Windows.Forms.DataGridView pharmacyStorage;
        private System.Windows.Forms.DataGridView statistics;
        private System.Windows.Forms.DataGridView supplierGoods;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView itemInfo;
        private System.Windows.Forms.Label dayTimeInfo;
        private System.Windows.Forms.Button tableUpdate;
        public System.Windows.Forms.RichTextBox richTextBox1;
    }
}

