using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class Permutations
    {
        public void Permute(String s, String answer)
        {
            if (s.Length == 0)
            {
                return;
            }
            for (int i = 0; i < s.Length; i++)
            {
                char ap = s[i];
                String left_substr = s.Substring(0, i);
                String right_substr = s.Substring(i + 1);
                String result = left_substr + right_substr;
                Permute(result, answer + ap);
            }
        }

    }
}
