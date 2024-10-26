
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

            //foreach (Person person in personList)
            //{
            //    if (person.Age < 38) continue;
            //    WriteLine($"{person.FirstName} {person.LastName}, {person.Age}");
            //}

            //foreach (Person person in personList.Where(IsUnderThirtyEight))
            //{
            //    WriteLine($"{person.FirstName} {person.LastName}, {person.Age}");
            //}

            foreach (Person person in personList.Where(person => person.IsFemale && person.Age < 38))
            {
                WriteLine($"{person.FirstName} {person.LastName}, {person.Age}");
            }

            Action action1 = someAction; 
            Action<int,string> action2 = someAction;
            Action<Person, Person> action3 = (p1,p2) => WriteLine(p1 + " loves " + p2);

            Func<int> myFunc1 = someFunc;
            Func<string, int> myFunc2 = someFuncString;

            Action test = someAction;

            //Func<Person, bool> myFunc = person => person.IsFemale && person.Age < 38;

            //// person => person.IsFemale && person.Age < 38
            //foreach (Person person in personList.Where(myFunc))
            //{
            //    WriteLine($"{person.FirstName} {person.LastName}, {person.Age}");
            //}
        }



        static void someAction() {}
        static void someAction(int x, string y)
        {
        }
        static int someFunc()
        {
            return 1;
        }
        static int someFuncString(string x)
        {
            return 1;
        }
        static bool IsUnderThirtyEight(Person person)
        {
            return person.Age < 38;
        }
        
        static bool IsFemaleUnderThirtyEight(Person person)
        {
            return person.IsFemale && IsUnderThirtyEight(person);

        }
        static bool IsMaleUnderThirtyEight(Person person)
        {
            return !person.IsFemale && IsUnderThirtyEight(person);

        }
    }
}