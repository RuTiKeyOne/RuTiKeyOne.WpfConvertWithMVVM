using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WpfConvertWithMVVM.Model.Internet
{
    class Internet
    {
        #region Create method which check internet connection
        public bool CheckConnection()
        {
            try
            {
                using (WebClient client = new WebClient())
                using (client.OpenRead("http://google.com"))
                    return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
