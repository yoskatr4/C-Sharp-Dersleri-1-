namespace _1.ders
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

        private void buttonMesajGörüntüle_Click(object sender, EventArgs e)
        {
            textBoxMesaj.Text = "Ders 1 : GUI Tasarımı";
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            textBoxMesaj.Text = "";
        }

        private void comboBoxIsimler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ekleIIsim_Click(object sender, EventArgs e)
        {
            comboBoxIsimler.Items.Add(textBoxMesaj.Text);
            listBoxDersler.Items.Add(textBoxMesaj.Text);
        }

        private void buttonLabelDeğiştir_Click(object sender, EventArgs e)
        {
            labelYazılanİsim.Text = textBoxMesaj.Text;
        }

        private void listBoxDersler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
