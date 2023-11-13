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
using ProjetoAgenda.Connection;
using ProjetoAgenda.Model;
using ProjetoAgenda.Methods;

namespace ProjetoAgenda.View
{
    public partial class FrmContato : Form
    {
        public FrmContato()
        {
            InitializeComponent();
        }

        private void btntest_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexao;
                conexao = new ConnectionFactory().GetConnection();
                conexao.Open();
                MessageBox.Show("Conectado com sucesso!");

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro:" + erro);
            }
        }

        //Botão cadastrar
        private void btncadastrar_Click(object sender, EventArgs e)
        {
            Contato obj = new Contato();
            obj.Nome = txtnome.Text;
            obj.Email = txtemail.Text;
            obj.Idade = int.Parse(txtidade.Text);
            obj.Cpf = txtcpf.Text;

            //Enviar os objetos para o banco de dados
            ContatoDao dao = new ContatoDao();
            dao.CadastrarContato(obj);
        }

        //Botão editar
        private void btneditar_Click(object sender, EventArgs e)
        {

        }
    }
}
