using System.Net;

namespace WpfConvertWithMVVM.Model.Internet
{
    //The class implements checking the internet connection required for the api to work.
    class Internet
    {
        //Create method which check internet connection
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
    }
}
