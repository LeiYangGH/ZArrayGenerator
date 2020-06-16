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
        private int length;

        public Permutator(IList<string> baseChars, int length)
        {
            this.baseChars = baseChars;
            this.length = length;
        }
        public IEnumerable<String> Permutate()
        {
            foreach (string ch in baseChars)
                yield return ch;
        }
    }
}
