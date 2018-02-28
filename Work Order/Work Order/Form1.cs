using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Work_Order
{
    public partial class Form1 : Form
    {
        List<work_order> orderList;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            orderList = new List<work_order>();
        }

        private void bt_Create_New_WO_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_WOnum.Text) && ("WO#" != tb_WOnum.Text))
            {
                int wo_num = Convert.ToInt32(tb_WOnum.Text);
                work_order wo_item = new work_order();
                wo_item.WO_num = wo_num;
                orderList.Add(wo_item);
                int i = 0;
                while(i != orderList.Count)
                {
                    lb_Database.Items.Add(orderList[i].WO_num.ToString());
                    i++;
                }
            }
            else
            {
                MessageBox.Show("Error Invalid Value");
            }

        }
        private void tb_WOnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_WOnum_MouseClick(object sender, MouseEventArgs e)
        {
            tb_WOnum.Text = null;
        }
    }
}
