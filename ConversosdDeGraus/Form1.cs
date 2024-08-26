
namespace ConversosdDeGraus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calcular calc = new Calcular();
            

            if (!string.IsNullOrEmpty(txtCelsius.Text))
            {
                double celsius = Convert.ToDouble(txtCelsius.Text);
                txtFerehnheit.Text = calc.calcularCelsiusForehnhiet(celsius).ToString();
                txtKelvin.Text = calc.calcularCelsiusKelvin(celsius).ToString();
            }
            else if (!String.IsNullOrEmpty(txtFerehnheit.Text))
            {
                double forehnheit = Convert.ToDouble(txtFerehnheit.Text);
                txtCelsius.Text = calc.calcularForehnhietcelsius(forehnheit).ToString();
                txtKelvin.Text = calc.calcularForehnhietKelvin(forehnheit).ToString();
            }
            else
            {
                double kelvin = Convert.ToDouble(txtKelvin.Text);
                txtCelsius.Text = calc.calcularKelvinCelsius(kelvin).ToString();
                txtFerehnheit.Text = calc.calcularKelvinForehnhit(kelvin).ToString();
            }



        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCelsius.Clear();
            txtFerehnheit.Clear();
            txtKelvin.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
