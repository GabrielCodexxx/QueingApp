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
    public partial class CustomerView : Form
    {
        public CustomerView()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(timer1_tick);
            timer.Start();
        }

        public void timer1_tick(object sender, EventArgs e)
        {
            if(CashierClass.CashierQueue.Count > 0)
            {
                lblNowServing.Text = CashierClass.CashierQueue.Peek().ToString();
            }
            else
            {
                lblNowServing.Text = "No Customer in Queue";
            }
        }
        private void CustomerView_Load(object sender, EventArgs e)
        {

        }
    }
}
