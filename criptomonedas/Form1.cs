namespace criptomonedas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnproceso_Click(object sender, EventArgs e)
        {
            if (txttipoMoneda.SelectedIndex == -1)
            {
                MessageBox.Show("No has seleccionado nada");
            }
            else
            {
                string tipoMoneda = txttipoMoneda.SelectedItem.ToString();
                double cantidad = Convert.ToDouble(txtcantidad.Text);
                double total = this.intercambioMoneda(tipoMoneda, cantidad);
                txttotal.Text = total.ToString();

            }
        }

        public double intercambioMoneda(string opcion, double cantidad)
        {
            double total = 0;

            switch(opcion)
            {
                case "Doge":
                    total = cantidad / 0.001;
                    break;
                case "XRP":
                    total = cantidad / 1.6;
                    break;
                case "Bitcoin":
                    total = cantidad / 10000;
                    break;
                case "BAT":
                    total = cantidad / 1;
                    break;
                default:
                    MessageBox.Show("Opcion no encontrada");
                    break;
            }

            return total;
        }

    }
}