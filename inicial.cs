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
    public partial class inicial : Form
    {
        public inicial()
        {
            InitializeComponent();
        }

        private void inicial_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmcadastro cad = new frmcadastro();
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
    }
}
