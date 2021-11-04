
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
            this.btn_roll = new System.Windows.Forms.Button();
            this.tb_count = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_allowrepeat = new System.Windows.Forms.CheckBox();
            this.btn_import = new System.Windows.Forms.Button();
            this.dgv_output = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_10 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_log = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_log = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_showcode = new System.Windows.Forms.Button();
            this.btn_clearlog = new System.Windows.Forms.Button();
            this.btn_opensite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_from)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_output)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.names});
            resources.ApplyResources(this.dgv_from, "dgv_from");
            this.dgv_from.MultiSelect = false;
            this.dgv_from.Name = "dgv_from";
            this.dgv_from.ReadOnly = true;
            this.dgv_from.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_from.RowTemplate.Height = 27;
            this.dgv_from.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            // 
            // names
            // 
            resources.ApplyResources(this.names, "names");
            this.names.Name = "names";
            this.names.ReadOnly = true;
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
            // tb_count
            // 
            resources.ApplyResources(this.tb_count, "tb_count");
            this.tb_count.Name = "tb_count";
            this.tb_count.Leave += new System.EventHandler(this.tb_count_Leave);
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
            this.dataGridViewTextBoxColumn1});
            resources.ApplyResources(this.dgv_output, "dgv_output");
            this.dgv_output.MultiSelect = false;
            this.dgv_output.Name = "dgv_output";
            this.dgv_output.ReadOnly = true;
            this.dgv_output.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_output.RowTemplate.Height = 27;
            this.dgv_output.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            // 
            // dataGridViewTextBoxColumn1
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.btn_roll);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_allowrepeat);
            this.groupBox1.Controls.Add(this.tb_count);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
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
            this.groupBox3.Controls.Add(this.dgv_from);
            this.groupBox3.Controls.Add(this.btn_import);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_output);
            resources.ApplyResources(this.groupBox4, "groupBox4");
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
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox6);
            this.panel2.Controls.Add(this.groupBox4);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
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
            // btn_opensite
            // 
            resources.ApplyResources(this.btn_opensite, "btn_opensite");
            this.btn_opensite.Name = "btn_opensite";
            this.btn_opensite.UseVisualStyleBackColor = true;
            this.btn_opensite.Click += new System.EventHandler(this.btn_opensite_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_from)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_output)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_from;
        private System.Windows.Forms.Button btn_roll;
        private System.Windows.Forms.TextBox tb_count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_allowrepeat;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.DataGridViewTextBoxColumn names;
        private System.Windows.Forms.DataGridView dgv_output;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
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
    }
}

