using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueingApp
{

    public partial class CashierWindowQueueForm : Form
    {
        private CashierClass cashier;
        private Timer timer;


        public CashierWindowQueueForm(CashierClass cashier)
        {
            InitializeComponent();
            this.cashier = cashier;


            timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(timer1_tick);
            timer.Start();
            listCashierQueue.View = View.Details;
            listCashierQueue.Columns.Clear();
            listCashierQueue.Columns.Add("Cashier Number", 200, HorizontalAlignment.Left);
        }

        private void timer1_tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }


        public void DisplayCashierQueue(IEnumerable<string> cashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (string obj in cashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }


        public CashierWindowQueueForm()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count > 0)
            {
                CashierClass.CashierQueue.Dequeue();
                DisplayCashierQueue(CashierClass.CashierQueue);
            }
        }
    }
}
