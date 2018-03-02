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
            lv_Database.Columns.Add("WO#", 50);
            lv_Database.Columns.Add("Client", 200);
            lv_Database.Columns.Add("SN#", 100);
            lv_Database.Columns.Add("SE#", 50);
            lv_Database.Columns.Add("Description", 300);
            lv_Database.Columns.Add("Status", 100);
        }
        /// <summary>
        /// Method:     bt_Create_New_WO_Click
        /// Function:   User click a button and create a new work order to add
        ///             into the database with new WO#, SE#, SN#, Client name,
        ///             and description of the order. Automaticaly sets the 
        ///             status of the work order to inprogress.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_Create_New_WO_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_WOnum.Text) && ("WO#" != tb_WOnum.Text) && !string.IsNullOrEmpty(tb_SEnum.Text) && ("SE#" != tb_SEnum.Text))
            {
                ListViewItem itm;
                //Clear the list view
                lv_Database.Items.Clear();
                //Creates a new workorder object
                work_order wo_item = new work_order();
                wo_item.SE_num = Convert.ToInt32(tb_SEnum.Text);
                wo_item.WO_num = Convert.ToInt32(tb_WOnum.Text);
                wo_item.SN_num = tb_SNnum.Text;
                wo_item.Client_name = tb_CLname.Text;
                //Adds the new created workorder object into the List<work_order>
                orderList.Add(wo_item);

                //A while loop to add each item in the List to the listview database
                int i = 0;
                while(i != orderList.Count)
                {
                    itm = new ListViewItem(orderList[i].Get_wo_arr);
                    lv_Database.Items.Add(itm);
                    i++;
                }
                //reset the textbox into the default texts
                tb_WOnum.Text = "WO#";
                tb_SEnum.Text = "SE#";
            }
            else
            {
                MessageBox.Show("Error Invalid Value");
            }

        }

        private void sortList()
        {

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

        private void tb_SEnum_MouseClick(object sender, MouseEventArgs e)
        {
            tb_SEnum.Text = null;
        }

        private void lv_Database_ColumnClick(object sender, ColumnClickEventArgs e)
        {

        }
    }
}
