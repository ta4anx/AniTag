using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniTag
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();      //uygulamayı kapatır
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Form1 formunu açar
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
