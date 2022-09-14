using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diamond_story_grupo3
{
    public partial class frmentrar : Form
    {
        public frmentrar()
        {
            InitializeComponent();
        }
        Conexao bd = new Conexao();
        string sql;

        public void Limpar()
        {
            txtusuario.Clear();
            txtnome.Clear();
            txtsenha.Clear();
            txtemail.Clear();
        }

        public void listar()
        {
            sql = "Select * from cliente";
            dtglistar.DataSource = bd.ConsultarTabelas(sql);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtemail.Text == "" || txtnome.Text == "" || txtsenha.Text == "" || txtusuario.Text == "")
            {
                MessageBox.Show("Esta faltando dados");
            }
            else
            {
                DataTable buscar = new DataTable();
                sql = string.Format("select * from cliente where  usuario = '{0}' and nome = '{1}' and senha = '{2}' and email = '{3}'", txtusuario.Text , txtnome.Text , txtsenha.Text,txtemail.Text);
                buscar = bd.ConsultarTabelas(sql);
                dtglistar.DataSource = buscar;

                if (buscar.Rows.Count > 0)
                {
                    txtusuario.Text = buscar.Rows[0]["usuario"].ToString();
                    txtnome.Text = buscar.Rows[0]["nome"].ToString();
                    txtsenha.Text = buscar.Rows[0]["sexo"].ToString();
                    txtemail.Text = buscar.Rows[0]["email"].ToString();

                }

                else
                {
                    MessageBox.Show("Cadastro do cliente não foi encontrado!!!", "Buscar cadastro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpar();

                }
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            inicial cad = new inicial();
            cad.ShowDialog();
            this.Visible = true;
        }

       

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from cliente where usuario = '{0}'", txtusuario.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("cadastro do cliente excluido com sucesso!!!", "Excluir cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpar();
            listar();
        }

        private void btncadastrar_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            frmcadastro cad = new frmcadastro();
            cad.ShowDialog();
            this.Visible = true;
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
      
        }
    }
}
