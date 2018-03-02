﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public bool state = false;
        public string Client_name = "Seicor Inc.";
        public string details = "AOT 100 Ton Elevator";
        public string WO_Date;
        /// <summary>
        /// Method:     Source_link
        /// 
        /// Function:   A method that acquire the source of the uploaded files
        ///             and saves as string to refer back to.
        /// </summary>
        public static string Source_link
        {
            get
            {
                return Source_link;
            }
            set
            {
                Source_link = value;
            }
        }
        public string[] Get_wo_arr
        {
            get
            {
                return set_arr();
            }
        }
        private string[] set_arr()
        {
            string[] WO_arr = new string[6];
            WO_arr[0] = WO_num.ToString();
            WO_arr[1] = Client_name;
            WO_arr[2] = SN_num;
            WO_arr[3] = SE_num.ToString();
            WO_arr[4] = details;
            if (state)
                WO_arr[5] = "Delivered";
            else
                WO_arr[5] = "Inprogress";
            return WO_arr;
        }

    }
}
