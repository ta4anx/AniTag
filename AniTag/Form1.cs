
namespace AniTag
{
    public partial class Form1 : Form
    {
        public object SqlConnection { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();      //uygulamay� kapat�r
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //form 2'yi a�ar
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();


        }
    }
}
    

