using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZArrayGenerator
{
    public class Permutator
    {
        private IList<string> baseChars;
        private IList<string> upChars;

        public Permutator(IList<string> baseChars, IList<string> upChars)
        {
            this.baseChars = baseChars;
            this.upChars = upChars;
        }


        public IEnumerable<string> Permutate(string prefix, int pos)
        {
            foreach (string s in baseChars.Where(c=>c.CompareTo(upChars[pos-1])>=0))
            {
                if (pos == 1)
                {
                    yield return prefix + s;
                }
                else
                {
                    foreach (string s2 in Permutate(prefix + s, pos - 1))
                    {
                        yield return s2;
                    }
                }
            }

        }
    }
}
