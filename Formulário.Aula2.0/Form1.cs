using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulário.Aula2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Mostrar1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void button_Mostrar2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
          
        }

        private void button_Apagar1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void button_Apagar2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible=false;
        }

     
        private void button_zoom2_Click(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button_Stretchimage2_Click(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
