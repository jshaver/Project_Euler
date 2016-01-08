using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Euler.Objects;

namespace Problems
{
    public class Problem001 : IProblem
    {

        public List<ArgType> GetArgTypes()
        {
            return new List<ArgType>() {ArgType.PositiveInteger};
        }

        public List<string> Solve(List<Argument> input)
        {
            List<string> results = new List<string>();
            int limit;
            int result = 0;

            if (int.TryParse(input.First().Value.ToString(), out limit))
            {
                for (int i = 1; i < limit; i++)
                {
                    if ((i % 3 == 0) || (i % 5 == 0))
                        result += i;
                }
            }

            results.Add(result.ToString());

            return results;
        }


    }
}
