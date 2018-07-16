namespace WindowsFormsApp2
{
    partial class index_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index_main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.员工管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统字典ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.仓库管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.仓库状态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加器具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.器件出入记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.到期提醒ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.到期提醒ToolStripMenuItem});
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
            this.员工管理ToolStripMenuItem.Size = new System.Drawing.Size(146, 27);
            this.员工管理ToolStripMenuItem.Text = "001";
            // 
            // 系统字典ToolStripMenuItem
            // 
            this.系统字典ToolStripMenuItem.Name = "系统字典ToolStripMenuItem";
            this.系统字典ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(105, 0, 4, 0);
            this.系统字典ToolStripMenuItem.Size = new System.Drawing.Size(150, 27);
            this.系统字典ToolStripMenuItem.Text = "002";
            // 
            // 仓库管理ToolStripMenuItem
            // 
            this.仓库管理ToolStripMenuItem.Name = "仓库管理ToolStripMenuItem";
            this.仓库管理ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(105, 0, 4, 0);
            this.仓库管理ToolStripMenuItem.Size = new System.Drawing.Size(150, 27);
            this.仓库管理ToolStripMenuItem.Text = "003";
            // 
            // 仓库状态ToolStripMenuItem
            // 
            this.仓库状态ToolStripMenuItem.Name = "仓库状态ToolStripMenuItem";
            this.仓库状态ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(105, 0, 4, 0);
            this.仓库状态ToolStripMenuItem.Size = new System.Drawing.Size(150, 27);
            this.仓库状态ToolStripMenuItem.Text = "004";
            // 
            // 添加器具ToolStripMenuItem
            // 
            this.添加器具ToolStripMenuItem.Name = "添加器具ToolStripMenuItem";
            this.添加器具ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(105, 0, 4, 0);
            this.添加器具ToolStripMenuItem.Size = new System.Drawing.Size(150, 27);
            this.添加器具ToolStripMenuItem.Text = "005";
            this.添加器具ToolStripMenuItem.Click += new System.EventHandler(this.添加器具ToolStripMenuItem_Click);
            // 
            // 器件出入记录ToolStripMenuItem
            // 
            this.器件出入记录ToolStripMenuItem.Name = "器件出入记录ToolStripMenuItem";
            this.器件出入记录ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(105, 0, 4, 0);
            this.器件出入记录ToolStripMenuItem.Size = new System.Drawing.Size(150, 27);
            this.器件出入记录ToolStripMenuItem.Text = "006";
            // 
            // 到期提醒ToolStripMenuItem
            // 
            this.到期提醒ToolStripMenuItem.AutoToolTip = true;
            this.到期提醒ToolStripMenuItem.Name = "到期提醒ToolStripMenuItem";
            this.到期提醒ToolStripMenuItem.Size = new System.Drawing.Size(49, 27);
            this.到期提醒ToolStripMenuItem.Text = "007";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(59, 630);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "当前时间：";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(155, 630);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(890, 630);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "查询器具位置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(1067, 630);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "管理员登录";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // index_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "index_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "仓库管理系统3.20";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem 到期提醒ToolStripMenuItem;
    }
}