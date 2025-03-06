using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TIGEST
{
    public partial class Frm_RecursosAtivos : Form
    {
        SqlConnection conexao = new SqlConnection(@"Data Source=dsqlapp039-01br;Initial Catalog=db_tigest;User ID=ppe;Password=ppe;Encrypt=False");
        public Frm_RecursosAtivos()
        {
            InitializeComponent();
        }

        private void Menu_Voltar_Click(object sender, EventArgs e)
        {
            Frm_TelaInicial frm_TelaInicial = new Frm_TelaInicial();
            this.Close();
            frm_TelaInicial.ShowDialog();
        }

        private void Btn_CarregarQwerty_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }
        private void CarregarDados()
        {
            conexao.Open();
            string query = @"SELECT nomeRecurso, categoria, tipo, departamento, localizacao, numeroSerie, observacao, numeroBp, usuarioResp, usuario.id_Nome as respAdicao, ativoAd, invent.DatIncReg, invent.flagAtivo FROM TbInventario invent inner join tbCategoria categoria on invent.id_Categoria = categoria.id inner join tbTipo tipo on invent.id_Tipo = tipo.id inner join tbLocal loc on invent.id_Localizacao = loc.id\r\ninner join tbDepartamento dp on invent.id_Departamento = dp.id inner join tbUsuario usuario on invent.respPelaAdicao = usuario.id";

            using (SqlCommand cmd = new SqlCommand(query, conexao)) 
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    if (tabela.Rows.Count > 0)
                    {
                        Dgv_DataRecursos.DataSource = tabela;
                        // Ajustar os cabeçalhos das colunas para exibição correta no DataGridView
                        Dgv_DataRecursos.Columns["Nome"].HeaderText = "Nome";
                        Dgv_DataRecursos.Columns["Categoria"].HeaderText = "Categoria";
                        Dgv_DataRecursos.Columns["Tipo"].HeaderText = "Tipo";
                        Dgv_DataRecursos.Columns["Departamento"].HeaderText = "Departamento";
                        Dgv_DataRecursos.Columns["Local"].HeaderText = "Local";
                        Dgv_DataRecursos.Columns["NumeroSerie"].HeaderText = "Número de Série";
                        Dgv_DataRecursos.Columns["Observacao"].HeaderText = "Observação";
                        Dgv_DataRecursos.Columns["BemPatrimonial"].HeaderText = "Bem Patrimonial";
                        Dgv_DataRecursos.Columns["Responsavel"].HeaderText = "Responsável";
                        Dgv_DataRecursos.Columns["UsuarioResponsavel"].HeaderText = "Usuário Responsável";
                        Dgv_DataRecursos.Columns["StatusAD"].HeaderText = "Status AD";
                        Dgv_DataRecursos.Columns["DataIncluido"].HeaderText = "Data Incluído";
                        Dgv_DataRecursos.Columns["StatusAtivos"].HeaderText = "Status Ativos";
                    }
                    else
                    {
                        MessageBox.Show("Nenhum dado encontrado na tabela.");
                    }
                }
            }
        }
    }
}
