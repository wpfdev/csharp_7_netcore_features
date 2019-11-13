using System;
using System.Collections.Generic;

namespace csharp_7_features_notes
{
    public class NewSwitchFeatures : ITestableClass
    {
        private void DisplayPersonInfo(object person)
        {
            try
            {
                switch (person)
                {
                    case Manager manager when (!string.IsNullOrEmpty(manager.Email) && manager.Email.Equals("admin@email.com", StringComparison.InvariantCultureIgnoreCase)):
                        Console.WriteLine($"CEO is working on tasks {string.Join(",", manager.TasksCodes)}");
                        break;
                    case Manager manager:
                        Console.WriteLine($"Manager {manager.Name} ({manager.Email ?? "[no email]"}) is working on tasks {string.Join(",", manager.TasksCodes)}");
                        break;
                    case Programmer programmer:
                        Console.WriteLine($"Programmer {programmer.Name} ({programmer.Email ?? "[no email]"}) is skilled by {string.Join(",", programmer.SkillNames)}");
                        break;
                    case null:
                        Console.WriteLine($"Object {nameof(person)} is null");
                        break;
                    default:
                        Console.WriteLine($"Unknown object");
                        break;
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
        public void RunTest()
        {
            var ceo = new Manager
            {
                Name = "Dmitry",
                Email = "admin@email.com",
                TasksCodes = new List<int> { 7, 8, 9 }
            };
            var manager = new Manager
            {
                Name = "Alex",
                Email = "alx@email.com",
                TasksCodes = new List<int> { 1, 2, 3, 4, 5 }
            };
            var programmer = new Programmer
            {
                Name = "Andrey",
                Email = "andrey@aprogrammer.ru",
                SkillNames = new List<string> { "C#", ".NET CORE", "ASP.NET", "SQL", "JavaScript", "VueJS", "Angular" }
            };
            DisplayPersonInfo(manager);
            DisplayPersonInfo(programmer);
        }
    }
}