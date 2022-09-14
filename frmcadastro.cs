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
    public partial class frmcadastro : Form
    {
        public frmcadastro()
        {
            InitializeComponent();
        }

        Conexao bd = new Conexao();
        string sql, foto;
        DateTime data;

        public void listar()
        {
            sql = "select * from alunos";
        
        }

        public void Limpar()
        {

            txtnome.Clear();
            txtsenha.Clear();
            txtemail.Clear();
            cbxestado_civ.SelectedIndex = -1;
            dtpdata.Text = DateTime.Now.ToString();
            cbxsexo.SelectedIndex = -1;
           
        }

       

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            inicial cad = new inicial();
            cad.ShowDialog();
            this.Visible = true;
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmentrar cad = new frmentrar();
            cad.ShowDialog();
            this.Visible = true;
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            if (!this.txtemail.Text.Contains('@') || !this.txtemail.Text.Contains('.'))
            {
                MessageBox.Show("Por favor digite um email valido", "Email invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                data = DateTime.Parse(dtpdata.Text);

                sql = string.Format("insert into cliente values('{0}','{1}',{2},'{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", txtusuario.Text, txtnome.Text, txtsenha.Text, txtemail.Text, data.ToString("yyy-MM-dd"), cbxsexo.Text, cbxestado_civ.Text , txtendereco.Text , txtcidade.Text , cbxestado.Text , txtcep.Text , txtcpf.Text);

                bd.AlterarTabelas(sql);
                MessageBox.Show("Cliente cadastrado com sucesso!!", "Cadastrar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
                listar();
            }
        }
    }
}
