namespace FinStat2
{
    partial class Form2
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
            this.chooseCat_lb = new System.Windows.Forms.Label();
            this.transSum_lbl = new System.Windows.Forms.Label();
            this.transTitle_tb = new System.Windows.Forms.TextBox();
            this.transTitle_lbl = new System.Windows.Forms.Label();
            this.transSum_tb = new System.Windows.Forms.TextBox();
            this.addTranstitle_lb = new System.Windows.Forms.Label();
            this.addTrans_btn = new System.Windows.Forms.Button();
            this.desc_tb = new System.Windows.Forms.TextBox();
            this.desc_lb = new System.Windows.Forms.Label();
            this.expend_rb = new System.Windows.Forms.RadioButton();
            this.income_rb = new System.Windows.Forms.RadioButton();
            this.chooseCat_rb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // chooseCat_lb
            // 
            this.chooseCat_lb.AutoSize = true;
            this.chooseCat_lb.Location = new System.Drawing.Point(10, 105);
            this.chooseCat_lb.Name = "chooseCat_lb";
            this.chooseCat_lb.Size = new System.Drawing.Size(65, 13);
            this.chooseCat_lb.TabIndex = 12;
            this.chooseCat_lb.Text = "Категорию:";
            // 
            // transSum_lbl
            // 
            this.transSum_lbl.AutoSize = true;
            this.transSum_lbl.Location = new System.Drawing.Point(10, 150);
            this.transSum_lbl.Name = "transSum_lbl";
            this.transSum_lbl.Size = new System.Drawing.Size(43, 13);
            this.transSum_lbl.TabIndex = 10;
            this.transSum_lbl.Text = "Сумму:";
            // 
            // transTitle_tb
            // 
            this.transTitle_tb.Location = new System.Drawing.Point(10, 55);
            this.transTitle_tb.Name = "transTitle_tb";
            this.transTitle_tb.Size = new System.Drawing.Size(130, 20);
            this.transTitle_tb.TabIndex = 7;
            // 
            // transTitle_lbl
            // 
            this.transTitle_lbl.AutoSize = true;
            this.transTitle_lbl.Location = new System.Drawing.Point(10, 40);
            this.transTitle_lbl.Name = "transTitle_lbl";
            this.transTitle_lbl.Size = new System.Drawing.Size(60, 13);
            this.transTitle_lbl.TabIndex = 8;
            this.transTitle_lbl.Text = "Название:";
            // 
            // transSum_tb
            // 
            this.transSum_tb.Location = new System.Drawing.Point(10, 165);
            this.transSum_tb.Name = "transSum_tb";
            this.transSum_tb.Size = new System.Drawing.Size(84, 20);
            this.transSum_tb.TabIndex = 9;
            // 
            // addTranstitle_lb
            // 
            this.addTranstitle_lb.AutoSize = true;
            this.addTranstitle_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.addTranstitle_lb.Location = new System.Drawing.Point(10, 10);
            this.addTranstitle_lb.Name = "addTranstitle_lb";
            this.addTranstitle_lb.Size = new System.Drawing.Size(241, 17);
            this.addTranstitle_lb.TabIndex = 13;
            this.addTranstitle_lb.Text = "Добавление новой транзакции";
            // 
            // addTrans_btn
            // 
            this.addTrans_btn.Location = new System.Drawing.Point(80, 276);
            this.addTrans_btn.Name = "addTrans_btn";
            this.addTrans_btn.Size = new System.Drawing.Size(102, 38);
            this.addTrans_btn.TabIndex = 16;
            this.addTrans_btn.Text = "Добавить";
            this.addTrans_btn.UseVisualStyleBackColor = true;
            this.addTrans_btn.Click += new System.EventHandler(this.addTrans_btn_Click);
            // 
            // desc_tb
            // 
            this.desc_tb.Location = new System.Drawing.Point(10, 210);
            this.desc_tb.Multiline = true;
            this.desc_tb.Name = "desc_tb";
            this.desc_tb.Size = new System.Drawing.Size(242, 60);
            this.desc_tb.TabIndex = 17;
            // 
            // desc_lb
            // 
            this.desc_lb.AutoSize = true;
            this.desc_lb.Location = new System.Drawing.Point(10, 195);
            this.desc_lb.Name = "desc_lb";
            this.desc_lb.Size = new System.Drawing.Size(60, 13);
            this.desc_lb.TabIndex = 18;
            this.desc_lb.Text = "Описание:";
            // 
            // expend_rb
            // 
            this.expend_rb.AutoSize = true;
            this.expend_rb.Location = new System.Drawing.Point(10, 80);
            this.expend_rb.Name = "expend_rb";
            this.expend_rb.Size = new System.Drawing.Size(61, 17);
            this.expend_rb.TabIndex = 19;
            this.expend_rb.TabStop = true;
            this.expend_rb.Text = "Расход";
            this.expend_rb.UseVisualStyleBackColor = true;
            // 
            // income_rb
            // 
            this.income_rb.AutoSize = true;
            this.income_rb.Location = new System.Drawing.Point(80, 80);
            this.income_rb.Name = "income_rb";
            this.income_rb.Size = new System.Drawing.Size(57, 17);
            this.income_rb.TabIndex = 20;
            this.income_rb.TabStop = true;
            this.income_rb.Text = "Доход";
            this.income_rb.UseVisualStyleBackColor = true;
            // 
            // chooseCat_rb
            // 
            this.chooseCat_rb.FormattingEnabled = true;
            this.chooseCat_rb.Items.AddRange(new object[] {
            "Работа",
            "Милостыня",
            "Мамуля"});
            this.chooseCat_rb.Location = new System.Drawing.Point(13, 120);
            this.chooseCat_rb.Name = "chooseCat_rb";
            this.chooseCat_rb.Size = new System.Drawing.Size(121, 21);
            this.chooseCat_rb.TabIndex = 22;
            this.chooseCat_rb.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 326);
            this.Controls.Add(this.chooseCat_rb);
            this.Controls.Add(this.income_rb);
            this.Controls.Add(this.expend_rb);
            this.Controls.Add(this.desc_lb);
            this.Controls.Add(this.desc_tb);
            this.Controls.Add(this.addTrans_btn);
            this.Controls.Add(this.addTranstitle_lb);
            this.Controls.Add(this.chooseCat_lb);
            this.Controls.Add(this.transSum_lbl);
            this.Controls.Add(this.transTitle_tb);
            this.Controls.Add(this.transTitle_lbl);
            this.Controls.Add(this.transSum_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "NewTransaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chooseCat_lb;
        private System.Windows.Forms.Label transSum_lbl;
        private System.Windows.Forms.TextBox transTitle_tb;
        private System.Windows.Forms.Label transTitle_lbl;
        private System.Windows.Forms.TextBox transSum_tb;
        private System.Windows.Forms.Label addTranstitle_lb;
        private System.Windows.Forms.Button addTrans_btn;
        private System.Windows.Forms.TextBox desc_tb;
        private System.Windows.Forms.Label desc_lb;
        private System.Windows.Forms.RadioButton expend_rb;
        private System.Windows.Forms.RadioButton income_rb;
        private System.Windows.Forms.ComboBox chooseCat_rb;
    }
}