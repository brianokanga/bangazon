using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFundamentals
{
    public class Dictionary
    {
        Dictionary<string, int> bowlingScores = new Dictionary<string, int>()
        {
            { "Bubba", 40 },
            { "Louis", 120 },
            { "Mary Jane", 200 }
        };

    //    Console.WriteLine(bowlingScores["Bubba"]);

    }

}
