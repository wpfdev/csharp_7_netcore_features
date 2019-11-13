using System;
using System.Collections.Generic;

namespace csharp_7_features_notes
{
    public class PatternMatchning : ITestableClass
    {
        private static void DisplayPersonInfo(object person)
        {
            if (person is Manager manager)
            {
                Console.WriteLine($"Manager {manager.Name} ({manager.Email ?? "[no email]"}) is working on tasks {string.Join(",", manager.TasksCodes)}");
            }
            if (person is Programmer programmer)
            {
                Console.WriteLine($"Programmer {programmer.Name} ({programmer.Email ?? "[no email]"}) is skilled by {string.Join(",", programmer.SkillNames)}");
            }
        }
        public void RunTest()
        {
            var manager = new Manager
            {
                Name = "Alex",
                TasksCodes = new List<int> { 1, 2, 3, 4, 5 }
            };
            var programmer = new Programmer
            {
                Name = "Andrey",
                Email = "andrey@aprogrammer.ru",
                SkillNames = new List<string> { "C#", ".NET CORE", "ASP.NET", "SQL", "JavaScript", "VueJS", "Angular" }
            };
            DisplayPersonInfo(programmer);
            DisplayPersonInfo(manager);
        }
    }
    public class Manager
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public List<int> TasksCodes { get; set; }
    }
    public class Programmer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public List<string> SkillNames { get; set; }
    }
}