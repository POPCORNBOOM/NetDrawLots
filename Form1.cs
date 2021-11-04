using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NetDrawLots
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "NetDrawLots   v" + Application.ProductVersion;
            if (File.Exists(Properties.Settings.Default.lastopen))
                try
                {
                    logtofile("Try Open Last File");
                    openafile(Properties.Settings.Default.lastopen);
                }
                catch (Exception ex)
                {
                    logtofile("Error:Failed to Open Last File.Details(" + ex + ")");

                }
            else
                Properties.Settings.Default.lastopen = null;
            Properties.Settings.Default.Save();
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            logtofile("OpenFileDialog dialog = new OpenFileDialog()");
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//允许打开多个文件
            dialog.Title = "请选择文件";
            dialog.Filter = "逗号分隔文件|*.csv|All|*.*";//打开多个文件
            string filePath;

            if (dialog.ShowDialog() == DialogResult.OK)
                filePath = dialog.FileName;
            else
            {
                logtofile("Cancel");
                return;
            }
            openafile(filePath);
        }

        public void openafile(string filePath)
        {
            logtofile("Pool Import from Path:" + filePath);
            Properties.Settings.Default.lastopen = filePath;
            Properties.Settings.Default.Save();
            dgv_from.Rows.Clear();
            dgv_from.Refresh();
            int index = 0;
            foreach (string str in File.ReadAllLines(filePath, Encoding.Default))
            {
                if (str != null)
                {
                    dgv_from.Rows.Add(str);
                    //dgv_from.Rows[index].HeaderCell.Value = index + 1;
                }
                index++;

            }
            if (index >= 11)
                btn_10.Enabled = true;
            else
                btn_10.Enabled = false;

        }

        private void dgv_from_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void btn_roll_Click(object sender, EventArgs e)
        {
            roll(int.Parse(tb_count.Text));
        }

        public void roll(int rollcount)
        {
            string rollid = ((int)DateTime.Now.Ticks).ToString("X");
            logtofile("Start New Roll[" + rollid + "] with RollCount: " + rollcount);
            List<string> result = new List<string>();
            List<string> names = new List<string>();
            if (dgv_from.Rows.Count == 0)
            {
                logtofile("Error:Null Pool");
                logtofile("End Roll[" + rollid + "]");
                return;

            }
            int rr = 0;
            string temp=string.Empty;
            foreach (DataGridViewRow row in dgv_from.Rows)
            {
                names.Add(row.Cells[0].Value.ToString());
                temp += row.Cells[0].Value.ToString()+",";
            }
            logtofile("Load Pool:[ " + temp+"]");

            while (result.Count < rollcount)
            {
                Random rdrd = new Random((int)DateTime.Now.Ticks);
                int newrdrd = (int)(rdrd.NextDouble() * (int)DateTime.Now.Ticks);
                Random rd = new Random(newrdrd + rr);
                //Random rd = new Random((int)DateTime.Now.Ticks+rr);
                logtofile("New Random with Seed: " + (newrdrd+rr));
                int a = (int)(rd.NextDouble() * names.Count);
                logtofile("New Random Result: " + a + " refer to" + names[a]);
                result.Add(names[a]);
                //if (dgv_from.Rows[a].HeaderCell.Value == null) dgv_from.Rows[a].HeaderCell.Value = 0;
                //dgv_from.Rows[a].HeaderCell.Value = (int)dgv_from.Rows[a].HeaderCell.Value + 1;
                if (!cb_allowrepeat.Checked)
                    names.RemoveAt(a);
                rr += 1;
            }

            dgv_output.Rows.Clear();
            dgv_output.Refresh();
            foreach (string b in result)
            {
                dgv_output.Rows.Add(b);
            }
            dgv_output.Refresh();
            logtofile("End Roll[" + rollid + "]");
        }


        public static bool IsNumber(string s, int precision, int scale)
        {
            int a;
            try
            {
                a = int.Parse(s);
            }
            catch
            {
                return false;
            }
            if (a < precision + 1 && a > scale - 1)
                return true;
            else
                return false;
        }

        private void tb_count_Leave(object sender, EventArgs e)
        {
            if (!IsNumber(tb_count.Text, dgv_from.Rows.Count, 0))
            {
                tb_count.Text = "1";
                MessageBox.Show("{count|count∈N*,rowcount>=count>0}");
            }
        }

        private void btn_10_Click(object sender, EventArgs e)
        {
            roll(10);
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            roll(1);
        }

        public void logtofile(string logstr)
        {
            string dir = Properties.Settings.Default.logdir+ "lotlog.txt";
            if (!File.Exists(dir))
                File.Create(dir);
            //FileStream fs = new FileStream(dir, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(dir, true, Encoding.Default);
            sw.WriteLine(DateTime.Now + " | " + logstr);
            sw.Flush();
            sw.Close();
            tb_log.Text += (DateTime.Now + " | " + logstr + "\r\n");
            //fs.Close();
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            string dir = Properties.Settings.Default.logdir+ "lotlog.txt";
            if (!File.Exists(dir))
                File.Create(dir);
            Process.Start(dir);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Process.Start("https://popcornboom.github.io/");
        }

        private void btn_showcode_Click(object sender, EventArgs e)
        {
            string tempcode = Properties.Settings.Default.logdir + "code.png";
            if (!File.Exists(tempcode))
            {
                Properties.Resources.sourcecode.Save(tempcode);
            }
            Process.Start(tempcode);

        }

        private void btn_clearlog_Click(object sender, EventArgs e)
        {
            tb_log.Text = string.Empty;
        }

        private void btn_opensite_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/POPCORNBOOM/NetDrawLots");
        }
    }
}
