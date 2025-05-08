using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumeroAleatorio_AL
{
    public partial class Form1 : Form
    {
        int intentos = 0; // inicializar la variable intentos
        Random rand = new Random(); // vrear el objetos rand con la funcion random
        int aleatorio = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            intentos = 5; //cantidad de intentos
            txtintentos.Text = intentos.ToString();
            aleatorio = rand.Next(1, 50); //aleatorio es igual a un numero entre 1 y 50
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtnumero.Text, out int num) & num > 0)
            {
                if (num == aleatorio)
                {
                    MessageBox.Show($"adivino! el numero es {aleatorio}");
                    DialogResult resultado = MessageBox.Show(" ¿Quieres volver a intentarlo?", "reintentar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado== DialogResult.No)
                    {
                        MessageBox.Show(" Gracias por jugar");
                        Application.Exit();
                    }
                    else
                    {
                        intentos = 5;
                        txtintentos.Text = intentos.ToString();
                        aleatorio = rand.Next(1, 50);
                    }
                }
                if (num > aleatorio)
                {
                    MessageBox.Show($"{num} es mayor que el numero");
                    intentos = intentos - 1;
                    txtintentos.Text = intentos.ToString();
                }
                if (num < aleatorio)
                {
                    MessageBox.Show($"{num} es menor que el numero");
                    intentos = intentos - 1;
                    txtintentos.Text = intentos.ToString();
                }
                if (intentos ==0)
                {
                    DialogResult resultado = MessageBox.Show(" Se acabaron los intentos. ¿Intentar de nuevo?", "Derrota :(", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (resultado == DialogResult.No)
                    {
                        MessageBox.Show(" Gracias por jugar");
                        Application.Exit();
                    }
                    else
                    {
                        intentos = 5;
                        txtintentos.Text = intentos.ToString();
                        aleatorio = rand.Next(1, 50);
                    }
                }
            }
            else
            {
                MessageBox.Show("ingrese un numero valido");
            }
        }
    }
}
