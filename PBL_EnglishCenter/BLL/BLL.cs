using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL_EnglishCenter.BLL
{
    public class BLL
    {
        private static BLL _Instance;
        public static BLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL();
                return _Instance;
            }
            private set { }
        }
        private BLL()
        {

        }
        //public List<course> GetAllCourse()
        //{

        //}

        //public List<user>
    }
}
