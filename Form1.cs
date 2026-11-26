namespace YMH219_KeyEventLogger
{
    public partial class Form1 : Form
    {
        private bool kayitAcik = false;

        public Form1()
        {
            InitializeComponent();

            btnBaslat.Click += btnBaslat_Click;
            btnDurdur.Click += btnDurdur_Click;
            btnTemizle.Click += btnTemizle_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            kayitAcik = true;
            lblDurum.Text = "Kayýt: AÇIK";
            lblDurum.ForeColor = Color.Green;
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            kayitAcik = false;
            lblDurum.Text = "Kayýt: KAPALI";
            lblDurum.ForeColor = Color.Red;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lstKayitlar.Items.Clear();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (kayitAcik)
            {
                string zaman = DateTime.Now.ToString("HH:mm:ss");
                lstKayitlar.Items.Add($"{zaman} - {e.KeyCode}");
            }
        }
    }
}