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
        //char[] basechars = this.txtChars.Text.Split(new char[] { ',' }).Select(x => x[0]).ToArray();
        private IList<string> baseChars;
        private IList<string> lowChars;
        private IList<string> upChars;

        private bool CheckInput()
        {
            this.baseChars = this.txtChars.Text.Split(new char[] { ',' }).ToList();
            this.lowChars = this.txtLBounds.Text.Split(new char[] { ',' }).ToList();
            this.upChars = this.txtUBounds.Text.Split(new char[] { ',' }).ToList();
            if (baseChars.Count < 1)
            {
                this.toolMsg.Text = "基数字符必须至少1个";
                return false;
            }
            else if (lowChars.Count < 1 || upChars.Count < 1)
            {
                this.toolMsg.Text = "上限或下限字符必须至少1个";
                return false;
            }
            else if (lowChars.Count != upChars.Count)
            {
                this.toolMsg.Text = "上限或下限字符个数必须相等";
                return false;
            }
            else if (lowChars.Count > baseChars.Count)
            {
                this.toolMsg.Text = "上限或下限字符个数不能大于基数字符个数";
                return false;
            }
            else
                for (int i = 0; i < lowChars.Count; i++)
                {
                    if (lowChars[i].CompareTo(upChars[i]) > 0)
                    {
                        this.toolMsg.Text = "下限字符不能大于对应位置的字符";
                        return false;
                    }
                }

            return true;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.CheckInput())
                {
                    return;
                }
                this.Cursor = Cursors.WaitCursor;
                this.btnGenerate.Enabled = false;

                backgroundWorker1.RunWorkerAsync();
                //this.Generate(from, to, basechars, pad);
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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            this.Invoke(new Action(() => { this.lstSamples.Items.Clear(); }));

            string filename = $"进制{baseChars.Count}_从{string.Join("", lowChars)}到{string.Join("", upChars)}.txt";
            this.Invoke(new Action(() =>
            {
                this.lblFilename.Text = filename;
            }));
            using (StreamWriter sw = new StreamWriter(filename, false))
            {
                Permutator permutator = new Permutator(baseChars, lowChars, upChars);
                foreach (string s in permutator.Permutate("", 0))
                {

                    if (this.lstSamples.Items.Count < 50)
                    {
                        this.Invoke(new Action(() => { this.lstSamples.Items.Add(s); }));
                    }
                    this.Invoke(new Action(() => { this.lblCurrentValue.Text = s; this.lblCurrentValue.Refresh(); }));
                    sw.WriteLine(s);
                }
                this.toolMsg.Text = "生成完毕。";
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }
    }
}
