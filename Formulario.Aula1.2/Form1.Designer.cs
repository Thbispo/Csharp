namespace Formulario.Aula1._2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button_Fechar = new System.Windows.Forms.Button();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.textBox_Sobrenome = new System.Windows.Forms.TextBox();
            this.textBox_Idade = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Nome = new System.Windows.Forms.Label();
            this.label_Sobrenome = new System.Windows.Forms.Label();
            this.label_Idade = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sobrenome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Idade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-Mail";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Cadastrar_Click);
            // 
            // button_Fechar
            // 
            this.button_Fechar.Location = new System.Drawing.Point(556, 381);
            this.button_Fechar.Name = "button_Fechar";
            this.button_Fechar.Size = new System.Drawing.Size(168, 35);
            this.button_Fechar.TabIndex = 7;
            this.button_Fechar.Text = "Fechar Aplicação";
            this.button_Fechar.UseVisualStyleBackColor = true;
            this.button_Fechar.Click += new System.EventHandler(this.button_Fechar_Click);
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(127, 83);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(366, 20);
            this.textBox_Nome.TabIndex = 9;
            this.textBox_Nome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_Sobrenome
            // 
            this.textBox_Sobrenome.Location = new System.Drawing.Point(180, 131);
            this.textBox_Sobrenome.Name = "textBox_Sobrenome";
            this.textBox_Sobrenome.Size = new System.Drawing.Size(313, 20);
            this.textBox_Sobrenome.TabIndex = 10;
            // 
            // textBox_Idade
            // 
            this.textBox_Idade.Location = new System.Drawing.Point(123, 176);
            this.textBox_Idade.Name = "textBox_Idade";
            this.textBox_Idade.Size = new System.Drawing.Size(370, 20);
            this.textBox_Idade.TabIndex = 11;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(123, 219);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(370, 20);
            this.textBox_Email.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Formulario.Aula1._2.Properties.Resources.download__1__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(499, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 239);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 13;
            // 
            // label_Nome
            // 
            this.label_Nome.AutoSize = true;
            this.label_Nome.Location = new System.Drawing.Point(56, 294);
            this.label_Nome.Name = "label_Nome";
            this.label_Nome.Size = new System.Drawing.Size(0, 13);
            this.label_Nome.TabIndex = 14;
            // 
            // label_Sobrenome
            // 
            this.label_Sobrenome.AutoSize = true;
            this.label_Sobrenome.Location = new System.Drawing.Point(56, 337);
            this.label_Sobrenome.Name = "label_Sobrenome";
            this.label_Sobrenome.Size = new System.Drawing.Size(0, 13);
            this.label_Sobrenome.TabIndex = 15;
            // 
            // label_Idade
            // 
            this.label_Idade.AutoSize = true;
            this.label_Idade.Location = new System.Drawing.Point(56, 381);
            this.label_Idade.Name = "label_Idade";
            this.label_Idade.Size = new System.Drawing.Size(0, 13);
            this.label_Idade.TabIndex = 16;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(133, 294);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(0, 13);
            this.label_Email.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(226, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cadastro de Clientes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 439);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_Idade);
            this.Controls.Add(this.label_Sobrenome);
            this.Controls.Add(this.label_Nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_Idade);
            this.Controls.Add(this.textBox_Sobrenome);
            this.Controls.Add(this.textBox_Nome);
            this.Controls.Add(this.button_Fechar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_Fechar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.TextBox textBox_Sobrenome;
        private System.Windows.Forms.TextBox textBox_Idade;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Nome;
        private System.Windows.Forms.Label label_Sobrenome;
        private System.Windows.Forms.Label label_Idade;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label7;
    }
}

