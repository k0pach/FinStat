namespace FinStat2
{
    partial class Form1
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.main_tabp = new System.Windows.Forms.TabPage();
            this.openAddTrans_btn = new System.Windows.Forms.Button();
            this.stats_tabp = new System.Windows.Forms.TabPage();
            this.settings_tabp = new System.Windows.Forms.TabPage();
            this.transTitle_lbl = new System.Windows.Forms.Label();
            this.limit_lb = new System.Windows.Forms.Label();
            this.limit_tb = new System.Windows.Forms.TextBox();
            this.balance_tb = new System.Windows.Forms.TextBox();
            this.balance_lb = new System.Windows.Forms.Label();
            this.alert_tb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabControl.SuspendLayout();
            this.main_tabp.SuspendLayout();
            this.settings_tabp.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 28);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(544, 276);
            this.dataGridView.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.main_tabp);
            this.tabControl.Controls.Add(this.stats_tabp);
            this.tabControl.Controls.Add(this.settings_tabp);
            this.tabControl.Location = new System.Drawing.Point(-2, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(801, 450);
            this.tabControl.TabIndex = 5;
            // 
            // main_tabp
            // 
            this.main_tabp.Controls.Add(this.alert_tb);
            this.main_tabp.Controls.Add(this.balance_tb);
            this.main_tabp.Controls.Add(this.balance_lb);
            this.main_tabp.Controls.Add(this.limit_tb);
            this.main_tabp.Controls.Add(this.limit_lb);
            this.main_tabp.Controls.Add(this.openAddTrans_btn);
            this.main_tabp.Controls.Add(this.dataGridView);
            this.main_tabp.Location = new System.Drawing.Point(4, 22);
            this.main_tabp.Name = "main_tabp";
            this.main_tabp.Padding = new System.Windows.Forms.Padding(3);
            this.main_tabp.Size = new System.Drawing.Size(793, 424);
            this.main_tabp.TabIndex = 0;
            this.main_tabp.Text = "Main";
            this.main_tabp.UseVisualStyleBackColor = true;
            // 
            // openAddTrans_btn
            // 
            this.openAddTrans_btn.Location = new System.Drawing.Point(285, 310);
            this.openAddTrans_btn.Name = "openAddTrans_btn";
            this.openAddTrans_btn.Size = new System.Drawing.Size(214, 89);
            this.openAddTrans_btn.TabIndex = 1;
            this.openAddTrans_btn.Text = "Добавить новую транзакцию";
            this.openAddTrans_btn.UseVisualStyleBackColor = true;
            this.openAddTrans_btn.Click += new System.EventHandler(this.openAddTrans_btn_Click);
            // 
            // stats_tabp
            // 
            this.stats_tabp.Location = new System.Drawing.Point(4, 22);
            this.stats_tabp.Name = "stats_tabp";
            this.stats_tabp.Padding = new System.Windows.Forms.Padding(3);
            this.stats_tabp.Size = new System.Drawing.Size(793, 424);
            this.stats_tabp.TabIndex = 1;
            this.stats_tabp.Text = "Stats";
            this.stats_tabp.UseVisualStyleBackColor = true;
            // 
            // settings_tabp
            // 
            this.settings_tabp.Controls.Add(this.transTitle_lbl);
            this.settings_tabp.Location = new System.Drawing.Point(4, 22);
            this.settings_tabp.Name = "settings_tabp";
            this.settings_tabp.Size = new System.Drawing.Size(793, 424);
            this.settings_tabp.TabIndex = 2;
            this.settings_tabp.Text = "Settings";
            this.settings_tabp.UseVisualStyleBackColor = true;
            // 
            // transTitle_lbl
            // 
            this.transTitle_lbl.AutoSize = true;
            this.transTitle_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.transTitle_lbl.Location = new System.Drawing.Point(269, 28);
            this.transTitle_lbl.Name = "transTitle_lbl";
            this.transTitle_lbl.Size = new System.Drawing.Size(78, 20);
            this.transTitle_lbl.TabIndex = 9;
            this.transTitle_lbl.Text = "Бюджет";
            // 
            // limit_lb
            // 
            this.limit_lb.AutoSize = true;
            this.limit_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.limit_lb.Location = new System.Drawing.Point(4, 3);
            this.limit_lb.Name = "limit_lb";
            this.limit_lb.Size = new System.Drawing.Size(63, 17);
            this.limit_lb.TabIndex = 10;
            this.limit_lb.Text = "Бюджет:";
            // 
            // limit_tb
            // 
            this.limit_tb.Location = new System.Drawing.Point(73, 3);
            this.limit_tb.Name = "limit_tb";
            this.limit_tb.Size = new System.Drawing.Size(100, 20);
            this.limit_tb.TabIndex = 11;
            this.limit_tb.Text = "1000";
            // 
            // balance_tb
            // 
            this.balance_tb.Cursor = System.Windows.Forms.Cursors.Default;
            this.balance_tb.Location = new System.Drawing.Point(285, 6);
            this.balance_tb.Name = "balance_tb";
            this.balance_tb.ReadOnly = true;
            this.balance_tb.Size = new System.Drawing.Size(100, 20);
            this.balance_tb.TabIndex = 14;
            this.balance_tb.Text = "1000";
            // 
            // balance_lb
            // 
            this.balance_lb.AutoSize = true;
            this.balance_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.balance_lb.Location = new System.Drawing.Point(216, 6);
            this.balance_lb.Name = "balance_lb";
            this.balance_lb.Size = new System.Drawing.Size(60, 17);
            this.balance_lb.TabIndex = 13;
            this.balance_lb.Text = "Баланс:";
            // 
            // alert_tb
            // 
            this.alert_tb.BackColor = System.Drawing.SystemColors.Control;
            this.alert_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alert_tb.Cursor = System.Windows.Forms.Cursors.Default;
            this.alert_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.alert_tb.ForeColor = System.Drawing.Color.Red;
            this.alert_tb.Location = new System.Drawing.Point(546, 117);
            this.alert_tb.Multiline = true;
            this.alert_tb.Name = "alert_tb";
            this.alert_tb.ReadOnly = true;
            this.alert_tb.Size = new System.Drawing.Size(247, 111);
            this.alert_tb.TabIndex = 15;
            this.alert_tb.Text = "ЛИМИТ ПРЕВЫШЕН!";
            this.alert_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.alert_tb.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "General";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.main_tabp.ResumeLayout(false);
            this.main_tabp.PerformLayout();
            this.settings_tabp.ResumeLayout(false);
            this.settings_tabp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage main_tabp;
        private System.Windows.Forms.TabPage stats_tabp;
        private System.Windows.Forms.TabPage settings_tabp;
        private System.Windows.Forms.Button openAddTrans_btn;
        private System.Windows.Forms.Label transTitle_lbl;
        private System.Windows.Forms.TextBox limit_tb;
        private System.Windows.Forms.Label limit_lb;
        private System.Windows.Forms.TextBox balance_tb;
        private System.Windows.Forms.Label balance_lb;
        private System.Windows.Forms.TextBox alert_tb;
    }
}

