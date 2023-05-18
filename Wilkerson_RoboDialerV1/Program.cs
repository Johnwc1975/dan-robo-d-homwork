using System;

namespace Wilkerson_RoboDialerV1
{
    public abstract class Phone
    {
        protected string CompanyName { get; private set; }
        protected string PhoneNumber { get; private set; }

        protected Phone(string companyName, string phoneNumber)
        {
            this.CompanyName = companyName;
            this.PhoneNumber = phoneNumber;
        }

        public abstract string Dial();
    }

    public class HomePhone : Phone
    {
        public HomePhone(string companyName, string phoneNumber)
            : base(companyName, phoneNumber) { }

        public override string Dial()
        {
            return $"Dialing {PhoneNumber}...";
        }
    }

    public class CellPhone : Phone
    {
        public CellPhone(string companyName, string phoneNumber)
            : base(companyName, phoneNumber) { }

        public override string Dial()
        {
            return $"Dialing 1+{PhoneNumber}...";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Phone[] phones = new Phone[10];

            phones[0] = new HomePhone("CompuTest", "(303) 985-5060");
            phones[1] = new CellPhone("Curtis Manufacturing", "(603) 532-4123");
            phones[2] = new HomePhone("Data Functions", "(800) 876-2524");
            phones[3] = new HomePhone("Donnay Repair", "(708) 397-3330");
            phones[4] = new HomePhone("ErgoNomic Inc", "(360) 434-3894");
            phones[5] = new HomePhone("ErgoSource", "(800) 969-4374");
            phones[6] = new CellPhone("Fox Bay Industries", "(800) 874-8527");
            phones[7] = new CellPhone("Glare-Guard", "(800) 545-6254");
            phones[8] = new CellPhone("Hazard Comm Specialists", "(407) 783-6641");
            phones[9] = new CellPhone("Komfort Support", "(714) 472-4409");

            foreach (Phone phone in phones)
            {
                Console.WriteLine($"{phone.Dial()}");
            }
        }
    }
}
