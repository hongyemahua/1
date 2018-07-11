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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.员工管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统字典ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.仓库管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.仓库编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.位置编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.仓库状态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.添加器具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.器件出入记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工管理ToolStripMenuItem,
            this.系统字典ToolStripMenuItem,
            this.仓库管理ToolStripMenuItem,
            this.仓库状态ToolStripMenuItem,
            this.添加器具ToolStripMenuItem,
            this.器件出入记录ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1158, 31);
            this.menuStrip1.TabIndex = 0;
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
            this.添加器具ToolStripMenuItem.Name = "添加器具ToolStripMenuItem";
            this.添加器具ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(105, 0, 4, 0);
            this.添加器具ToolStripMenuItem.Size = new System.Drawing.Size(187, 27);
            this.添加器具ToolStripMenuItem.Text = "器件管理";
            this.添加器具ToolStripMenuItem.Click += new System.EventHandler(this.添加器具ToolStripMenuItem_Click);
            // 
            // 器件出入记录ToolStripMenuItem
            // 
            this.器件出入记录ToolStripMenuItem.Name = "器件出入记录ToolStripMenuItem";
            this.器件出入记录ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(105, 0, 4, 0);
            this.器件出入记录ToolStripMenuItem.Size = new System.Drawing.Size(219, 27);
            this.器件出入记录ToolStripMenuItem.Text = "器件出入记录";
            this.器件出入记录ToolStripMenuItem.Click += new System.EventHandler(this.器件出入记录ToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1043, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "管理员";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(949, 527);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "查询";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // admin_index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 562);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "admin_index";
            this.Text = "主页面";
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
    }
}