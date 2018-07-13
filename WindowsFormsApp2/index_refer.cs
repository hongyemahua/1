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
    
    public partial class index_refer : Form
    {
        index_layout index = new index_layout();
        public index_refer()
        {
            InitializeComponent();
           
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            index.b(this);
            Form fr = new index_refer_instrument();
            fr.MdiParent = this;
            fr.Show();
            

            
        }

        private void index_refer_Load(object sender, EventArgs e)
        {
           

        }
    }
}
