using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncWebContent.Classes
{
    public class HttpResponseArgs : EventArgs
    {
        public string httpBody { get; set; }
        public int responseCode { get; set; }
    }
}
