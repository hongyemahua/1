using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    
    public partial class index_main : Form
    {
        public index_main()
        {
            InitializeComponent();
            //this.IsMdiContainer = true;
        }
        index_layout index = new index_layout();
        private void 添加器具ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label2.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form re = new index_refer();
            re.ShowDialog();
            //this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            index.b(this);
            Form fr = new index_refer();
            //fr.MdiParent = this;
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form admin_login = new admin_login();
            admin_login.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.label2.Text = DateTime.Now.ToString();
        }
    }
}
