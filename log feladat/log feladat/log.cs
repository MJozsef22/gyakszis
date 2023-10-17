using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log_feladat
{
    internal class log
    {
        public string IPAddress { get; private set; }
        public string Type { get; private set; }

        public log(string s)
        {

            IPAddress = s.Substring(s.IndexOf('8') + 1, 14).Trim();
            Type = s.Substring(38, 7).Trim();
        }
    }
}
