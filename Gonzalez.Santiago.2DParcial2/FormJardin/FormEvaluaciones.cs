using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormJardin
{
    public partial class FormEvaluaciones : Form
    {
        FormAlumnos formAlumnos;
        int min;
        int seg;
        int minAux;
        Thread hilo;
        public FormEvaluaciones()
        {
            InitializeComponent();
            hilo = new Thread(Temporizador);
        }

        private void FormEvaluaciones_Load(object sender, EventArgs e)
        {
            timerTranscurrido.Start();

        }

        private void Temporizador()
        {
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seg += 1;
            string segundos = seg.ToString();
            string minutos = min.ToString();

            if (seg == 59)
            {
                min += 1;
                minAux = min;
                seg = 0;
            }
            if (seg < 10)
            {
                segundos = "0" + seg.ToString();
            }
            if (min < 10)
            {
                minutos = "0" + min.ToString();
            }
            lblTiempoTranscurrido.Text = "Tiempo transcurrido: " + minutos + ":" + segundos;

            if (seg == 20 || seg == 40)
            {
                MessageBox.Show("Ringggggg, Recreooooo");
                
                Thread.Sleep(2000);
            }
            if (min >= 1 && seg == 0)
            {
                MessageBox.Show("Ringggggg, Recreooooo");
                Thread.Sleep(5000);
            }
        }
    }
}
