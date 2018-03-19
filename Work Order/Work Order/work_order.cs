using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Work_Order
{
    /// <summary>
    /// Class:      work_order
    /// 
    /// Function:   A class object to give each new work order properties
    ///             and tags about the work order. Also save the source link
    ///             and the string array.
    /// </summary>
    class work_order
    {
        public int WO_num = 0;
        public int SE_num = 0;
        public string SN_num = "000 000";
        public int state = 0;
        public string Client_name = "Seicor Inc.";
        public string details = "AOT 100 Ton Elevator";
        public string WO_Date;
        public List<string> Source_link = new List<string>();
        public List<byte[]> Binary_Source_Link = new List<byte[]>();
        public string[] Get_wo_arr
        {
            get
            {
                return set_arr();
            }
        }
        /// <summary>
        /// Method:     set_arr
        /// 
        /// function:   Obtain all the information in the class arrange them in
        ///             a string array for the list view to obtain.
        /// </summary>
        /// <returns></returns>
        private string[] set_arr()
        {
            string[] WO_arr = new string[7];
            WO_arr[0] = WO_Date;
            WO_arr[1] = WO_num.ToString();
            WO_arr[2] = Client_name;
            WO_arr[3] = SN_num;
            WO_arr[4] = SE_num.ToString();
            WO_arr[5] = details;
            if (state == 1)
                WO_arr[6] = "Delivered";
            else
                WO_arr[6] = "Inprogress";
            return WO_arr;
        }
        public void ConvertAddToList()
        {
            if (Source_link.Count > 0)
            {
                foreach (string links in Source_link)
                {
                    var stream = new FileStream(links, FileMode.Open, FileAccess.Read);
                    var reader = new BinaryReader(stream);
                    Binary_Source_Link.Add(reader.ReadBytes((int)stream.Length));
                }
            }
        }
    }
}
