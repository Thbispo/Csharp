namespace Formulário.Aula2._0
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_Mostrar1 = new System.Windows.Forms.Button();
            this.button_Apagar1 = new System.Windows.Forms.Button();
            this.button_Mostrar2 = new System.Windows.Forms.Button();
            this.button_Apagar2 = new System.Windows.Forms.Button();
            this.button_Apagartudo = new System.Windows.Forms.Button();
            this.button_Exibirtudo = new System.Windows.Forms.Button();
            this.button_Stretchimage2 = new System.Windows.Forms.Button();
            this.button_zoom2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(490, 213);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(424, 237);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // button_Mostrar1
            // 
            this.button_Mostrar1.Location = new System.Drawing.Point(464, 26);
            this.button_Mostrar1.Name = "button_Mostrar1";
            this.button_Mostrar1.Size = new System.Drawing.Size(109, 40);
            this.button_Mostrar1.TabIndex = 2;
            this.button_Mostrar1.Text = "Mostrar Imagem 1";
            this.button_Mostrar1.UseVisualStyleBackColor = true;
            this.button_Mostrar1.Click += new System.EventHandler(this.button_Mostrar1_Click);
            // 
            // button_Apagar1
            // 
            this.button_Apagar1.Location = new System.Drawing.Point(464, 85);
            this.button_Apagar1.Name = "button_Apagar1";
            this.button_Apagar1.Size = new System.Drawing.Size(109, 39);
            this.button_Apagar1.TabIndex = 3;
            this.button_Apagar1.Text = "Apagar Imagem 1";
            this.button_Apagar1.UseVisualStyleBackColor = true;
            this.button_Apagar1.Click += new System.EventHandler(this.button_Apagar1_Click);
            // 
            // button_Mostrar2
            // 
            this.button_Mostrar2.Location = new System.Drawing.Point(314, 308);
            this.button_Mostrar2.Name = "button_Mostrar2";
            this.button_Mostrar2.Size = new System.Drawing.Size(134, 40);
            this.button_Mostrar2.TabIndex = 4;
            this.button_Mostrar2.Text = "Mostar Imagem 2";
            this.button_Mostrar2.UseVisualStyleBackColor = true;
            this.button_Mostrar2.Click += new System.EventHandler(this.button_Mostrar2_Click);
            // 
            // button_Apagar2
            // 
            this.button_Apagar2.Location = new System.Drawing.Point(314, 369);
            this.button_Apagar2.Name = "button_Apagar2";
            this.button_Apagar2.Size = new System.Drawing.Size(134, 40);
            this.button_Apagar2.TabIndex = 5;
            this.button_Apagar2.Text = "Apagar Imagem2";
            this.button_Apagar2.UseVisualStyleBackColor = true;
            this.button_Apagar2.Click += new System.EventHandler(this.button_Apagar2_Click);
            // 
            // button_Apagartudo
            // 
            this.button_Apagartudo.Location = new System.Drawing.Point(749, 145);
            this.button_Apagartudo.Name = "button_Apagartudo";
            this.button_Apagartudo.Size = new System.Drawing.Size(152, 35);
            this.button_Apagartudo.TabIndex = 6;
            this.button_Apagartudo.Text = "Apagar as duas imagens";
            this.button_Apagartudo.UseVisualStyleBackColor = true;
            // 
            // button_Exibirtudo
            // 
            this.button_Exibirtudo.Location = new System.Drawing.Point(749, 105);
            this.button_Exibirtudo.Name = "button_Exibirtudo";
            this.button_Exibirtudo.Size = new System.Drawing.Size(152, 34);
            this.button_Exibirtudo.TabIndex = 7;
            this.button_Exibirtudo.Text = "Exibir as duas imagens";
            this.button_Exibirtudo.UseVisualStyleBackColor = true;
            // 
            // button_Stretchimage2
            // 
            this.button_Stretchimage2.Location = new System.Drawing.Point(174, 260);
            this.button_Stretchimage2.Name = "button_Stretchimage2";
            this.button_Stretchimage2.Size = new System.Drawing.Size(134, 38);
            this.button_Stretchimage2.TabIndex = 8;
            this.button_Stretchimage2.Text = "StretchImage Imagem 1";
            this.button_Stretchimage2.UseVisualStyleBackColor = true;
            this.button_Stretchimage2.Click += new System.EventHandler(this.button_Stretchimage2_Click);
            // 
            // button_zoom2
            // 
            this.button_zoom2.Location = new System.Drawing.Point(314, 260);
            this.button_zoom2.Name = "button_zoom2";
            this.button_zoom2.Size = new System.Drawing.Size(134, 38);
            this.button_zoom2.TabIndex = 9;
            this.button_zoom2.Text = "Zoom Imagem 1";
            this.button_zoom2.UseVisualStyleBackColor = true;
            this.button_zoom2.Click += new System.EventHandler(this.button_zoom2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_zoom2);
            this.Controls.Add(this.button_Stretchimage2);
            this.Controls.Add(this.button_Exibirtudo);
            this.Controls.Add(this.button_Apagartudo);
            this.Controls.Add(this.button_Apagar2);
            this.Controls.Add(this.button_Mostrar2);
            this.Controls.Add(this.button_Apagar1);
            this.Controls.Add(this.button_Mostrar1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Trabalhando com imagens";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_Mostrar1;
        private System.Windows.Forms.Button button_Apagar1;
        private System.Windows.Forms.Button button_Mostrar2;
        private System.Windows.Forms.Button button_Apagar2;
        private System.Windows.Forms.Button button_Apagartudo;
        private System.Windows.Forms.Button button_Exibirtudo;
        private System.Windows.Forms.Button button_Stretchimage2;
        private System.Windows.Forms.Button button_zoom2;
        private System.Windows.Forms.Button button1;
    }
}

