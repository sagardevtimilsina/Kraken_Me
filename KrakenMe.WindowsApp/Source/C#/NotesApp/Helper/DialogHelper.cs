using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace Helper
{
    public static class DialogHelper
    {
        public async static void ShowMessageBox(string message)
        {
            MessageDialog dialogbox = new MessageDialog(message);
            await dialogbox.ShowAsync();
        }
    }
}
