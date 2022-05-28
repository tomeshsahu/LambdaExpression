using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{ 
    public class lambdaExp
    {
        List<Person> personList = new List<Person>();
        public void AddDefaultData()
        {
            personList.Add(new Person { SSN = 1, Name = "Tomesh", Address = "Bhilai", Age = 28 });
            personList.Add(new Person { SSN = 2, Name = "Ramesh", Address = "Mumbai", Age = 31 });
            personList.Add(new Person { SSN = 3, Name = "Suresh", Address = "Goa", Age = 70 });
            personList.Add(new Person { SSN = 4, Name = "Arun", Address = "Dhule", Age = 70 });
            personList.Add(new Person { SSN = 5, Name = "Girish", Address = "Shirpur", Age = 24 });
            personList.Add(new Person { SSN = 6, Name = "Rohit", Address = "Dhule", Age = 26 });
            personList.Add(new Person { SSN = 7, Name = "Manda", Address = "Warud", Age = 65 });
            personList.Add(new Person { SSN = 8, Name = "Harshit", Address = "Mumbai", Age = 16 });
            Display(personList);
        }
        public void Display(IEnumerable<Person> list)
        {
            foreach (var person in list)
            {
                Console.WriteLine(person.SSN + " " + person.Name + " " + person.Address + " " + person.Age);
            }
        }
        
        public void GetTopRecords()
        {
            Console.WriteLine();
            Console.WriteLine("Get Top Two Record ");
            var Result = this.personList.Where(x => x.Age < 60).Take(2);
            Display(Result);
        }

        public void GetRecords()
        {
            Console.WriteLine();
            Console.WriteLine("Get Records between 13 to 18 age ");
            var result = this.personList.Where(x => x.Age > 13 && x.Age < 18);
            Display(result);
        }

    }
}
