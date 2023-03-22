using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCadastro
{
    public partial class Form1 : Form
    {

   


        public Form1()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           cadastro formsCadastro =  new cadastro();
            string usuario = textBox1.Text;
            string senha = textBox2.Text;
            string mockUsuario = "admin";
            string mockSenha = "1234";

            if (usuario == mockUsuario &&  senha == mockSenha)
            {
                formsCadastro.Show();
                this.Hide();
            }
            else
            {
            }


        }
    }
}
