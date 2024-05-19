using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.unite_uygulama2
{
    public partial class FormB : Form
    {
        public FormB()
        {
            InitializeComponent();
        }

        private void FormB_Load(object sender, EventArgs e)
        {
            MessageBox.Show("formB click olayı çalışıyor");
        }
    }
}
