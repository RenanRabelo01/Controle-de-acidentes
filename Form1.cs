using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;

namespace teste1
{

    public partial class Form1 : Form
    {
        private string connectionString = "Server=autorack.proxy.rlwy.net;Port=56068;Database=railway;Uid=root;Pwd=vMAGkfLCPCkwdxiTMxfRZEYrOXoWKeBq;";
        



        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

      
        public Form1()
        {
            InitializeComponent();
            EX1.Enabled = false;
            EX2.Enabled = false;
            EX3.Enabled = false;
            EX4.Enabled = false;
            BX1.Enabled = false;
            BX2.Enabled = false;
            BX3.Enabled = false;
            BX6.Enabled = false;
            Registrar.Enabled = false;
            Apagar.Enabled = false;
            
           

        }


        private void BarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Enabled = false;
            form3.Show();
            form3.FormClosed += (s, args) =>
            {
                this.Enabled = true;
            };

        }

        private void Novo_Click(object sender, EventArgs e)
        {
            EX1.Enabled = !false;
            EX2.Enabled = !false;
            EX3.Enabled = !false;
            EX4.Enabled = !false;
            BX1.Enabled = !false;
            BX2.Enabled = !false;
            BX3.Enabled = !false;
            BX6.Enabled = !false;
            Registrar.Enabled = !false;
            Apagar.Enabled = !false;
            Novo.Enabled = false;  
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < EX1.Items.Count; i++)
            {
                EX1.SetItemChecked(i, false); 
            }
          
            for (int i = 0; i < EX3.Items.Count; i++)
            {
                EX3.SetItemChecked(i, false);
            }
            EX1.ClearSelected();
            EX2.Checked = false;
            EX4.Checked = false;
            EX3.ClearSelected();
            BX1.Clear();
            BX2.Clear();
            BX3.Clear();
            BX6.Clear();
        }

        private void EX1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if (EX1.Items.Count == 0)
            {
                EX1.Items.Add("Opção 1");
                EX1.Items.Add("Opção 2");
                EX1.Items.Add("Opção 3");
                EX1.Items.Add("Opção 4");
                EX1.Items.Add("Opção 5");
            }

        
            for (int i = 0; i < EX1.Items.Count; i++)
            {
                if (EX1.SelectedIndex == i)
                {
                    EX1.SetItemCheckState(i, CheckState.Checked);
                }
                else
                {
                    EX1.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }

        private void EX3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EX3.Items.Count == 0)
            {
                EX3.Items.Add("Opção 1");
                EX3.Items.Add("Opção 2");
                EX3.Items.Add("Opção 3");
                EX3.Items.Add("Opção 4");
                EX3.Items.Add("Opção 5");
                EX3.Items.Add("Opção 6");
                EX3.Items.Add("Opção 7");
                EX3.Items.Add("Opção 8");
                EX3.Items.Add("Opção 9");
                EX3.Items.Add("Opção 10");
                EX3.Items.Add("Opção 11");
                EX3.Items.Add("Opção 12");
                EX3.Items.Add("Opção 13");
                EX3.Items.Add("Opção 14");
                EX3.Items.Add("Opção 15");
                EX3.Items.Add("Opção 16");
                EX3.Items.Add("Opção 17");
                EX3.Items.Add("Opção 18");
                EX3.Items.Add("Opção 19");
                EX3.Items.Add("Opção 20");
                EX3.Items.Add("Opção 21");
                EX3.Items.Add("Opção 22");
                EX3.Items.Add("Opção 23");
                EX3.Items.Add("Opção 24");


            }


            for (int i = 0; i < EX3.Items.Count; i++)
            {
                if (EX3.SelectedIndex == i)
                {
                    EX3.SetItemCheckState(i, CheckState.Checked);
                }
                else
                {
                    EX3.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }
        private void Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(EX1.Text) || string.IsNullOrEmpty(BX1.Text) ||
                    string.IsNullOrEmpty(BX2.Text) || string.IsNullOrEmpty(BX3.Text) ||
                    string.IsNullOrEmpty(EX3.Text) || string.IsNullOrEmpty(BX6.Text))
                {
                    
                    return;
                }

                string ocorrido = EX1.Text;
                string danoFisico = EX2.Checked ? "Sim" : "Não";
                string danoMaterial = EX4.Checked ? "Sim" : "Não";
                string setor = BX1.Text;
                string local = BX2.Text;

   
                if (!DateTime.TryParse(BX3.Text, out DateTime data))
                {
                    
                    return;
                }

                string horario = EX3.Text;
                string texto = BX6.Text;

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"INSERT INTO dados
                             (Ocorrido, Dano_Fisico, Dano_Material, Setor, Local, Data, Horario, Texto) 
                             VALUES (@Ocorrido, @DanoFisico, @DanoMaterial, @Setor, @Local, @Data, @Horario, @Texto)";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Ocorrido", ocorrido);
                        cmd.Parameters.AddWithValue("@DanoFisico", danoFisico);
                        cmd.Parameters.AddWithValue("@DanoMaterial", danoMaterial);
                        cmd.Parameters.AddWithValue("@Setor", setor);
                        cmd.Parameters.AddWithValue("@Local", local);
                        cmd.Parameters.AddWithValue("@Data", data.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@Horario", horario);
                        cmd.Parameters.AddWithValue("@Texto", texto);

                        cmd.ExecuteNonQuery();

                      
                        
                    }
                }

                MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                


                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            for (int i = 0; i < EX1.Items.Count; i++)
            {
                EX1.SetItemChecked(i, false);
            }

            EX1.ClearSelected();
            EX2.Checked = false;
            EX4.Checked = false;
            EX3.ClearSelected();
            BX1.Clear();
            BX2.Clear();
            BX3.Clear();
            BX6.Clear();

            EX1.Enabled = false;
            EX2.Enabled = false;
            EX3.Enabled = false;
            EX4.Enabled = false;
            BX1.Enabled = false;
            BX2.Enabled = false;
            BX3.Enabled = false;
            BX6.Enabled = false;
            Registrar.Enabled = false;
            Apagar.Enabled = false;
            Novo.Enabled = true;
        }

        private void Pesquisa_Click(object sender, EventArgs e)
        {

            Form5 form5 = new Form5();
            this.Enabled = false;
            form5.Show();
            form5.FormClosed += (s, args) =>
            {
                this.Enabled = true;
            };

        }
    }
}

