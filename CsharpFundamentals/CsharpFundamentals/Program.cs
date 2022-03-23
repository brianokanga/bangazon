using System;
using System.Collections.Generic;

namespace CsharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Person lulu = new Person(
                "Lulu",
                new DateTime(1932, 6,22),
                new List<string>() { "Knitting", "Break dancing", "Lion taming" }
                ); 
        }
    }
}
