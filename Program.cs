using System.Collections.Generic;
using System;

namespace csharp_7_features_notes
{
    class Program
    {
        static void Main(string[] args)
        {
            var tests = new Dictionary<string, ITestableClass>();
            tests.Add("WorkWithTuples", new WorkWithTuples());
            tests.Add("PatternMatching", new PatternMatchning());
            tests.Add("SwitchFeatures", new NewSwitchFeatures());

            tests["SwitchFeatures"].RunTest();
        }
    }
}
