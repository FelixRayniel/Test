namespace Test
{
    public partial class Form1 : Form
    {
       static Double IngSis, Derecho, Psicologia, Turismo;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 0.50;
            Derecho += 1;
            Psicologia += 0.20;
            Turismo += 0.10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aptitudes aptitudes = new Aptitudes(textBox1.Text, IngSis, Derecho, Psicologia, Turismo);
            aptitudes.Show();

            double Aux = 0;

            Aux = IngSis;
            label3.Text = " Su mejor opcion es Sistemas";

            if (Aux >= Derecho)
            {
                Aux = Derecho;
                label3.Text = "Su mejor opcion es Derecho";
            }

            if (Aux >= Psicologia)
            {
                Aux = Psicologia;
                label3.Text = "Su mejor opcion es  Psicologia";
            }

            if (Aux >= Turismo)
            {
                Aux = Turismo;
                label3.Text = "Su mejor opcion es  Turismo";
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 0.60;
            Derecho += 0.80;
            Psicologia += 0.40;
            Turismo += 0.30;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 0.70;
            Derecho += 0.50;
            Psicologia += 0.40;
            Turismo += 0.70;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 1;
            Derecho += 0.30;
            Psicologia += 0.20;
            Turismo += 1;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 0.90;
            Derecho += 0.50;
            Psicologia += 1;
            Turismo += 0.80;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 0.90;
            Derecho += 1;
            Psicologia += 0.80;
            Turismo += 0.70;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 0.10;
            Derecho += 0.60;
            Psicologia += 0.90;
            Turismo += 0.20;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 0.70;
            Derecho += 0.60;
            Psicologia += 1;
            Turismo += 0.90;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 0.90;
            Derecho += 1;
            Psicologia += 0.40;
            Turismo += 1;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 1;
            Derecho += 0.40;
            Psicologia += 0.50;
            Turismo += 0.50;
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 0.90;
            Derecho += 0.80;
            Psicologia += 0.30;
            Turismo += 1;
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 1;
            Derecho += 0.90;
            Psicologia += 0.40;
            Turismo += 0.90;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 0.90;
            Derecho += 1;
            Psicologia += 1;
            Turismo += 0.60 ;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 0.70;
            Derecho += 0.30;
            Psicologia += 0.90;
            Turismo += 0.20;
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 0.90;
            Derecho += 0.90;
            Psicologia += 1;
            Turismo += 0.70;
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 0.80;
            Derecho += 1;
            Psicologia += 1;
            Turismo += 0.70;
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 1;
            Derecho += 0.80;
            Psicologia += 0.90;
            Turismo += 0.60;
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 0.80;
            Derecho += 0.70;
            Psicologia += 0.60;
            Turismo += 0.50;
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 0.90;
            Derecho += 0.90;
            Psicologia += 0;
            Turismo += 0.70;
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 0.70;
            Derecho += 0.60;
            Psicologia += 0;
            Turismo += 0.50;
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 0.90;
            Derecho += 0.40;
            Psicologia += 0.10;
            Turismo += 0.60;
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 1;
            Derecho += 0.80;
            Psicologia += 0.70;
            Turismo += 0.30;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            IngSis += 0.90;
            Derecho += 1;
            Psicologia += 0.20;
            Turismo += 0.35;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            IngSis += 0.80;
            Derecho += 0.40;
            Psicologia += 1;
            Turismo += 1;

        }
    }
}