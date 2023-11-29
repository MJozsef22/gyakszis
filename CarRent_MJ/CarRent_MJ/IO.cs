using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CarRent_MJ
{
    public class IO
    {
        public string carName { get; private set; }
        public string carType { get; private set; }

        public int carDistance { get; private set; }

        public IO(string s)
        {
            string[] temp = s.Split(';');
            carName = temp[0];
            carType = temp[1];
            carDistance = int.Parse(temp[2]);
        }
    }
}
