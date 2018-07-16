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
    public partial class Takeout_Warehouse : Form
    {
        public Takeout_Warehouse()
        {
            InitializeComponent();
        }

        private void Takeout_Warehouse_Load(object sender, EventArgs e)
        {
            index_layout index = new index_layout();
            index.a(this);
        }
    }
}
