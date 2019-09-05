using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Save_My_Files_To_USB.Main.tool
{
    public class USB
    {
        private DriveInfo usb {get;set;}
        public USB(DriveInfo d)
        {
            this.usb = d;
        }
        public List<USB> scan()
        {
            List<USB> AllUSB = new List<USB>();

            foreach(DriveInfo d in DriveInfo.GetDrives())
            {
                AllUSB.Add(new USB(d));
            }

            return AllUSB;
        }

    }
}
