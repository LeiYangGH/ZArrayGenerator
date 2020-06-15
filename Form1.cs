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







        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
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
            string[] basechars = this.txtChars.Text.Split(new char[] { ',' }).ToArray();
            this.Invoke(new Action(() => { this.lstSamples.Items.Clear(); }));
            this.Invoke(new Action(() =>
            {
                //this.progressBar1.Minimum = (int)from;
                //this.progressBar1.Maximum = (int)to;
                //this.progressBar1.Value = (int)from;
            }));

            int pad = (int)this.numPad.Value;
            string filename = $"进制{basechars.Length}_补全{pad}.txt";
            this.Invoke(new Action(() =>
            {
                this.lblFilename.Text = filename;
            }));
            using (StreamWriter sw = new StreamWriter(filename, false))
            {
                Permutation<string> permutation_object = new Permutation<string>();

                SortedSet<String> sortedSet = new SortedSet<string>();
                foreach (IList<string> arr in permutation_object.permutate(basechars))
                {
                    string combinedStr = string.Join("", arr).PadLeft(pad, '0');
                    sortedSet.Add(combinedStr);
                }

                foreach (string s in sortedSet)
                {

                    if (this.lstSamples.Items.Count < 50)
                    {
                        this.Invoke(new Action(() => { this.lstSamples.Items.Add(s); }));
                    }
                    //this.backgroundWorker1.ReportProgress((int)i);
                    sw.WriteLine(s);
                }
                this.toolMsg.Text = "生成完毕。";
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Console.WriteLine(e.ProgressPercentage);
            this.Invoke(new Action(() => { this.progressBar1.Value = e.ProgressPercentage; this.progressBar1.Refresh(); }));
        }
    }
}
