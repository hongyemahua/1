namespace WindowsFormsApp2
{
    partial class admin_index
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_index));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.员工管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统字典ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.仓库管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.仓库编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.位置编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.仓库状态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.添加器具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.器件出入记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox5 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox6 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox7 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工管理ToolStripMenuItem,
            this.系统字典ToolStripMenuItem,
            this.仓库管理ToolStripMenuItem,
            this.仓库状态ToolStripMenuItem,
            this.添加器具ToolStripMenuItem,
            this.器件出入记录ToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 员工管理ToolStripMenuItem
            // 
            this.员工管理ToolStripMenuItem.Name = "员工管理ToolStripMenuItem";
            this.员工管理ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(105, 1, 0, 1);
            this.员工管理ToolStripMenuItem.Size = new System.Drawing.Size(183, 27);
            this.员工管理ToolStripMenuItem.Text = "员工管理";
            this.员工管理ToolStripMenuItem.Click += new System.EventHandler(this.员工管理ToolStripMenuItem_Click);
            // 
            // 系统字典ToolStripMenuItem
            // 
            this.系统字典ToolStripMenuItem.Name = "系统字典ToolStripMenuItem";
            this.系统字典ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(105, 0, 4, 0);
            this.系统字典ToolStripMenuItem.Size = new System.Drawing.Size(187, 27);
            this.系统字典ToolStripMenuItem.Text = "系统字典";
            this.系统字典ToolStripMenuItem.Click += new System.EventHandler(this.系统字典ToolStripMenuItem_Click);
            // 
            // 仓库管理ToolStripMenuItem
            // 
            this.仓库管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.仓库编辑ToolStripMenuItem,
            this.位置编辑ToolStripMenuItem});
            this.仓库管理ToolStripMenuItem.Name = "仓库管理ToolStripMenuItem";
            this.仓库管理ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(105, 0, 4, 0);
            this.仓库管理ToolStripMenuItem.Size = new System.Drawing.Size(187, 27);
            this.仓库管理ToolStripMenuItem.Text = "仓库管理";
            this.仓库管理ToolStripMenuItem.Click += new System.EventHandler(this.仓库管理ToolStripMenuItem_Click);
            // 
            // 仓库编辑ToolStripMenuItem
            // 
            this.仓库编辑ToolStripMenuItem.Name = "仓库编辑ToolStripMenuItem";
            this.仓库编辑ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.仓库编辑ToolStripMenuItem.Text = "仓库编辑";
            this.仓库编辑ToolStripMenuItem.Click += new System.EventHandler(this.仓库编辑ToolStripMenuItem_Click);
            // 
            // 位置编辑ToolStripMenuItem
            // 
            this.位置编辑ToolStripMenuItem.Name = "位置编辑ToolStripMenuItem";
            this.位置编辑ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.位置编辑ToolStripMenuItem.Text = "位置编辑";
            this.位置编辑ToolStripMenuItem.Click += new System.EventHandler(this.位置编辑ToolStripMenuItem_Click);
            // 
            // 仓库状态ToolStripMenuItem
            // 
            this.仓库状态ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.仓库状态ToolStripMenuItem.Name = "仓库状态ToolStripMenuItem";
            this.仓库状态ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(105, 0, 4, 0);
            this.仓库状态ToolStripMenuItem.Size = new System.Drawing.Size(187, 27);
            this.仓库状态ToolStripMenuItem.Text = "仓库状态";
            this.仓库状态ToolStripMenuItem.Click += new System.EventHandler(this.仓库状态ToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(180, 29);
            this.toolStripTextBox1.Text = "查看状态";
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // 添加器具ToolStripMenuItem
            // 
            this.添加器具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2,
            this.toolStripTextBox3});
            this.添加器具ToolStripMenuItem.Name = "添加器具ToolStripMenuItem";
            this.添加器具ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(105, 0, 4, 0);
            this.添加器具ToolStripMenuItem.Size = new System.Drawing.Size(187, 27);
            this.添加器具ToolStripMenuItem.Text = "器件管理";
            this.添加器具ToolStripMenuItem.Click += new System.EventHandler(this.添加器具ToolStripMenuItem_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 29);
            this.toolStripTextBox2.Text = "仪器";
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 29);
            this.toolStripTextBox3.Text = "元器件";
            // 
            // 器件出入记录ToolStripMenuItem
            // 
            this.器件出入记录ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.器件出入记录ToolStripMenuItem.Name = "器件出入记录ToolStripMenuItem";
            this.器件出入记录ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(105, 0, 4, 0);
            this.器件出入记录ToolStripMenuItem.Size = new System.Drawing.Size(219, 27);
            this.器件出入记录ToolStripMenuItem.Text = "器件出入记录";
            this.器件出入记录ToolStripMenuItem.Click += new System.EventHandler(this.器件出入记录ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox4,
            this.toolStripTextBox5});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 26);
            this.toolStripMenuItem2.Text = "仪器";
            // 
            // toolStripTextBox4
            // 
            this.toolStripTextBox4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripTextBox4.Name = "toolStripTextBox4";
            this.toolStripTextBox4.Size = new System.Drawing.Size(100, 29);
            this.toolStripTextBox4.Text = "出库";
            // 
            // toolStripTextBox5
            // 
            this.toolStripTextBox5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripTextBox5.Name = "toolStripTextBox5";
            this.toolStripTextBox5.Size = new System.Drawing.Size(100, 29);
            this.toolStripTextBox5.Text = "入库";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox6,
            this.toolStripTextBox7});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 26);
            this.toolStripMenuItem3.Text = "元器件";
            // 
            // toolStripTextBox6
            // 
            this.toolStripTextBox6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripTextBox6.Name = "toolStripTextBox6";
            this.toolStripTextBox6.Size = new System.Drawing.Size(100, 29);
            this.toolStripTextBox6.Text = "出库";
            // 
            // toolStripTextBox7
            // 
            this.toolStripTextBox7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripTextBox7.Name = "toolStripTextBox7";
            this.toolStripTextBox7.Size = new System.Drawing.Size(100, 29);
            this.toolStripTextBox7.Text = "入库";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(136, 27);
            this.toolStripMenuItem1.Text = "     到期提醒     ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(1055, 639);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(882, 639);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "查询器具位置";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(73, 646);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "当前时间：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(201, 643);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // admin_index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "admin_index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "管理员操作";
            this.Load += new System.EventHandler(this.admin_index_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 员工管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统字典ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 仓库管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 仓库状态ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加器具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 器件出入记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 仓库编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 位置编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox5;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox6;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}