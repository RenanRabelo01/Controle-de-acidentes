namespace teste1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button barra;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.Mini = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tx1 = new System.Windows.Forms.TextBox();
            this.CB1 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tx2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tx5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tx3 = new System.Windows.Forms.TextBox();
            this.Relatorio = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tx4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CB4 = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CB3 = new System.Windows.Forms.CheckBox();
            this.CB2 = new System.Windows.Forms.CheckBox();
            barra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // barra
            // 
            barra.BackColor = System.Drawing.SystemColors.Window;
            barra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            barra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            barra.Location = new System.Drawing.Point(-8, 0);
            barra.Margin = new System.Windows.Forms.Padding(0);
            barra.Name = "barra";
            barra.Size = new System.Drawing.Size(427, 32);
            barra.TabIndex = 1;
            barra.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 31);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "SAFE-OMNI";
            // 
            // Close
            // 
            this.Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Close.BackgroundImage")));
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Close.Location = new System.Drawing.Point(360, 5);
            this.Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(29, 23);
            this.Close.TabIndex = 15;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Mini
            // 
            this.Mini.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Mini.BackgroundImage")));
            this.Mini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Mini.Location = new System.Drawing.Point(319, 5);
            this.Mini.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mini.Name = "Mini";
            this.Mini.Size = new System.Drawing.Size(29, 23);
            this.Mini.TabIndex = 16;
            this.Mini.UseVisualStyleBackColor = true;
            this.Mini.Click += new System.EventHandler(this.Mini_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Informe Qual Setor";
            // 
            // tx1
            // 
            this.tx1.Location = new System.Drawing.Point(37, 78);
            this.tx1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx1.Name = "tx1";
            this.tx1.Size = new System.Drawing.Size(245, 22);
            this.tx1.TabIndex = 17;
            // 
            // CB1
            // 
            this.CB1.FormattingEnabled = true;
            this.CB1.Items.AddRange(new object[] {
            "Fatalidade (acidente com morte)",
            "Acidente Com afastamento",
            "Acidente Sem afastamento",
            "Incidentes (quase acidentes)",
            "Desvios"});
            this.CB1.Location = new System.Drawing.Point(37, 178);
            this.CB1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CB1.Name = "CB1";
            this.CB1.Size = new System.Drawing.Size(245, 89);
            this.CB1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Informe Local";
            // 
            // tx2
            // 
            this.tx2.Location = new System.Drawing.Point(40, 130);
            this.tx2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx2.Name = "tx2";
            this.tx2.Size = new System.Drawing.Size(245, 22);
            this.tx2.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(40, 542);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Data";
            // 
            // tx5
            // 
            this.tx5.Location = new System.Drawing.Point(40, 561);
            this.tx5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx5.Name = "tx5";
            this.tx5.Size = new System.Drawing.Size(148, 22);
            this.tx5.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Palavra chave de pesquisa";
            // 
            // tx3
            // 
            this.tx3.Location = new System.Drawing.Point(43, 377);
            this.tx3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx3.Multiline = true;
            this.tx3.Name = "tx3";
            this.tx3.Size = new System.Drawing.Size(245, 74);
            this.tx3.TabIndex = 30;
            // 
            // Relatorio
            // 
            this.Relatorio.Location = new System.Drawing.Point(267, 544);
            this.Relatorio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Relatorio.Name = "Relatorio";
            this.Relatorio.Size = new System.Drawing.Size(124, 39);
            this.Relatorio.TabIndex = 32;
            this.Relatorio.Text = "Gerar Relatório";
            this.Relatorio.UseVisualStyleBackColor = true;
            this.Relatorio.Click += new System.EventHandler(this.Relatorio_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(40, 465);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 16);
            this.label10.TabIndex = 34;
            this.label10.Text = "Data";
            // 
            // tx4
            // 
            this.tx4.Location = new System.Drawing.Point(40, 484);
            this.tx4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx4.Name = "tx4";
            this.tx4.Size = new System.Drawing.Size(148, 22);
            this.tx4.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(185, 516);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 16);
            this.label11.TabIndex = 39;
            this.label11.Text = "Ate";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(316, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 16);
            this.label12.TabIndex = 41;
            this.label12.Text = "Horario";
            // 
            // CB4
            // 
            this.CB4.FormattingEnabled = true;
            this.CB4.Items.AddRange(new object[] {
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
            this.CB4.Location = new System.Drawing.Point(319, 78);
            this.CB4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CB4.Name = "CB4";
            this.CB4.Size = new System.Drawing.Size(71, 446);
            this.CB4.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 516);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "EX: 2021-02-16";
            // 
            // CB3
            // 
            this.CB3.AutoSize = true;
            this.CB3.Location = new System.Drawing.Point(43, 319);
            this.CB3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CB3.Name = "CB3";
            this.CB3.Size = new System.Drawing.Size(113, 20);
            this.CB3.TabIndex = 44;
            this.CB3.Text = "Dano Material";
            this.CB3.UseVisualStyleBackColor = true;
            // 
            // CB2
            // 
            this.CB2.AutoSize = true;
            this.CB2.Location = new System.Drawing.Point(43, 293);
            this.CB2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CB2.Name = "CB2";
            this.CB2.Size = new System.Drawing.Size(96, 20);
            this.CB2.TabIndex = 43;
            this.CB2.Text = "Dano fisico";
            this.CB2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(413, 591);
            this.Controls.Add(this.CB3);
            this.Controls.Add(this.CB2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CB4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tx4);
            this.Controls.Add(this.Relatorio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tx5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx2);
            this.Controls.Add(this.CB1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx1);
            this.Controls.Add(this.Mini);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(barra);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Mini;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx1;
        private System.Windows.Forms.CheckedListBox CB1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tx5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tx3;
        private System.Windows.Forms.Button Relatorio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tx4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckedListBox CB4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox CB3;
        private System.Windows.Forms.CheckBox CB2;
    }
}