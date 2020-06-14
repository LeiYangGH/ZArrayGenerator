namespace ZArrayGenerator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtChars = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numTo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lstSamples = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numPad = new System.Windows.Forms.NumericUpDown();
            this.numFrom = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFilename = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.numTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrom)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtChars
            // 
            this.txtChars.Location = new System.Drawing.Point(123, 65);
            this.txtChars.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChars.Name = "txtChars";
            this.txtChars.Size = new System.Drawing.Size(631, 26);
            this.txtChars.TabIndex = 0;
            this.txtChars.Text = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "字符序列";
            // 
            // numTo
            // 
            this.numTo.Location = new System.Drawing.Point(353, 157);
            this.numTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numTo.Maximum = new decimal(new int[] {
            -1593835521,
            466537709,
            54210,
            0});
            this.numTo.Name = "numTo";
            this.numTo.Size = new System.Drawing.Size(160, 26);
            this.numTo.TabIndex = 2;
            this.numTo.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "从";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(654, 243);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 31);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "生成";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lstSamples
            // 
            this.lstSamples.FormattingEnabled = true;
            this.lstSamples.ItemHeight = 16;
            this.lstSamples.Location = new System.Drawing.Point(123, 301);
            this.lstSamples.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstSamples.Name = "lstSamples";
            this.lstSamples.Size = new System.Drawing.Size(305, 292);
            this.lstSamples.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 243);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "左边补齐";
            // 
            // numPad
            // 
            this.numPad.Location = new System.Drawing.Point(123, 241);
            this.numPad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numPad.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numPad.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numPad.Name = "numPad";
            this.numPad.Size = new System.Drawing.Size(120, 26);
            this.numPad.TabIndex = 7;
            this.numPad.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numFrom
            // 
            this.numFrom.Location = new System.Drawing.Point(123, 157);
            this.numFrom.Maximum = new decimal(new int[] {
            -159383553,
            46653770,
            5421,
            0});
            this.numFrom.Name = "numFrom";
            this.numFrom.Size = new System.Drawing.Size(120, 26);
            this.numFrom.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "到";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 243);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "个0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(123, 658);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(631, 23);
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 623);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "生成文件名：";
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(123, 627);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(0, 16);
            this.lblFilename.TabIndex = 11;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMsg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 718);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(808, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolMsg
            // 
            this.toolMsg.Name = "toolMsg";
            this.toolMsg.Size = new System.Drawing.Size(0, 17);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 740);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.numFrom);
            this.Controls.Add(this.numPad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstSamples);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChars);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrom)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ListBox lstSamples;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numPad;
        private System.Windows.Forms.NumericUpDown numFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolMsg;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

