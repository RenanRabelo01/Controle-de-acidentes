namespace teste1
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
            System.Windows.Forms.Button barra;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelBarra = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.Mini = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EX1 = new System.Windows.Forms.CheckedListBox();
            this.BX1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BX2 = new System.Windows.Forms.TextBox();
            this.BX6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Novo = new System.Windows.Forms.Button();
            this.Registrar = new System.Windows.Forms.Button();
            this.Apagar = new System.Windows.Forms.Button();
            this.Relatorio = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BX3 = new System.Windows.Forms.TextBox();
            this.EX3 = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Pesquisa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.EX2 = new System.Windows.Forms.CheckBox();
            this.EX4 = new System.Windows.Forms.CheckBox();
            barra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // barra
            // 
            barra.BackColor = System.Drawing.SystemColors.Window;
            barra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            barra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            barra.Location = new System.Drawing.Point(-3, -1);
            barra.Margin = new System.Windows.Forms.Padding(0);
            barra.Name = "barra";
            barra.Size = new System.Drawing.Size(1128, 32);
            barra.TabIndex = 0;
            barra.UseVisualStyleBackColor = false;
            barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseDown);
            // 
            // panelBarra
            // 
            this.panelBarra.AutoSize = true;
            this.panelBarra.Location = new System.Drawing.Point(549, 131);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(0, 16);
            this.panelBarra.TabIndex = 1;
            // 
            // Close
            // 
            this.Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Close.BackgroundImage")));
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Close.Location = new System.Drawing.Point(1067, 4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(30, 23);
            this.Close.TabIndex = 2;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Mini
            // 
            this.Mini.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Mini.BackgroundImage")));
            this.Mini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Mini.Location = new System.Drawing.Point(1031, 4);
            this.Mini.Name = "Mini";
            this.Mini.Size = new System.Drawing.Size(30, 23);
            this.Mini.TabIndex = 3;
            this.Mini.UseVisualStyleBackColor = true;
            this.Mini.Click += new System.EventHandler(this.Mini_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 31);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // EX1
            // 
            this.EX1.FormattingEnabled = true;
            this.EX1.Items.AddRange(new object[] {
            "Fatalidade (acidente com morte)",
            "Acidente Com afastamento",
            "Acidente Sem afastamento",
            "Incidentes (quase acidentes)",
            "Desvios"});
            this.EX1.Location = new System.Drawing.Point(11, 92);
            this.EX1.Name = "EX1";
            this.EX1.Size = new System.Drawing.Size(245, 106);
            this.EX1.TabIndex = 5;
            this.EX1.SelectedIndexChanged += new System.EventHandler(this.EX1_SelectedIndexChanged);
            // 
            // BX1
            // 
            this.BX1.Location = new System.Drawing.Point(8, 333);
            this.BX1.Name = "BX1";
            this.BX1.Size = new System.Drawing.Size(245, 22);
            this.BX1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(8, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Informe Qual Setor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(8, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Informe Local";
            // 
            // BX2
            // 
            this.BX2.Location = new System.Drawing.Point(8, 393);
            this.BX2.Name = "BX2";
            this.BX2.Size = new System.Drawing.Size(245, 22);
            this.BX2.TabIndex = 9;
            // 
            // BX6
            // 
            this.BX6.Location = new System.Drawing.Point(365, 84);
            this.BX6.Multiline = true;
            this.BX6.Name = "BX6";
            this.BX6.Size = new System.Drawing.Size(732, 405);
            this.BX6.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(362, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Informe Ocorrido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "SAFE-OMNI";
            // 
            // Novo
            // 
            this.Novo.BackColor = System.Drawing.SystemColors.Window;
            this.Novo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Novo.Location = new System.Drawing.Point(17, 37);
            this.Novo.Name = "Novo";
            this.Novo.Size = new System.Drawing.Size(75, 41);
            this.Novo.TabIndex = 14;
            this.Novo.Text = "Novo";
            this.Novo.UseVisualStyleBackColor = false;
            this.Novo.Click += new System.EventHandler(this.Novo_Click);
            // 
            // Registrar
            // 
            this.Registrar.BackColor = System.Drawing.SystemColors.Window;
            this.Registrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Registrar.Location = new System.Drawing.Point(986, 500);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(111, 47);
            this.Registrar.TabIndex = 15;
            this.Registrar.Text = "Registrar";
            this.Registrar.UseVisualStyleBackColor = false;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // Apagar
            // 
            this.Apagar.BackColor = System.Drawing.SystemColors.Window;
            this.Apagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Apagar.Location = new System.Drawing.Point(365, 506);
            this.Apagar.Name = "Apagar";
            this.Apagar.Size = new System.Drawing.Size(75, 41);
            this.Apagar.TabIndex = 16;
            this.Apagar.Text = "Apagar";
            this.Apagar.UseVisualStyleBackColor = false;
            this.Apagar.Click += new System.EventHandler(this.Apagar_Click);
            // 
            // Relatorio
            // 
            this.Relatorio.BackColor = System.Drawing.SystemColors.Window;
            this.Relatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Relatorio.Location = new System.Drawing.Point(446, 506);
            this.Relatorio.Name = "Relatorio";
            this.Relatorio.Size = new System.Drawing.Size(87, 41);
            this.Relatorio.TabIndex = 17;
            this.Relatorio.Text = "Relatório";
            this.Relatorio.UseVisualStyleBackColor = false;
            this.Relatorio.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 19;
            this.label5.Tag = "  /  /";
            this.label5.Text = "Data";
            // 
            // BX3
            // 
            this.BX3.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.BX3.Location = new System.Drawing.Point(12, 477);
            this.BX3.Name = "BX3";
            this.BX3.Size = new System.Drawing.Size(96, 22);
            this.BX3.TabIndex = 18;
            this.BX3.Tag = "";
            // 
            // EX3
            // 
            this.EX3.FormattingEnabled = true;
            this.EX3.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.EX3.Location = new System.Drawing.Point(265, 92);
            this.EX3.Name = "EX3";
            this.EX3.Size = new System.Drawing.Size(71, 463);
            this.EX3.TabIndex = 24;
            this.EX3.SelectedIndexChanged += new System.EventHandler(this.EX3_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(265, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Horario";
            // 
            // Pesquisa
            // 
            this.Pesquisa.BackColor = System.Drawing.SystemColors.Window;
            this.Pesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pesquisa.Location = new System.Drawing.Point(539, 506);
            this.Pesquisa.Name = "Pesquisa";
            this.Pesquisa.Size = new System.Drawing.Size(87, 41);
            this.Pesquisa.TabIndex = 26;
            this.Pesquisa.Text = "Pesquisa";
            this.Pesquisa.UseVisualStyleBackColor = false;
            this.Pesquisa.Click += new System.EventHandler(this.Pesquisa_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 506);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "EX: 2021-02-16";
            // 
            // EX2
            // 
            this.EX2.AutoSize = true;
            this.EX2.Location = new System.Drawing.Point(17, 219);
            this.EX2.Name = "EX2";
            this.EX2.Size = new System.Drawing.Size(96, 20);
            this.EX2.TabIndex = 29;
            this.EX2.Text = "Dano fisico";
            this.EX2.UseVisualStyleBackColor = true;
            // 
            // EX4
            // 
            this.EX4.AutoSize = true;
            this.EX4.Location = new System.Drawing.Point(17, 245);
            this.EX4.Name = "EX4";
            this.EX4.Size = new System.Drawing.Size(113, 20);
            this.EX4.TabIndex = 30;
            this.EX4.Text = "Dano Material";
            this.EX4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1109, 559);
            this.Controls.Add(this.EX4);
            this.Controls.Add(this.EX2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Pesquisa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EX3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BX3);
            this.Controls.Add(this.Relatorio);
            this.Controls.Add(this.Apagar);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.Novo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BX6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BX2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BX1);
            this.Controls.Add(this.EX1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Mini);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.panelBarra);
            this.Controls.Add(barra);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label panelBarra;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Mini;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckedListBox EX1;
        private System.Windows.Forms.TextBox BX1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BX2;
        private System.Windows.Forms.TextBox BX6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Novo;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.Button Apagar;
        private System.Windows.Forms.Button Relatorio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BX3;
        private System.Windows.Forms.CheckedListBox EX3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Pesquisa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox EX2;
        private System.Windows.Forms.CheckBox EX4;
    }
}

