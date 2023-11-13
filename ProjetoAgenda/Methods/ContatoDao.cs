using MySql.Data.MySqlClient;
using ProjetoAgenda.Connection;
using ProjetoAgenda.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda.Methods
{
    public class ContatoDao
    {
        MySqlConnection conexao;

        public ContatoDao()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Método que cadastra contato
        public void CadastrarContato(Contato obj)
        {
            try
            {
                //Definir o comando SQL - insert into
                string sql = "insert into contatos (nome, email, idade, cpf) values (@nome, @email, @idade, @cpf)";
                
                //Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.Nome);
                executacmd.Parameters.AddWithValue("@email", obj.Email);
                executacmd.Parameters.AddWithValue("@idade", obj.Idade);
                executacmd.Parameters.AddWithValue("@cpf", obj.Cpf);

                //Abrir a conexao e executar o comando
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Contato cadastrado com sucesso!");

                //Fechar a conexao
                conexao.Clone();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }
        #endregion

        #region Método para editar cadastro
        public void EditarContato()
        {

        }
        #endregion
    }
}
