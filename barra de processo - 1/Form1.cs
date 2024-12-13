namespace barra_de_processo___1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void but_ok_Click(object sender, EventArgs e)
        {
            mtb_numeric.Focus();
            rtb_numero.Text = rtb_numero.Text + mtb_numeric.Text + "\n";

            if (prgNumeros.Value <= 90)
            {
                prgNumeros.Value += 10;
                lblPorcentagem.Text = " " + prgNumeros.Value + "%";

                mtb_numeric.Clear();
            }
            else
            {
                rtb_numero.Visible = false;
                MessageBox.Show("Você chegou no limite");
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            prgNumeros.Value = prgNumeros.Value + 10;
        }
    }
}