using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    public class Person {
        private int age;
        private string name;
        public string Name {
            get { return name; }
            set { name = value; }
        }
        public int Age {
            get { return age; }
            set {
                if (value < 0 && value > 150)
                {
                    age = 18;
                }
                else {
                    age = value;
                }
            }
        }
        public Person(string name, int age) {
            Name = name;
            Age = age;
        }
        public void ShowPersonData() {
            Console.WriteLine($"Name: {name},age: {age}");
        }
        
    }
}
