using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text;
using static System.Console;

namespace CSharp_Delegates_Advans
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();
            personList.Add(new Person("Jane", "Doe", "820101-1020"));
            personList.Add(new Person("John", "Doe", "800101-2010"));
            personList.Add(new Person("Jim", "Doe", "780101-2010"));
            personList.Add(new Person("Jessica", "Doe", "900101-1020"));
            personList.Add(new Person("Jake", "Doe", "900101-2010"));
            personList.Add(new Person("Janice", "Doe", "920101-1020"));

            //Console.WriteLine(personList);

            //foreach (Person person in personList.Where(IsUnderThirty))
            //{
            //    WriteLine($"{person.FirstName} {person.LastName}, {person.Age}");
            //}

            foreach (Person person in personList)
            {
                //if (person.Age < 30) continue;
                WriteLine($"{person.FirstName} {person.LastName}, {person.Age}");
            }
            //foreach (Person person in personList.Where(person => person.IsFemale && person.Age < 30))
            //{
            //    WriteLine($"{person.FirstName} {person.LastName}, {person.Age}");
            //}

            //Func<Person, bool> myFunc = person => person.IsFemale && person.Age < 30;

            //// person => person.IsFemale && person.Age < 30
            //foreach (Person person in personList.Where(myFunc))
            //{
            //    WriteLine($"{person.FirstName} {person.LastName}, {person.Age}");
            //}
        }

        static bool IsUnderThirty(Person x)
        {
            return x.Age < 30;
        }
        //static bool IsUnderThirty(Person person)
        //{
        //    return person.Age < 30;
        //}
        static bool IsFemaleUnderThirty(Person person)
        {
            return person.IsFemale && IsUnderThirty(person);

        }
        static bool IsMaleUnderThirty(Person person)
        {
            return !person.IsFemale && IsUnderThirty(person);

        }
    }
}