
namespace NetDrawLots
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgv_from = new System.Windows.Forms.DataGridView();
            this.names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_roll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_allowrepeat = new System.Windows.Forms.CheckBox();
            this.btn_import = new System.Windows.Forms.Button();
            this.dgv_output = new System.Windows.Forms.DataGridView();
            this.rname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numUD_count = new System.Windows.Forms.NumericUpDown();
            this.p_daterely = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.numUP_coe = new System.Windows.Forms.NumericUpDown();
            this.cb_up = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_10 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_log = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_log = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_opensite = new System.Windows.Forms.Button();
            this.btn_showcode = new System.Windows.Forms.Button();
            this.btn_clearlog = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_topmost = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_from)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_output)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_count)).BeginInit();
            this.p_daterely.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_coe)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_from
            // 
            this.dgv_from.AllowUserToAddRows = false;
            this.dgv_from.AllowUserToDeleteRows = false;
            this.dgv_from.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_from.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.names,
            this.id});
            resources.ApplyResources(this.dgv_from, "dgv_from");
            this.dgv_from.MultiSelect = false;
            this.dgv_from.Name = "dgv_from";
            this.dgv_from.ReadOnly = true;
            this.dgv_from.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_from.RowHeadersVisible = false;
            this.dgv_from.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_from.RowTemplate.Height = 27;
            this.dgv_from.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            // 
            // names
            // 
            this.names.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.names, "names");
            this.names.Name = "names";
            this.names.ReadOnly = true;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.id, "id");
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // btn_roll
            // 
            resources.ApplyResources(this.btn_roll, "btn_roll");
            this.btn_roll.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_roll.FlatAppearance.BorderSize = 0;
            this.btn_roll.Name = "btn_roll";
            this.btn_roll.UseVisualStyleBackColor = false;
            this.btn_roll.Click += new System.EventHandler(this.btn_roll_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cb_allowrepeat
            // 
            resources.ApplyResources(this.cb_allowrepeat, "cb_allowrepeat");
            this.cb_allowrepeat.Name = "cb_allowrepeat";
            this.cb_allowrepeat.UseVisualStyleBackColor = true;
            // 
            // btn_import
            // 
            resources.ApplyResources(this.btn_import, "btn_import");
            this.btn_import.Name = "btn_import";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // dgv_output
            // 
            this.dgv_output.AllowUserToAddRows = false;
            this.dgv_output.AllowUserToDeleteRows = false;
            this.dgv_output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_output.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rname,
            this.rid});
            resources.ApplyResources(this.dgv_output, "dgv_output");
            this.dgv_output.MultiSelect = false;
            this.dgv_output.Name = "dgv_output";
            this.dgv_output.ReadOnly = true;
            this.dgv_output.RowHeadersVisible = false;
            this.dgv_output.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_output.RowTemplate.Height = 27;
            this.dgv_output.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            // 
            // rname
            // 
            this.rname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.rname, "rname");
            this.rname.Name = "rname";
            this.rname.ReadOnly = true;
            // 
            // rid
            // 
            this.rid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.rid, "rid");
            this.rid.Name = "rid";
            this.rid.ReadOnly = true;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.numUD_count);
            this.groupBox1.Controls.Add(this.p_daterely);
            this.groupBox1.Controls.Add(this.btn_roll);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_up);
            this.groupBox1.Controls.Add(this.cb_allowrepeat);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // numUD_count
            // 
            resources.ApplyResources(this.numUD_count, "numUD_count");
            this.numUD_count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUD_count.Name = "numUD_count";
            this.numUD_count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // p_daterely
            // 
            resources.ApplyResources(this.p_daterely, "p_daterely");
            this.p_daterely.Controls.Add(this.label3);
            this.p_daterely.Controls.Add(this.numUP_coe);
            this.p_daterely.Name = "p_daterely";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // numUP_coe
            // 
            resources.ApplyResources(this.numUP_coe, "numUP_coe");
            this.numUP_coe.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUP_coe.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numUP_coe.Name = "numUP_coe";
            this.numUP_coe.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // cb_up
            // 
            resources.ApplyResources(this.cb_up, "cb_up");
            this.cb_up.Name = "cb_up";
            this.cb_up.UseVisualStyleBackColor = true;
            this.cb_up.CheckedChanged += new System.EventHandler(this.cb_up_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_10);
            this.groupBox2.Controls.Add(this.btn_1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // btn_10
            // 
            resources.ApplyResources(this.btn_10, "btn_10");
            this.btn_10.BackColor = System.Drawing.Color.Gold;
            this.btn_10.FlatAppearance.BorderSize = 0;
            this.btn_10.ForeColor = System.Drawing.Color.White;
            this.btn_10.Name = "btn_10";
            this.btn_10.UseVisualStyleBackColor = false;
            this.btn_10.Click += new System.EventHandler(this.btn_10_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_1, "btn_1");
            this.btn_1.Name = "btn_1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_log
            // 
            resources.ApplyResources(this.btn_log, "btn_log");
            this.btn_log.Name = "btn_log";
            this.btn_log.UseVisualStyleBackColor = true;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.dgv_from);
            this.groupBox3.Controls.Add(this.btn_import);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.dgv_output);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_log
            // 
            resources.ApplyResources(this.tb_log, "tb_log");
            this.tb_log.Name = "tb_log";
            this.tb_log.ReadOnly = true;
            // 
            // groupBox5
            // 
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Controls.Add(this.btn_opensite);
            this.groupBox5.Controls.Add(this.btn_showcode);
            this.groupBox5.Controls.Add(this.tb_log);
            this.groupBox5.Controls.Add(this.btn_clearlog);
            this.groupBox5.Controls.Add(this.btn_log);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // btn_opensite
            // 
            resources.ApplyResources(this.btn_opensite, "btn_opensite");
            this.btn_opensite.Name = "btn_opensite";
            this.btn_opensite.UseVisualStyleBackColor = true;
            this.btn_opensite.Click += new System.EventHandler(this.btn_opensite_Click);
            // 
            // btn_showcode
            // 
            resources.ApplyResources(this.btn_showcode, "btn_showcode");
            this.btn_showcode.Name = "btn_showcode";
            this.btn_showcode.UseVisualStyleBackColor = true;
            this.btn_showcode.Click += new System.EventHandler(this.btn_showcode_Click);
            // 
            // btn_clearlog
            // 
            resources.ApplyResources(this.btn_clearlog, "btn_clearlog");
            this.btn_clearlog.Name = "btn_clearlog";
            this.btn_clearlog.UseVisualStyleBackColor = true;
            this.btn_clearlog.Click += new System.EventHandler(this.btn_clearlog_Click);
            // 
            // groupBox6
            // 
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Controls.Add(this.groupBox2);
            this.groupBox6.Controls.Add(this.groupBox5);
            this.groupBox6.Controls.Add(this.groupBox1);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_topmost);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.groupBox6);
            this.panel2.Controls.Add(this.groupBox4);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // btn_topmost
            // 
            resources.ApplyResources(this.btn_topmost, "btn_topmost");
            this.btn_topmost.Name = "btn_topmost";
            this.btn_topmost.UseVisualStyleBackColor = true;
            this.btn_topmost.Click += new System.EventHandler(this.btn_topmost_Click);
            this.btn_topmost.MouseDown += new System.Windows.Forms.MouseEventHandler(this.m_MouseDown);
            this.btn_topmost.MouseMove += new System.Windows.Forms.MouseEventHandler(this.m_MouseMove);
            this.btn_topmost.MouseUp += new System.Windows.Forms.MouseEventHandler(this.m_MouseUp);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_from)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_output)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_count)).EndInit();
            this.p_daterely.ResumeLayout(false);
            this.p_daterely.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_coe)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_from;
        private System.Windows.Forms.Button btn_roll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_allowrepeat;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.DataGridView dgv_output;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_10;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_log;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_showcode;
        private System.Windows.Forms.Button btn_clearlog;
        private System.Windows.Forms.Button btn_opensite;
        private System.Windows.Forms.Button btn_topmost;
        private System.Windows.Forms.CheckBox cb_up;
        private System.Windows.Forms.DataGridViewTextBoxColumn names;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.NumericUpDown numUP_coe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel p_daterely;
        private System.Windows.Forms.NumericUpDown numUD_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn rname;
        private System.Windows.Forms.DataGridViewTextBoxColumn rid;
        private System.Windows.Forms.Label label4;
    }
}

