
namespace Pasteinorder
{
    partial class Pasteinorder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pasteinorder));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmptyB = new System.Windows.Forms.Button();
            this.sep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectpathB = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.keyText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.condition = new System.Windows.Forms.Label();
            this.CloseB = new System.Windows.Forms.Button();
            this.no = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OpenB = new System.Windows.Forms.Button();
            this.loop = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.enable = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loop)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SN,
            this.CONTG});
            this.dataGridView1.Location = new System.Drawing.Point(5, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(266, 274);
            this.dataGridView1.TabIndex = 0;
            // 
            // SN
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SN.DefaultCellStyle = dataGridViewCellStyle1;
            this.SN.HeaderText = "序号";
            this.SN.Name = "SN";
            this.SN.ReadOnly = true;
            this.SN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SN.Width = 40;
            // 
            // CONTG
            // 
            this.CONTG.HeaderText = "内容";
            this.CONTG.Name = "CONTG";
            this.CONTG.ReadOnly = true;
            this.CONTG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CONTG.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.EmptyB);
            this.groupBox1.Controls.Add(this.sep);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SelectpathB);
            this.groupBox1.Location = new System.Drawing.Point(277, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "导入清空";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "换行符请留空";
            // 
            // EmptyB
            // 
            this.EmptyB.Location = new System.Drawing.Point(88, 20);
            this.EmptyB.Name = "EmptyB";
            this.EmptyB.Size = new System.Drawing.Size(55, 23);
            this.EmptyB.TabIndex = 5;
            this.EmptyB.Text = "清空";
            this.EmptyB.UseVisualStyleBackColor = true;
            this.EmptyB.Click += new System.EventHandler(this.EmptyB_Click);
            // 
            // sep
            // 
            this.sep.Location = new System.Drawing.Point(57, 49);
            this.sep.Name = "sep";
            this.sep.Size = new System.Drawing.Size(84, 21);
            this.sep.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "分隔符:";
            // 
            // SelectpathB
            // 
            this.SelectpathB.Location = new System.Drawing.Point(8, 20);
            this.SelectpathB.Name = "SelectpathB";
            this.SelectpathB.Size = new System.Drawing.Size(72, 23);
            this.SelectpathB.TabIndex = 0;
            this.SelectpathB.Text = "选择文本";
            this.SelectpathB.UseVisualStyleBackColor = true;
            this.SelectpathB.Click += new System.EventHandler(this.Selectpath_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.enable);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.loop);
            this.groupBox2.Controls.Add(this.keyText);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.condition);
            this.groupBox2.Controls.Add(this.CloseB);
            this.groupBox2.Controls.Add(this.no);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.OpenB);
            this.groupBox2.Location = new System.Drawing.Point(277, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 168);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作状态";
            // 
            // keyText
            // 
            this.keyText.Location = new System.Drawing.Point(57, 46);
            this.keyText.Name = "keyText";
            this.keyText.Size = new System.Drawing.Size(84, 21);
            this.keyText.TabIndex = 6;
            this.keyText.Text = "F8";
            this.keyText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.keyText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "热键 :";
            // 
            // condition
            // 
            this.condition.Location = new System.Drawing.Point(6, 125);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(139, 36);
            this.condition.TabIndex = 4;
            this.condition.Text = "未运行！";
            this.condition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseB
            // 
            this.CloseB.Location = new System.Drawing.Point(79, 99);
            this.CloseB.Name = "CloseB";
            this.CloseB.Size = new System.Drawing.Size(64, 23);
            this.CloseB.TabIndex = 3;
            this.CloseB.Text = "关闭";
            this.CloseB.UseVisualStyleBackColor = true;
            this.CloseB.Click += new System.EventHandler(this.CloseB_Click);
            // 
            // no
            // 
            this.no.Location = new System.Drawing.Point(57, 21);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(84, 21);
            this.no.TabIndex = 2;
            this.no.Text = "0";
            this.no.TextChanged += new System.EventHandler(this.textChanged);
            this.no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "序号 :";
            // 
            // OpenB
            // 
            this.OpenB.Location = new System.Drawing.Point(8, 99);
            this.OpenB.Name = "OpenB";
            this.OpenB.Size = new System.Drawing.Size(64, 23);
            this.OpenB.TabIndex = 0;
            this.OpenB.Text = "开启";
            this.OpenB.UseVisualStyleBackColor = true;
            this.OpenB.Click += new System.EventHandler(this.OpenB_Click);
            // 
            // loop
            // 
            this.loop.Location = new System.Drawing.Point(57, 72);
            this.loop.Name = "loop";
            this.loop.Size = new System.Drawing.Size(40, 21);
            this.loop.TabIndex = 7;
            this.loop.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "循环 :";
            // 
            // enable
            // 
            this.enable.AutoSize = true;
            this.enable.Location = new System.Drawing.Point(100, 74);
            this.enable.Name = "enable";
            this.enable.Size = new System.Drawing.Size(48, 16);
            this.enable.TabIndex = 9;
            this.enable.Text = "启用";
            this.enable.UseVisualStyleBackColor = true;
            this.enable.Click += new System.EventHandler(this.enable_Click);
            // 
            // Pasteinorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 281);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 320);
            this.MinimumSize = new System.Drawing.Size(450, 320);
            this.Name = "Pasteinorder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " 顺序粘贴 [吾爱破解_viot]";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox sep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SelectpathB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label condition;
        private System.Windows.Forms.Button CloseB;
        private System.Windows.Forms.TextBox no;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OpenB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTG;
        private System.Windows.Forms.Button EmptyB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox keyText;
        private System.Windows.Forms.CheckBox enable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown loop;
    }
}

