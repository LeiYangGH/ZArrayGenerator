using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZArrayGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //if (DateTime.Now > new DateTime(2020, 6, 15))
            //{
            //    Application.Exit();
            //    Environment.Exit(0);
            //}

        }

        //private IList<String> GenerateZnums(int n)
        //{

        //}
        public static string IntToString(int value, char[] baseChars)
        {
            string result = string.Empty;
            int targetBase = baseChars.Length;

            do
            {
                result = baseChars[value % targetBase] + result;
                value = value / targetBase;
            }
            while (value > 0);

            return result;
        }

        /// <summary>
        /// An optimized method using an array as buffer instead of 
        /// string concatenation. This is faster for return values having 
        /// a length > 1.
        /// </summary>
        public static string IntToStringFast(long value, char[] baseChars)
        {
            // 32 is the worst cast buffer size for base 2 and int.MaxValue
            int i = 32;
            char[] buffer = new char[i];
            int targetBase = baseChars.Length;

            do
            {
                buffer[--i] = baseChars[value % targetBase];
                value = value / targetBase;
            }
            while (value > 0);

            char[] result = new char[32 - i];
            Array.Copy(buffer, i, result, 0, 32 - i);

            return new string(result);
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                
                char[] basechars = this.txtChars.Text.Split(new char[] { ',' }).Select(x => x[0]).ToArray();
                this.listBox1.Items.Clear();
                long N = (long)this.numN.Value;
                int pad = (int)this.numericUpDown2.Value;
                using (StreamWriter sw = new StreamWriter($"进制{basechars.Length}_个数{N}_补全{pad}.txt", false))
                {
                    for (long i = 1; i <= N; i++)
                    {
                        string s = IntToStringFast(i, basechars).PadLeft(pad, '0');
                        if (this.listBox1.Items.Count < 50)
                            this.listBox1.Items.Add(s);
                        sw.WriteLine(s);
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }
    }
}
