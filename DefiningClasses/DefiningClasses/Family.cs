using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        //fields
        private List<Person> familyMembers;

        //constructor
        public Family()
        {
            this.familyMembers = new List<Person>();
        }

        // properties

       // методи

         public void AddMember(Person member)
        {
            this.familyMembers.Add(member);
        }
        public Person GetOlderMembers()
        {
            // от списъка с обекти вземи ми максималния елемент, като на всеки мембър вземаме максималните години
            
            int maxAge = this.familyMembers.Max(member => member.Age);
            return this.familyMembers.First(member => member.Age == maxAge);
        }
    }
}
