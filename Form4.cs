using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace teste1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private string connectionString = "Server=autorack.proxy.rlwy.net;Port=56068;Database=railway;Uid=root;Pwd=vMAGkfLCPCkwdxiTMxfRZEYrOXoWKeBq;";



        private void BuscarDados(int id)
        {
            try
            {
     
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM dados WHERE ID = @ID";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", id);

                       
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                   
                                    int idResult = reader.GetInt32("ID");
                                    string ocorrido = reader.GetString("Ocorrido");
                                    string danoFisico = reader.GetString("Dano_Fisico");
                                    string danoMaterial = reader.GetString("Dano_Material");
                                    string setor = reader.GetString("Setor");
                                    string local = reader.GetString("Local");
                                    DateTime data = reader.GetDateTime("Data");
                                    string horario = reader.GetString("Horario");
                                    string texto = reader.GetString("Texto");
                                    
                                    DateTime dateTime= reader.GetDateTime("Data");  
                                    DateTime dataSemHora = data.Date;

                                    TX2.Text = "Ocorrido: " + ocorrido;
                                    TX3.Text = "Dano Físico: " + danoFisico;
                                    TX4.Text = "Dano Material: " + danoMaterial;
                                    TX5.Text = "setor: " + setor;
                                    TX6.Text = "local: " + local;
                                    TX7.Text = "Data: " + dataSemHora.ToShortDateString();
                                    TX8.Text = "Descrição: " + texto;
                                    TX9.Text = "horario: " + horario + "Horas";

                                    
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nenhum registro encontrado com o ID especificado.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

   

        private void Close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mini_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pesquisa_Click_1(object sender, EventArgs e)
        {
            int valortxt;
            valortxt = int.Parse(TX1.Text);
            int id = valortxt;
            if (id > 0)
            {
                BuscarDados(id);
            }
        }

        private void alterar_Click(object sender, EventArgs e)
        {
            string idPesquisa = TX1.Text;  

            
            string ocorrido = TX2.Text.Replace("Ocorrido: ", "").Trim();
            string danoFisico = TX3.Text.Replace("Dano Físico: ", "").Trim();
            string danoMaterial = TX4.Text.Replace("Dano Material: ", "").Trim();
            string setor = TX5.Text.Replace("Setor: ", "").Trim();
            string local = TX6.Text.Replace("Local: ", "").Trim();

            
            string dataTexto = TX7.Text.Replace("Data: ", "").Trim();
            DateTime data;
            bool dataValida = DateTime.TryParse(dataTexto, out data);  

            if (!dataValida)
            {
                MessageBox.Show("Por favor, insira uma data válida no formato correto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string texto = TX8.Text.Replace("Descrição: ", "").Trim();
            string horario = TX9.Text.Replace("Horário: ", "").Trim();

            try
            {
                
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                   
                    string query = @"
                UPDATE dados
                SET 
                    Ocorrido = @Ocorrido, 
                    Dano_Fisico = @DanoFisico, 
                    Dano_Material = @DanoMaterial, 
                    Setor = @Setor, 
                    Local = @Local, 
                    Data = @Data, 
                    Texto = @Texto, 
                    Horario = @Horario
                WHERE ID = @ID";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        
                        cmd.Parameters.AddWithValue("@Ocorrido", ocorrido);
                        cmd.Parameters.AddWithValue("@DanoFisico", danoFisico);
                        cmd.Parameters.AddWithValue("@DanoMaterial", danoMaterial);
                        cmd.Parameters.AddWithValue("@Setor", setor);
                        cmd.Parameters.AddWithValue("@Local", local);
                        cmd.Parameters.AddWithValue("@Data", data.ToString("yyyy-MM-dd"));  
                        cmd.Parameters.AddWithValue("@Texto", texto);
                        cmd.Parameters.AddWithValue("@Horario", horario);
                        cmd.Parameters.AddWithValue("@ID", idPesquisa);  

                        
                        int rowsAffected = cmd.ExecuteNonQuery();

                        
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Informações alteradas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível atualizar as informações. Verifique o ID.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void apagar_Click(object sender, EventArgs e)
        {
            TX1.Clear();
            TX2.Clear();
            TX3.Clear();
            TX4.Clear();
            TX5.Clear();
            TX6.Clear();
            TX7.Clear();
            TX9.Clear();
            TX8.Clear();
            {
                try
                {
                    
                    string id = TX1.Text; 
                    if (string.IsNullOrEmpty(id))
                    {
                        MessageBox.Show("Por favor, informe o ID para excluir o registro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                   
                        string query = "DELETE FROM dados WHERE ID = @ID";  

                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            
                            cmd.Parameters.AddWithValue("@ID", id);

                            int rowsAffected = cmd.ExecuteNonQuery();  

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Nenhum registro encontrado com esse ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                 
                    MessageBox.Show($"Erro ao excluir o registro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}