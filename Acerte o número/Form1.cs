using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acerte_o_número
{
    public partial class Form1 : Form
    {
        int minimo = 0;
        int maximo = 100;
        int numero = 0;
        int tentativas = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            text_numero.Enabled = false;
            label_informacao.Text = "Acerte o número.";
        }

        private void cmd_iniciar_Click(object sender, EventArgs e)
        {
            tentativas = 0;
            minimo = 0;
            maximo = 1000;
            Random rnd = new Random();
            numero = rnd.Next(minimo, maximo);

            label_informacao.Text = "Jogo iniciado" +
                Environment.NewLine +
                "Acerte o número entre" + Environment.NewLine +
                string.Format("{0} e {1}", minimo, maximo);

            text_numero.Enabled = true;
            text_numero.Text = "";
            text_numero.Focus();
            cmd_iniciar.Enabled = false;
        }

        private void text_numero_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return && text_numero.Text != "")
            {
                e.SuppressKeyPress = true;
                int.TryParse(text_numero.Text, out int valor);

                if(valor < numero)
                {
                    label_informacao.Text = "O número é mais alto";
                    tentativas++;
                }
                else if (valor > numero)
                {
                    label_informacao.Text = "O número é mais baixo";
                    tentativas++;

                }
                else
                {
                    label_informacao.Text = "Acertou!!!" + Environment.NewLine +
                        "Tentativas: " + tentativas;
                    text_numero.Enabled = false;
                    cmd_iniciar.Enabled = true;
                }

            }
        }
    }
}
