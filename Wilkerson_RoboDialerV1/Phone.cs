using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Wilkerson_RoboDialerV1
//{
//    class Phone
//    {
//        protected string phoneNumber;
//        protected string companyName;
//        protected string phoneType;

//        public Phone(string phoneNumber, string companyName, string phoneType)
//        {
//            this.phoneNumber = phoneNumber;
//            this.companyName = companyName;
//            this.phoneType = phoneType;
//        }

//        protected Phone(string phoneNumber, string companyName, string phoneType, string companyName, string phoneNumber) : this(phoneNumber, companyName, phoneType)
//        {
//            CompanyName = companyName;
//            PhoneNumber = phoneNumber;
//            this.companyName = companyName;
//        }

//        public virtual string Dial()
//        {
//            return $"Dialing {companyName} using {phoneNumber}...";
//        }

//        public override bool Equals(object? obj)
//        {
//            return obj is Phone phone &&
//                   phoneNumber == phone.phoneNumber &&
//                   companyName == phone.companyName &&
//                   phoneType == phone.phoneType &&
//                   CompanyName == phone.CompanyName &&
//                   PhoneNumber == phone.PhoneNumber;
//        }
//    }
//}namespace Hagen_RoboDialer

//{
namespace Wilkerson_RoboDialerV1
{
    class Phone
    {
        protected string phoneNumber;
        protected string companyName;
        protected string phoneType;

        public Phone(string phoneNumber, string companyName, string phoneType)
        {
            this.phoneNumber = phoneNumber;
            this.companyName = companyName;
            this.phoneType = phoneType;
        }

        public virtual string Dial()
        {
            return $"Dialing {companyName} using {phoneNumber}...";
        }
    }
}