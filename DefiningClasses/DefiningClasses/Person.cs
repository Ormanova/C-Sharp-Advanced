using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Person
    {
        //fields - характеристиките на класа.Private - модификатор за достъп.Може да бъде public, private, protected.
        //Private се достъпва само в класа, а публик може и от извън класа. Затова по-добре да са привате, за да могат да се модифицират само в класа. 
        private string name;
        private int age;
     
        // конструктор по подразбиране
        public Person()
        {
            // целта му е да създаде празен обект от съответния клас
            // name : null;
            // age: 0
            this.Name = "No name";
            this.Age = 1;
        }
        // конструктор с параметри, който създава обект и приема име, години...
        public Person(int age): this()
        {
           this.Age = age;
        }
        public Person(string name, int age): this(age)
        {
            this.Name = name;
            
        }

        //methods

        // properties - създаването им позволява да се дава достъп до private полетата чрез get, а чрез set задаваме стойности, ограничения, тип валидация.
        public string Name 
        { 
            get { return name; }
            set { name = value; } 
        }
        public int Age 
        {
            get { return age; }
            set { age = value; } 
        }
    }
}
