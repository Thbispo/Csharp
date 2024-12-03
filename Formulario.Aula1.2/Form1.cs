using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario.Aula1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            string nomeCliente = "";
            string sobrenomeCliente = "";
            int idadeCliente;
            string emailCliente = "";
            nomeCliente = textBox_Nome.Text;
            sobrenomeCliente = textBox_Sobrenome.Text;
            idadeCliente = int.Parse (textBox_Idade.Text);
            emailCliente = textBox_Email.Text;
            //MessageBox.Show("Nome Completa: " + nomeCliente + " " + sobrenomeCliente + "\nIdade: " + idadeCliente + "\nEmail: " + emailCliente, "Aviso"
               // , (MessageBoxButtons)MessageBoxIcon.Warning);

            label_Nome.Text = nomeCliente;
            label_Sobrenome.Text = sobrenomeCliente;
            label_Idade.Text = idadeCliente.ToString();
            label_Email.Text = emailCliente;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
