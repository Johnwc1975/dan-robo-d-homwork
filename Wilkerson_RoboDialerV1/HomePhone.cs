using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wilkerson_RoboDialerV1;

namespace Wilkerson_RoboDialerV1
{
    class HomePhone : Phone
    {
        public HomePhone(string phoneNumber, string companyName, string phoneType)
        : base(phoneNumber, companyName, phoneType)
        {

        }
    }
}