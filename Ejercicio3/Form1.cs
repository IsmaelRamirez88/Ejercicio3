using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular()
        {
            int NumFac = 0;
            string Factoreial = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(txtNumero.Text))
                {

                    int n = 0;
                    bool EsNumero = int.TryParse(txtNumero.Text, out n);
                    if (EsNumero && Convert.ToInt32(txtNumero.Text) > 1)
                    {
                        NumFac = Convert.ToInt32(txtNumero.Text);
                        Factoreial = txtNumero.Text;
                        int NumMultiplica = 0; 

                        for (int i = NumFac - 1; i >= 1; i--)
                        {
                            NumFac *= i; 
                            Factoreial = Factoreial + " * " + i;
                        }
                        lblMensaje.Text = $"El factorial de {txtNumero.Text} es igual a {NumFac} ";
                        lblDescripcion.Text = $"Cálculo del factorial de {txtNumero.Text}: ";
                        lblCalculoF.Text = txtNumero.Text + "!: " + Factoreial; 
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }
    }
}
