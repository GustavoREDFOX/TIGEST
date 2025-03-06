using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIGEST
{
    public partial class Form1 : Form
    {
        SqlConnection conexao = new SqlConnection(@"Data Source=dsqlapp039-01br;Initial Catalog=db_tigest;User ID=ppe;Password=ppe;Encrypt=False");
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {   
            string nome = txt_Usuario.Text;
            string senha = txt_Senha.Text;

            conexao.Open();
            string query = $"SELECT * FROM tbUsuario WHERE id_Nome = @nome and id_senha = @senha";
            
            using (SqlCommand cmd = new SqlCommand(query, conexao))
            {
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@senha", senha);

                int count = (cmd.ExecuteScalar() as int?) ?? 0; // Retorna o número de registros encontrados

                if (count > 0) // Se encontrou usuário, faz login
                {
                    Frm_TelaInicial frm_TelaInicial = new Frm_TelaInicial();
                    this.Hide();
                    conexao.Close();
                    frm_TelaInicial.Show();
                }
                else
                {
                    MessageBox.Show("Senha ou usuário incorretos, por gentileza verifique suas credenciais e tente novamente!");
                    conexao.Close();
                }
            }
        }
    }
}
