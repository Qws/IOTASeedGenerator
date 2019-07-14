using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.DataTransfer;

namespace IOTASeedGenerator
{
    class ClipboardHandler
    {
        private DataPackage dataPackage;

        public ClipboardHandler()
        {
            dataPackage = new DataPackage();
        }

        public void SetClipboard(Seed seed)
        {
            dataPackage.SetText(seed.Value);
            Clipboard.SetContent(dataPackage);
        }
    }
}
