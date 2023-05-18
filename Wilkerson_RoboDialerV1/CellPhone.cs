using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wilkerson_RoboDialerV1;

//namespace Wilkerson_RoboDialerV1;

//class CellPhone : Phone
//{
//    public CellPhone(string phoneNumber, string companyName, string phoneType)
//    : base(phoneNumber, companyName, phoneType)
//    {
//    }

//    public override string Dial()
//    {
//        string prefix = "1+";
//        string formattedPhoneNumber = phoneNumber.Replace("(", "").Replace(")", "").Replace(" ", "");
//        return $"Dialing {companyName} using {prefix}{formattedPhoneNumber}...";
//    }
//}

namespace Wilkerson_RoboDialerV1
{
    class CellPhone : Phone
    {
        public CellPhone(string phoneNumber, string companyName, string phoneType)
        : base(phoneNumber, companyName, phoneType)
        {
        }

        public override string Dial()
        {
            string prefix = "1+";
            string formattedPhoneNumber = phoneNumber.Replace("(", "").Replace(")", "").Replace(" ", "");
            return $"Dialing {companyName} using {prefix}{formattedPhoneNumber}...";
        }
    }
}
