using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZArrayGenerator
{
    public class Permutator
    {
        private IList<char> baseChars;
        private IList<char> lowChars;
        private IList<char> upChars;

        public Permutator(IList<char> baseChars, IList<char> lowChars, IList<char> upChars)
        {
            this.baseChars = baseChars;
            this.lowChars = lowChars;
            this.upChars = upChars;
        }


        public IEnumerable<string> Permutate(char[] strchars, int pos)
        {
            foreach (char s in baseChars.Where(c =>
            c.CompareTo(lowChars[pos]) >= 0
            && c.CompareTo(upChars[pos]) <= 0))
            {
                strchars[pos] = s;
                if (pos >= upChars.Count - 1)
                {
                    yield return new string(strchars);
                }
                else
                {
                    foreach (string s2 in Permutate(strchars, pos + 1))
                    {
                        yield return s2;
                    }
                }
            }

        }
    }
}
