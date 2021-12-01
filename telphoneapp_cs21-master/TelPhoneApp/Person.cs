using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelPhoneApp {
    public class Person {
        public string Name { get; set; }
        public string Phone { get; set; }
        public Person(string n = "", string p = "") {
            Name = n;
            Phone = p;
        }
        public override string ToString() {
            return $"Name: {Name}, Phone: {Phone}";
        }
    }
}
