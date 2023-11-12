namespace SinemaSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Sinema.Sinif.Sinema yeni;
        private void button1_Click(object sender, EventArgs e)
        {
            yeni = new Sinema.Sinif.Sinema(textBox1.Text, int.Parse(textBox2.Text));
            label3.Text = yeni.BosKoltukSayisiOgren() + " Koltuklu " + yeni.SalonAdiOgren() + " Salonu Baþarýyla Oluþturuldu."; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = yeni.BiletSat(checkBox1.Checked, int.Parse(textBox3.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = yeni.BiletIptal(checkBox1.Checked, int.Parse(textBox3.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text =  yeni.BosKoltukOgren();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "Bakiye: " + yeni.BakiyeOgren().ToString();
        }
    }
}