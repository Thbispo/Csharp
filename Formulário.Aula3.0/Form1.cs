using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Formulário.Aula3._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            string nomeTitulo = "";
            string nomeGenero = "";
            int AnoFilme;
            int AvaliacaoFilme;
            nomeTitulo = textBox_Titulo.Text;
            nomeGenero = textBox_Genero.Text;
            AnoFilme = int.Parse(textBox_Ano.Text);
            AvaliacaoFilme = int.Parse(textBox_Avaliacao.Text);
            pictureBox1.Visible = true;

            label_Titulo.Text = nomeTitulo;
            label_Avaliacao.Text = AvaliacaoFilme.ToString();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            textBox_Titulo.Text = string.Empty;
            textBox_Genero.Text = string.Empty;
            textBox_Ano.Text = string.Empty;
            textBox_Avaliacao.Text = string.Empty;
            pictureBox1 .Visible = false;
        }

        
    }
       

}

