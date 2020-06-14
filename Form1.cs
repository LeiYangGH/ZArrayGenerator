using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
            string version = System.Reflection.Assembly.GetExecutingAssembly()
                               .GetName()
                               .Version
                               .ToString();
            this.Text = "进制序列生成工具-" + version;
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


        private void Generate(long from, long to, char[] basechars, int pad)
        {
            using (StreamWriter sw = new StreamWriter($"进制{basechars.Length}_从{from}到{to}_补全{pad}.txt", false))
            {
                long total = to - from;
                for (long i = from; i <= to; i++)
                {
                    string s = IntToStringFast(i, basechars).PadLeft(pad, '0');
                    if (this.lstSamples.Items.Count < 50)
                    {

                        this.lstSamples.Items.Add(s); ;
                    }
                    this.progressBar1.Value = (int)((i - from) / total * 100);
                    this.progressBar1.Refresh();
                    sw.WriteLine(s);
                }
                this.toolMsg.Text = "生成完毕。";
            }
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                this.btnGenerate.Enabled = false;
                char[] basechars = this.txtChars.Text.Split(new char[] { ',' }).Select(x => x[0]).ToArray();
                this.lstSamples.Items.Clear();
                long from = (long)this.numFrom.Value;
                long to = (long)this.numTo.Value;
                if (from >= to)
                {
                    this.toolMsg.Text = "起始数字必须小于终止数字。";
                };


                int pad = (int)this.numPad.Value;
                this.Generate(from, to, basechars, pad);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                this.toolMsg.Text = ex.Message; ;
            }
            finally
            {
                this.Cursor = Cursors.Default;
                this.btnGenerate.Enabled = true;
            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
