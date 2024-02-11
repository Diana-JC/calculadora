namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            int valor1, valor2;


            //Entrada de datos
            valor1 = int.Parse(txt_Valor1.Text);
            valor2 = int.Parse(txt_Valor2.Text);

          
            int Suma = valor1 + valor2;
            int Resta = valor1 - valor2;
            int Multiplicacion = valor1 * valor2;
            int Division = valor1 / valor2;

            //Salida de datos
            txt_Suma.Text = Suma.ToString();
            txt_Resta.Text = Resta.ToString();
            txt_Multiplicacion.Text = Multiplicacion.ToString();
            txt_Division.Text = Division.ToString();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Valor1.Clear();
            txt_Valor2.Clear();
            txt_Suma.Clear();
            txt_Resta.Clear();
            txt_Multiplicacion.Clear();
            txt_Division.Clear();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
