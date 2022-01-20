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
        bool isup =false;
        bool ismin =false;
        private bool formMove = false;//窗体是否移动
        private Point formPoint;//记录窗体的位置

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
                    List<string> list = new List<string>(str.Split(','));
                    dgv_from.Rows.Add(list[0],list[1]);
                    //dgv_from.Rows[index].HeaderCell.Value = index + 1;
                }
                index++;

            }
            if (index >= 11)
                btn_10.Enabled = true;
            else
                btn_10.Enabled = false;
            numUD_count.Value = 1;
            numUD_count.Maximum = index;
        }

        private void dgv_from_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void btn_roll_Click(object sender, EventArgs e)
        {
            roll((int)numUD_count.Value);
        }

        public void roll(int rollcount)
        {
            string rollid = ((int)DateTime.Now.Ticks).ToString("X");
            logtofile("Start New Roll[" + rollid + "] with RollCount: " + rollcount);
            List<string> result = new List<string>();
            List<int> namesid = new List<int>();
            List<string> names = new List<string>();
            List<int> resultid = new List<int>();

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
                namesid.Add(int.Parse(row.Cells[1].Value.ToString()));
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
                int t = a;
                if (isup)
                {
                    for(int x =0; x < numUP_coe.Value&& (int.Parse(DateTime.Now.ToString("dd")) % 10) != namesid[a] % 10; x++)
                    {
                        Random rdrd2 = new Random((int)DateTime.Now.Ticks + x);
                        int newrdrd2 = (int)(rdrd2.NextDouble() * (int)DateTime.Now.Ticks);
                        Random rd2 = new Random(newrdrd2 + rr + x);
                        a = (int)(rd2.NextDouble() * names.Count);
                    }
                    logtofile("(UNFAIR)Former Result: " + namesid[t] + " refer to" + names[t] + " But Now Result:" + namesid[a] + " refer to" + names[a] + "\r\n------");

                }
                else
                    logtofile("New Random Result: " + namesid[a] + " refer to" + names[a]+"\r\n------");
                result.Add(names[a]);
                resultid.Add(namesid[a]);

                //if (dgv_from.Rows[a].HeaderCell.Value == null) dgv_from.Rows[a].HeaderCell.Value = 0;
                //dgv_from.Rows[a].HeaderCell.Value = (int)dgv_from.Rows[a].HeaderCell.Value + 1;
                if (!cb_allowrepeat.Checked)
                {
                    names.RemoveAt(a);
                    namesid.RemoveAt(a);

                }
                rr += 1;
            }

            dgv_output.Rows.Clear();
            dgv_output.Refresh();
            int iid=0;
            foreach (string b in result)
            {
                //dgv_output.Rows.Add(b);
                dgv_output.Rows.Add(b, resultid[iid]);

                iid++;
            }
            dgv_output.Refresh();
            logtofile("End Roll[" + rollid + "]");
            Text = "NetDrawLots   v" + Application.ProductVersion + " --Roll[" + rollid + "]";

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

        /*private void tb_count_Leave(object sender, EventArgs e)
        {
            if (!IsNumber(tb_count.Text, dgv_from.Rows.Count, 0))
            {
                tb_count.Text = "1";
                MessageBox.Show("{count|count∈N*,rowcount>=count>0}");
            }
        }*/

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
            //if (!File.Exists(tempcode))
            //{
                Properties.Resources.sc1.Save(tempcode);
            //}
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

        private void btn_topmost_Click(object sender, EventArgs e)
        {
            if (ismin)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                Width = 886;
                Height = 525;
                ismin = false;
                btn_topmost.Dock = DockStyle.None;
                //TopMost = false;
                btn_topmost.Text = "悬浮小化";
                Opacity= 1;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.None;
                Width = 70;
                Height = 70;
                ismin = true;
                btn_topmost.Dock = DockStyle.Fill;
                //TopMost = true;
                btn_topmost.Text = "NDL\n左键还原\n右键拖动";
                Opacity = 0.3;


            }
        }

        private void m_MouseUp(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)//按下的是鼠标左键
            {
                formMove = false;//停止移动
            }

        }

        private void m_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMove == true)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(formPoint.X, formPoint.Y);
                Location = mousePos;
            }
        }

        private void m_MouseDown(object sender, MouseEventArgs e)
        {
            formPoint = new Point();
            int xOffset;
            int yOffset;
            if (e.Button == MouseButtons.Right)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.FrameBorderSize.Height;//SystemInformation.CaptionHeight -
                formPoint = new Point(xOffset, yOffset);
                formMove = true;//开始移动
            }
        }

        private void cb_up_CheckedChanged(object sender, EventArgs e)
        {
            isup=cb_up.Checked;
            p_daterely.Enabled = isup;
        }


    }
}
