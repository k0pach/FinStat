using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinStat2
{
    
    public partial class Form1 : Form, IObserver
    {
        Form2 f2;
        private double balance;
        private double limit;
        private double totalExpenses;
        private ConcreteObservable limitObservable;

        public Form1()
        {
            InitializeComponent();
            dataGridView.Columns.Add("TitleColumn", "Название");
            dataGridView.Columns.Add("TypeColumn", "Тип");
            dataGridView.Columns.Add("CategoryColumn", "Категория");
            dataGridView.Columns.Add("SumColumn", "Сумма");
            dataGridView.Columns.Add("DescriptionColumn", "Описание");

            limit = double.Parse(limit_tb.Text);
            balance = double.Parse(balance_tb.Text);
            totalExpenses = 0;
            limitObservable = new ConcreteObservable();
            limitObservable.AddObserver(this);

            limit_tb.TextChanged += Limit_tb_TextChanged;
        }

        private void Limit_tb_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(limit_tb.Text, out double newLimit))
            {
                limit = newLimit;
                limitObservable.NotifyObservers();
            }
        }
        public void Update()
        {
            if (totalExpenses > limit)
            {
                alert_tb.Visible = true;
            }
            else
            {
                alert_tb.Visible = false;
            }
        }
        private void openAddTrans_btn_Click(object sender, EventArgs e)
        {
            f2 = new Form2();
            f2.TransactionAdded += F2_TransactionAdded;
            f2.ShowDialog();

        }

        private void F2_TransactionAdded(Transaction transaction)
        {
            f2.TransactionAdded -= F2_TransactionAdded;//1 вариант отписки
            dataGridView.Rows.Add(transaction.Title, transaction.TransType, transaction.Category, transaction.Sum, transaction.Description);

            if (transaction.TransType == "Доход")
            {
                balance += transaction.Sum;
            }
            else if (transaction.TransType == "Расход")
            {
                balance -= transaction.Sum;
                totalExpenses += transaction.Sum;
            }

            balance_tb.Text = balance.ToString();
            limitObservable.NotifyObservers();

        }


    }
}
