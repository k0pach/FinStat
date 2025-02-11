using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinStat2
{
    public partial class Form2 : Form
    {
        public event Action<Transaction> TransactionAdded;

        public Form2()
        {
            InitializeComponent();
            chooseCat_rb.Visible = true;
            chooseCat_rb.Items.Clear();
            expend_rb.CheckedChanged += RadioButton_CheckedChanged;
            income_rb.CheckedChanged += RadioButton_CheckedChanged;
            
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateComboBoxList();
        }

        private void UpdateComboBoxList()
        {
            if (expend_rb.Checked)
            {
                chooseCat_rb.Items.Clear();
                chooseCat_rb.Items.AddRange(GlobalVars.expendList.ToArray());
                
            }
            if (income_rb.Checked)
            {
                chooseCat_rb.Items.Clear();
                chooseCat_rb.Items.AddRange(GlobalVars.incomeList.ToArray());
            }

        }

        private string whatIsTransType()
        {
            if (expend_rb.Checked)
            {
                return "Расход";
            }

            if (income_rb.Checked)
            {
                return "Доход";
            }
            return "";
        }



        private void addTrans_btn_Click(object sender, EventArgs e)
        {
            double sum;
            if(transSum_tb.Text == "")
            {
                sum = 0;
            }
            else if (!double.TryParse(transSum_tb.Text, out sum))
            {
                MessageBox.Show("Введите корректную сумму.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            Transaction trans = new Transaction(transTitle_tb.Text, whatIsTransType(), chooseCat_rb.Text, sum, desc_tb.Text);
            TransactionAdded?.Invoke(trans);
            TransactionAdded = null; //2 вариант отписки
            this.Close();
            


        }
    }
}
