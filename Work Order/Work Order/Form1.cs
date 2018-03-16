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
using System.Data.SqlClient;
using System.Threading;


namespace Work_Order
{
    public partial class Form1 : Form
    {
        List<work_order> orderList;
        DateTime time = new DateTime();
        int itemSelect = 0;
        string connectString = null;
        SqlConnection cnn;
        Thread sqlThread;
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
            //InitialSql();
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
                if (rb_Delivered.Checked)
                    wo_item.state = 1;
                //Adds the new created workorder object into the List<work_order>
                orderList.Add(wo_item);

                //A while loop to add each item in the List to the listview database
                int i = 0;
                while (i != orderList.Count)
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
        /// Method:     tempItems
        /// 
        /// Function:   Create 50 random items, add to the list, and displays it into
        ///             the listview for testing purpose
        /// </summary>
        private void tempItems()
        {
            ListViewItem item;
            lv_Database.Items.Clear();
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                work_order order = new work_order();
                orderList.Add(order);
                orderList[i].WO_num = i;
                orderList[i].SE_num = rng.Next(200);
                orderList[i].SN_num = rng.Next(500) + " " + rng.Next(500);
                orderList[i].WO_Date = tb_DATE.Text;
                if (rb_Delivered.Checked)
                    orderList[i].state = 1;
                item = new ListViewItem(orderList[i].Get_wo_arr);
                lv_Database.Items.Add(item);
            }
        }
        /// <summary>
        /// Method:     writeTags
        /// 
        /// function:   Create a StreamWriter to create a text file that holds
        ///             all the information in each Work Order. Deletes any tag file
        ///             created earlier, than re-create a new text file call tags and 
        ///             sorts it with all the uploaded files
        /// </summary>
        /// <param name="path"></param>
        /// <param name="order"></param>
        private void writeTags(string path, work_order order)
        {
            StreamWriter file;
            if (File.Exists(path + "\\tags.txt"))
            {
                File.Delete(path + "\\tags.txt");
            }
            file = new StreamWriter(path + "\\tags.txt");
            foreach (string tags in order.Get_wo_arr)
            {
                file.WriteLine(tags);
            }
            foreach (string tags in order.Source_link)
            {
                file.WriteLine(tags);
            }
            file.Close();
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
        //private void SaveDB()
        //{
        //    try
        //    {
        //        Application app = new Application();
        //        string execPath
        //    }
        //}


        /// <summary>
        /// Method:     saveList
        /// 
        /// Function:   Saves and updates the current List<work_order>
        /// </summary>
        private void saveList(string path, int WO)
        {
            findWO(WO).Source_link.Add(path);
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
                while (orderList.Count > i)
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
        /// <summary>
        /// Method:     ConnectSQLServer
        /// 
        /// Function:   Connect to the SQL Server, login to the Server
        ///             ensure that it connected to the correct Data Source
        /// </summary>
        private void ConnectSQLServer()
        {
            connectString = "Data Source=DESKTOP-D0ITPG7\\SEICORSSQL;" +
                            "Initial Catalog=master;Integrated Security=True";
            cnn = new SqlConnection(connectString);
        }
        private void InsertSQL(int i)
        {
            ConnectSQLServer();
            SqlCommand sql;
            try
            {
                cnn.Open();

                string query =  "INSERT INTO WorkOrder " +
                                "VALUES (@WO#, @Date, @SE#, @Client, @SN#, @Description, @Status)";
                sql = new SqlCommand(query, cnn);
                    
                //           orderList[i].WO_num + ",'" +
                //           orderList[i].WO_Date + "'," +
                //           orderList[i].SN_num + "'," +
                //           orderList[i].Client_name + "','" +
                //           orderList[i].details + "','" +
                //           orderList[i].state + ")";
                sql.Parameters.Add("@WO#", orderList[i].WO_num);
                sql.Parameters.Add("@Date", orderList[i].WO_Date);
                sql.Parameters.Add("@SE#", orderList[i].SE_num);
                sql.Parameters.Add("@Client", orderList[i].Client_name);
                sql.Parameters.Add("@SN#", orderList[i].SN_num);
                sql.Parameters.Add("@Description", orderList[i].details);
                sql.Parameters.Add("@Status", orderList[i].state);
                sql.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Failed to Insert Values");
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }

        }
        private void InitialSqlTable()
        {
            ConnectSQLServer();
            string query =  "CREATE TABLE WorkOrder (" +
                            "WO# int," +
                            "Date varchar(225) NOT NULL," +
                            "SE# int," +
                            "Client varchar(225)," +
                            "SN# varchar(225)," +
                            "Description varchar(225)," +
                            "Status Bit" +
                            ");";
            SqlCommand sqlCommand = new SqlCommand(query, cnn);
            try
            {
                cnn.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Table Created Successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Table failed to create");
            }
            finally
            {
                if(cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }
        private void DeleteSqlTable()
        {
            ConnectSQLServer();
            string query = "DROP TABLE WorkOrder";
            SqlCommand sqlCommand = new SqlCommand(query, cnn);
            try
            {
                cnn.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Table Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Table failed to Delete");
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }
        private void InitialThreads()
        {

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
                && (lv_Database.SelectedIndices.Count > 0))
            {
                //gets the file name
                string file = Path.GetFileName(ofd_uploadFile.FileName);
                
                try
                {
                    string createSubfolder = 
                        "C:\\Project\\Repos\\Work-Order-Database\\Work Order\\Work Order\\ErwinDatabase\\WO#"
                            + orderList[itemSelect].WO_num;
                    Console.WriteLine(createSubfolder);
                    //string text = File.ReadAllText(file);
                    Console.WriteLine(file);
                    //check if there is a file similar exists and check if there is a subfolder created
                    if (ofd_uploadFile.CheckFileExists && !File.Exists(createSubfolder +"\\" + file))
                    {
                        Directory.CreateDirectory(createSubfolder);
                        // get the original file path copy and sent it to new subfolder created
                        File.Copy(ofd_uploadFile.FileName, createSubfolder +"\\"+ file);
                        // save into the source path into the list
                        saveList(createSubfolder + "\\" + file, orderList[itemSelect].WO_num);
                        //writes and save the tags assign to the work order
                        writeTags(createSubfolder, orderList[itemSelect]);
                    }
                    //if there is a path already in place. copy and place in the destination
                    else
                    {
                        File.Copy(ofd_uploadFile.FileName, createSubfolder + "\\" + file);
                        writeTags(createSubfolder, orderList[itemSelect]);
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
            //clear listbox
            lb_links.Items.Clear();
            Console.WriteLine(lv_Database.SelectedIndices.Count);
            //checks if an item is selected in the list view  
            if (lv_Database.SelectedIndices.Count > 0)
            {
                //save the index where user selected
                itemSelect = lv_Database.SelectedIndices[0];
                Console.WriteLine(itemSelect.ToString());
                //check if the source is empty
                if (orderList[itemSelect].Source_link != null)
                {
                    //add and display the source into the list box
                    foreach (string itm in orderList[itemSelect].Source_link)
                    {
                        lb_links.Items.Add(itm);
                    }
                }
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

        private void bt_Change_Click(object sender, EventArgs e)
        {
            tempItems();
            //Console.WriteLine(lv_Database.SelectedIndices[0]);
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            ListViewItem obj;
            orderList.Remove(orderList[itemSelect]);
            lv_Database.Items.Clear();
            foreach(work_order itm in orderList)
            {
                obj = new ListViewItem(itm.Get_wo_arr);
                lv_Database.Items.Add(obj);
            }
        }

        private void bt_CreateTB_Click(object sender, EventArgs e)
        {
            InitialSqlTable();
        }

        private void bt_DeleteTB_Click(object sender, EventArgs e)
        {
            DeleteSqlTable();
        }

        private void bt_Insert_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (orderList.Count > i)
            {
                InsertSQL(i);
                i++;
            }
        }
    }
}
