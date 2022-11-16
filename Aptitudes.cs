using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Aptitudes : Form
    {
        double IngSis, Derecho, Psicologia, Turismo;
        string Nombre;
        public Aptitudes(string nombre, double Ingsis, double derecho, double psicologia, double turismo)
        {
            IngSis = Ingsis;
            Derecho = derecho;
            Psicologia = psicologia;
            Turismo = turismo;
            Nombre = nombre;
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 0.10;
            Derecho += 0.1;
            Psicologia += 0.40;
            Turismo += 0.1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 0.60;
            Derecho += 0.50;
            Psicologia += 0.40;
            Turismo += 0.50;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 0.1;
            Derecho += 0.80;
            Psicologia += 0.1;
            Turismo += 0.60;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 0.30;
            Derecho += 0.40;
            Psicologia += 0.50;
            Turismo += 0.20;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 0.1;
            Derecho += 0.80;
            Psicologia += 0.1;
            Turismo += 0.60;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 0.1;
            Derecho += 0.80;
            Psicologia += 0.1;
            Turismo += 0.60;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 0.40;
            Derecho += 0.70;
            Psicologia += 0.90;
            Turismo += 0.30;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 0.40;
            Derecho += 0.70;
            Psicologia += 0.50;
            Turismo += 0.40;
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 0.60;
            Derecho += 0.1;
            Psicologia += 0.1;
            Turismo += 0.90;
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 0.70;
            Derecho += 0.10;
            Psicologia += 0.20;
            Turismo += 0.30;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 0.40;
            Derecho += 0.70;
            Psicologia += 0.50;
            Turismo += 0.40;
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 0.70;
            Derecho += 0.70;
            Psicologia += 0.70;
            Turismo += 0.1;
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 0.35;
            Derecho += 0.35;
            Psicologia += 0.35;
            Turismo += 0.10;
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 0.50;
            Derecho += 0.50;
            Psicologia += 0.50;
            Turismo += 0.50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Aux = 0;

            Aux = IngSis;
            label3.Text = Nombre + " su mejor opcion es Sistemas";

            if (Aux >= Derecho)
            {
                Aux = Derecho;
                label3.Text = Nombre + " su mejor opcion es Derecho";
            }

            if (Aux >= Psicologia)
            {
                Aux = Psicologia;
                label3.Text = Nombre + " su mejor opcion es  Psicologia";
            }

            if (Aux >= Turismo)
            {
                Aux = Turismo;
                label3.Text = Nombre + " su mejor opcion es  Turismo";
            }

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            IngSis += 1;
            Derecho += 0.10;
            Psicologia += 0.20;
            Turismo += 0.10;
        }

       
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 1;
            Derecho += 0.10;
            Psicologia += 0.20;
            Turismo += 0.10;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
