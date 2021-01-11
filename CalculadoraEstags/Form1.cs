using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraEstags
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(txtValor1.Text);

            int valor2 = Convert.ToInt32(txtValor2.Text);

            int resultado = valor1 + valor2;

            MessageBox.Show(Convert.ToString(resultado));
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(txtValor1.Text);

            int valor2 = Convert.ToInt32(txtValor2.Text);

            int resultado = valor1 * valor2;

            MessageBox.Show(Convert.ToString(resultado));
        }

        private void btnMaiorValor_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(txtValor1.Text);

            int valor2 = Convert.ToInt32(txtValor2.Text);

            if (valor1 > valor2)
            {
                MessageBox.Show("O valor 1 é maior");
            }
            else if (valor2 > valor1)
            {
                MessageBox.Show("O valor 2 é maior");
            }
            else
            {
                MessageBox.Show("Os valores são iguais");
            }
        }
    }
}
