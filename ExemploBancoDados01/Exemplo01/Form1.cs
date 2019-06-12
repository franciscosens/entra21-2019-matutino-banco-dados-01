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

namespace Exemplo01
{
    public partial class btnApagar : Form
    {
        public btnApagar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Carro carro = new Carro();
            carro.Modelo = txtModelo.Text;
            carro.Ano = Convert.ToInt32(nudAno.Value);
            carro.Preco = Convert.ToDecimal(mtbPreco.Text);
            carro.Cor = cbCor.SelectedItem.ToString();

            // Desenvolvimento da tela de cadastro de carro
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\MeusCarros.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO carros 
(modelo, ano, preco, cor)
VALUES (@MODELO, @ANO, @PRECO, @COR)";
            comando.Parameters.AddWithValue("@MODELO", carro.Modelo);
            comando.Parameters.AddWithValue("@ANO", carro.Ano);
            comando.Parameters.AddWithValue("@PRECO", carro.Preco);
            comando.Parameters.AddWithValue("@COR", carro.Cor);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro criado com sucesso");
            LimparCampos();
            conexao.Close();
            AtualizarTabela();
        }

        private void LimparCampos()
        {
            txtModelo.Clear();
            nudAno.Value = DateTime.Now.Year;
            cbCor.SelectedIndex = -1;
            mtbPreco.Clear();
        }

        private void AtualizarTabela()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\MeusCarros.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT id, modelo FROM carros";

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            dataGridView1.RowCount = 0;
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];
                Carro carro = new Carro();
                carro.Id = Convert.ToInt32(linha["id"]);
                carro.Modelo = linha["modelo"].ToString();
                dataGridView1.Rows.Add(new string[] {
                    carro.Id.ToString(), carro.Modelo
                });
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Cadastre um carro");
                return;
            }


            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\MeusCarros.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText =
                "DELETE FROM carros WHERE id = @ID";

            int id = Convert.ToInt32(
                dataGridView1.CurrentRow
                .Cells[0].Value);
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();

            conexao.Close();
            AtualizarTabela();
        }
    }
}
