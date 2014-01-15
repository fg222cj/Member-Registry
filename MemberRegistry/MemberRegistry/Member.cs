using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistry
{
    public class Member : IComparable, IComparable<Member>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelephoneNumber { get; set; }
        public int IdNumber { get; set; }

        public Member(string firstName, string lastName, string telephoneNumber, int idNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            TelephoneNumber = telephoneNumber;
            IdNumber = idNumber;
        }

        public int CompareTo(object obj)
        {
            return CompareTo(obj as Member);
        }

        public int CompareTo(Member other)
        {
            return LastName.CompareTo(other.LastName);
        }

        public override string ToString()
        {
            return LastName + ", " + FirstName;
        }
    }
}
