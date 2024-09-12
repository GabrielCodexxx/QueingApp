using System;
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
    public partial class Form1 : Form
    {
        private CashierClass cashier;
        public Form1()
        {
            InitializeComponent();
            cashier = new CashierClass();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            string generatedNumber = cashier.CashierGeneratedNumber("P - ");
            if (!string.IsNullOrEmpty(generatedNumber))
            {
                lblQueue.Text = generatedNumber;
                CashierClass.getNumberInQueue = lblQueue.Text;
                CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
            }
            else
            {
                MessageBox.Show("Queue limit reached. No more numbers can be generated.");
            }
        }
    }
}