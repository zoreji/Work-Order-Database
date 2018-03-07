using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Work_Order
{
    public partial class Form1 : Form
    {
        List<work_order> orderList;
        DateTime time = new DateTime();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            time = DateTime.Now;
            orderList = new List<work_order>();
            lv_Database.Columns.Add("Date", 100);
            lv_Database.Columns.Add("WO#", 50);
            lv_Database.Columns.Add("Client", 200);
            lv_Database.Columns.Add("SN#", 100);
            lv_Database.Columns.Add("SE#", 50);
            lv_Database.Columns.Add("Description", 300);
            lv_Database.Columns.Add("Status", 100);
            tb_DATE.Text = time.ToString("MMM d, yyyy");
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
            if (!string.IsNullOrEmpty(tb_WOnum.Text) && ("WO#" != tb_WOnum.Text) && 
                !string.IsNullOrEmpty(tb_SEnum.Text) && ("SE#" != tb_SEnum.Text) && 
                !string.IsNullOrEmpty(tb_WOnum.Text))
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
                wo_item.WO_Date = tb_DATE.Text;
                wo_item.state = rb_Inprogress.Checked;
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
                //tb_WOnum.Text = "WO#";
                //tb_SEnum.Text = "SE#";
                //tb_SNnum.Text = "SN#";
                tb_DATE.Text = time.ToString("MMM d, yyyy");
            }
            else
            {
                MessageBox.Show("Error Invalid Value");
            }

        }
        /// <summary>
        /// Method:     loadList
        /// 
        /// Function:   find if there is a latest work order list in the system.
        ///             If not then creates a new work order list to save and sort.
        ///             else load the latest work order list and display it in the
        ///             list view box
        /// </summary>
        private void loadList()
        {

        }

        /// <summary>
        /// Method:     saveList
        /// 
        /// Function:   Saves and updates the current List<work_order>
        /// </summary>
        private void saveList(string path, int WO)
        {
            findWO(WO).Source_link = path;
        }
        /// <summary>
        /// Method:     findWO
        /// 
        /// Function:   runs throught the list and find the Work order
        /// </summary>
        /// <param name="WO"></param>
        /// <returns></returns>
        private work_order findWO(int WO)
        {
            int i = 0;
            int result = 0;
            if (orderList.Count > 0)
            {
                while (orderList.Count == i)
                {
                    if (orderList[i].WO_num == WO)
                        result = i;
                    i++;
                }
            }
            else
            {
                MessageBox.Show("Error", "Cannot find or no data to pull");
            }
            return orderList[result];
        }
        private void sortList()
        {

        }
        /// <summary>
        /// Method:     bt_Upload_Click
        /// 
        /// Function:   Load an open file dialog, select a file and add to the selected 
        ///             index in the listview WO# class. Save the link under the source
        ///             link and stores it into the List<work_order>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_Upload_Click(object sender, EventArgs e)
        {
            
            //DialogResult dialogResult = ofd_uploadFile.ShowDialog();
            //check if there is no error in WO# and openfileDialog for upload
            if (ofd_uploadFile.ShowDialog() == DialogResult.OK 
                && !string.IsNullOrEmpty(tb_WOnum.Text) 
                && ("WO#" != tb_WOnum.Text))
            {
                int wo = Convert.ToInt32(tb_WOnum.Text);

                //gets the file name
                string file = Path.GetFileName(ofd_uploadFile.FileName);
                
                try
                {
                    string createSubfolder = 
                        "C:\\Project\\Repos\\Work-Order-Database\\Work Order\\Work Order\\ErwinDatabase\\WO#"
                            + tb_WOnum.Text;
                    Console.WriteLine(createSubfolder);
                    //string text = File.ReadAllText(file);
                    Console.WriteLine(file);
                    //check if there is a file similar exists and check if there is a subfolder created
                    if (ofd_uploadFile.CheckFileExists && !File.Exists(createSubfolder))
                    {
                        Directory.CreateDirectory(createSubfolder);
                        // get the original file path copy and sent it to new subfolder created
                        File.Copy(ofd_uploadFile.FileName, createSubfolder +"\\"+ file);
                        // save into the source path into the list
                        saveList(createSubfolder + "\\" + file, wo);
                    }
                }
                catch(IOException)
                {
                    MessageBox.Show("Upload Error", "Unable to upload file to Database");
                }
            }
            else
            {
                MessageBox.Show("Invalid Work Order");
            }
            //Console.WriteLine(dialogResult);
        }
        /// <summary>
        /// Method:     lv_database_SelectedIndexChanged
        /// 
        /// Function:   When the list view row is selected, it obtain the WO# from the list view
        ///             and search the WO# in the List<work_order> and retreive the object work
        ///             order class and assign to current temp work order class. Adds each upload
        ///             file to a list box to review, change and delete.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lv_Database_SelectedIndexChanged(object sender, EventArgs e)
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

        private void tb_CLname_MouseClick(object sender, MouseEventArgs e)
        {
            tb_CLname.Text = null;
        }

        private void tb_SNnum_MouseClick(object sender, MouseEventArgs e)
        {
            tb_SNnum.Text = null;
        }
    }
}
