using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loteria02
{
    public partial class Form1 : Form
    {
        Random MinumeroAleatorio = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            int primera;
            int segunda;
            int tercera;
            int numero;

            numero = Convert.ToInt32(txtNumero.Text);

            primera = MinumeroAleatorio.Next(0, 99);
            segunda = MinumeroAleatorio.Next(0, 99);
            tercera = MinumeroAleatorio.Next(0, 99);


            txtPrimera.Text = primera.ToString();
            txtSegunda.Text = segunda.ToString();
            txtTercera.Text = tercera.ToString();


            if (numero == primera)

            {
                lblResultado.Text = "Te sacaste En Primera";
            }else if (numero == segunda)
            {

                lblResultado.Text = "Te sacaste En Segunda";

            }
            else if (numero == tercera) 
            {
                lblResultado.Text = "Te sacaste En Tercera";


            }
            else
            {
                lblResultado.Text = "Te Guallaste";
            }


            


            




        }
    }
}
