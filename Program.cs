using System;
using System.Collections.Generic;
using System.Linq;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZArrayGenerator
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            IList<string> baseChars = new List<string>() { "0","1","2","3" };
            int length = 3;
            Permutator permutator = new Permutator(baseChars, length);
            //permutator.Permutate("", length);
            foreach (string s in permutator.Permutate("",length))
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("end main");
            Console.ReadKey();
        }
    }
}
