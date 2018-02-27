using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Order
{
    class work_order
    {
        public int WO_num;
        public int SE_num;
        public string SN_num;
        public bool state;

        private static int wo_NUM
        {
            get
            {
                return wo_NUM;
            }
            set
            {
                wo_NUM = value;
            }
        }


    }
}
