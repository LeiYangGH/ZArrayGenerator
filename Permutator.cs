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

        public Permutator(IList<string> baseChars)
        {
            this.baseChars = baseChars;
        }


        public IEnumerable<string> CharsRange(string prefix, int pos)
        {
            foreach (string s in baseChars)
            {
                if (pos == 1)
                {
                    yield return prefix + s;
                }
                else
                {
                    foreach (string s2 in CharsRange(prefix + s, pos - 1))
                    {
                        yield return s2;
                    }
                }
            }

        }
    }
}
