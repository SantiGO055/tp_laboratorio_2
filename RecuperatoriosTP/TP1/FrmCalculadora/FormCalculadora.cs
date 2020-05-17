using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FrmCalculadora
{
    public partial class FormCalculadora : Form
    {
        /// <summary>
        /// Constructor publico que llama al metodo InitializeComponent y dibuja los recuadros en pantalla
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo que pregunta si se desea cerrar el programa o no
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro que deea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                e.Cancel = true;
        }

        /// <summary>
        /// Boton que llama al metodo limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Metodo privado que limpia los campos de numeros, operador y resultado
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            lblResultado.Text = "";
            cmbOperar.Text = "";
        }

        /// <summary>
        /// Metodo privado estatico que realizara la operacion llamando al metodo Operar de la clase Calculadora
        /// </summary>
        /// <param name="numero1">Numero 1 de tipo string</param>
        /// <param name="numero2">Numero 2 de tipo string</param>
        /// <param name="operador">Operador de tipo string</param>
        /// <returns>Retorna el resultado de la operacion realizada</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            double resultado = 0;
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            resultado = Calculadora.Operar(num1, num2, operador);
            return resultado;
        }

        private static string ConvertirADecimal(string resultado)
        {
            Numero resultadoDeOperacion = new Numero(resultado);
            return resultadoDeOperacion.BinarioDecimal(resultado.ToString());
        }
        /// <summary>
        /// Boton que convertira a decimal
        /// Si la etiqueta resultado no esta vacia realizara la conversion llamando al metodo BinarioDecimal de la clase Numero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            double resultado;

            if (lblResultado.Text != string.Empty)
            {
                lblResultado.Text = ConvertirADecimal(lblResultado.Text);
            }
            else
            {
                MessageBox.Show("ERROR! Sin resultado", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Boton convertirABinario
        /// Si la etiqueta resultado no esta vacia realizara la conversion llamando al metodo DecimalBinario de la clase numero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            double resultado;
            int click = 0;

            if (lblResultado.Text != string.Empty)
            {
                double.TryParse(lblResultado.Text, out resultado);
                lblResultado.Text = Numero.DecimalBinario(resultado);
            }
            else
            {
                MessageBox.Show("ERROR! Sin resultado", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Boton operar, si los numeros no contienen texto mostrara el resultado de la operacion en etiqueta resultado
        /// Caso contrario mostrara un mensaje indicando que se revise los numeros y el operador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {

            if (this.txtNumero1.Text == string.Empty || this.txtNumero2.Text == string.Empty)
            {
                MessageBox.Show("ERROR! Revise los numeros y operador", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperar.Text).ToString();
            }

        }
    }
}
