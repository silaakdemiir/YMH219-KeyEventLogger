namespace YMH219_KeyEventLogger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            string zaman = DateTime.Now.ToString("HH:mm:ss");
            lstKayitlar.Items.Add($"{zaman} - {e.KeyCode}");
        }
    }
}
