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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "form sınıfı uygulama 2";
            this.BackColor = Color.Green;
            this.ForeColor = Color.Black;
            this.Size = new Size(300, 150);



            lblAdSoyad.Text = "adınız";
            lblAdSoyad.Location = new Point(10, 10);
            lblAdSoyad.Size = new Size(65, 10);
            lblAdSoyad.ForeColor = Color.White;



            txtAdSoyad.Location = new Point(75, 10);
            txtAdSoyad.Size = new Size(150, 15);
            txtAdSoyad.TabIndex = 1;


            btnGiris.Text = "tıkla";
            btnGiris.Location = new Point(100, 60);
            btnGiris.Size = new Size(100, 30);
           btnGiris.BackColor = Color.White;
            btnGiris.ForeColor = Color.Black;
            btnGiris.TabIndex = 2;

            
            btnGiris.Click += BtnGiris_Click ;


            this.Controls.Add(lblAdSoyad);
            this.Controls.Add(txtAdSoyad);
            this.Controls.Add(btnGiris);

        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

       

        private void txtAdSoyad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.KeyChar=char.ToUpper(e.KeyChar);

        }

        private void btnGiris_Click_1(object sender, EventArgs e)
        { 
            MessageBox.Show("merhaba  " + txtAdSoyad.Text);
        }
    }
}
