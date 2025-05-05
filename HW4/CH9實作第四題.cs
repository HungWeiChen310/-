using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class PhoneList
    {
        public string HomePhone { get; set; }
        public string BusinessPhone { get; set; }
        public string CellPhone { get; set; }
    }

    public class Cards
    {
        public string Name { get; set; }
        public string Occupation { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public PhoneList Phone { get; set; } = new PhoneList();
        public string GetCard() =>
$@"Name : {Name}
Job  : {Occupation}
Age  : {Age}
Email: {Email}
Home : {Phone.HomePhone}
Work : {Phone.BusinessPhone}
Cell : {Phone.CellPhone}";
    }
}

