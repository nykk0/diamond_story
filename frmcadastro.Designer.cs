
namespace diamond_story_grupo3
{
    partial class frmcadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcadastro));
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.dtpdata = new System.Windows.Forms.DateTimePicker();
            this.lbldata = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.cbxsexo = new System.Windows.Forms.ComboBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblsenha = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.lblestado_civ = new System.Windows.Forms.Label();
            this.cbxestado_civ = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.ofdfoto = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.btnentrar = new System.Windows.Forms.Button();
            this.lblestado = new System.Windows.Forms.Label();
            this.lblcidade = new System.Windows.Forms.Label();
            this.lblendereco = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.lblcep = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.cbxestado = new System.Windows.Forms.ComboBox();
            this.txtcep = new System.Windows.Forms.MaskedTextBox();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnvoltar.Image")));
            this.btnvoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvoltar.Location = new System.Drawing.Point(849, 369);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(109, 47);
            this.btnvoltar.TabIndex = 50;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovo.Image = ((System.Drawing.Image)(resources.GetObject("btnnovo.Image")));
            this.btnnovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnovo.Location = new System.Drawing.Point(225, 369);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(109, 47);
            this.btnnovo.TabIndex = 49;
            this.btnnovo.Text = "Novo ";
            this.btnnovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // dtpdata
            // 
            this.dtpdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdata.Location = new System.Drawing.Point(415, 292);
            this.dtpdata.Name = "dtpdata";
            this.dtpdata.Size = new System.Drawing.Size(346, 26);
            this.dtpdata.TabIndex = 47;
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.Location = new System.Drawing.Point(411, 255);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(160, 20);
            this.lbldata.TabIndex = 46;
            this.lbldata.Text = "Data de nascimento :";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsexo.Location = new System.Drawing.Point(411, 177);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(53, 20);
            this.lblsexo.TabIndex = 45;
            this.lblsexo.Text = "Sexo :";
            // 
            // cbxsexo
            // 
            this.cbxsexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxsexo.FormattingEnabled = true;
            this.cbxsexo.Items.AddRange(new object[] {
            "M",
            "F",
            "O"});
            this.cbxsexo.Location = new System.Drawing.Point(415, 208);
            this.cbxsexo.Name = "cbxsexo";
            this.cbxsexo.Size = new System.Drawing.Size(121, 28);
            this.cbxsexo.TabIndex = 44;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(27, 40);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(59, 20);
            this.lblnome.TabIndex = 43;
            this.lblnome.Text = "Nome :";
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsenha.Location = new System.Drawing.Point(26, 184);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(68, 20);
            this.lblsenha.TabIndex = 42;
            this.lblsenha.Text = "Senha : ";
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(30, 73);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(346, 26);
            this.txtnome.TabIndex = 41;
            // 
            // txtsenha
            // 
            this.txtsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenha.Location = new System.Drawing.Point(30, 212);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(304, 26);
            this.txtsenha.TabIndex = 40;
            // 
            // lblestado_civ
            // 
            this.lblestado_civ.AutoSize = true;
            this.lblestado_civ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado_civ.Location = new System.Drawing.Point(27, 257);
            this.lblestado_civ.Name = "lblestado_civ";
            this.lblestado_civ.Size = new System.Drawing.Size(100, 20);
            this.lblestado_civ.TabIndex = 57;
            this.lblestado_civ.Text = "Estado civil : ";
            // 
            // cbxestado_civ
            // 
            this.cbxestado_civ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxestado_civ.FormattingEnabled = true;
            this.cbxestado_civ.Items.AddRange(new object[] {
            "Casado(A)",
            "Solteiro(A)",
            "Viuvo(A)"});
            this.cbxestado_civ.Location = new System.Drawing.Point(30, 290);
            this.cbxestado_civ.Name = "cbxestado_civ";
            this.cbxestado_civ.Size = new System.Drawing.Size(121, 28);
            this.cbxestado_civ.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "E-mail:";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(415, 146);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(346, 26);
            this.txtemail.TabIndex = 58;
            // 
            // ofdfoto
            // 
            this.ofdfoto.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "Usuario :";
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(30, 144);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(324, 26);
            this.txtusuario.TabIndex = 60;
            // 
            // btnentrar
            // 
            this.btnentrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnentrar.Image = ((System.Drawing.Image)(resources.GetObject("btnentrar.Image")));
            this.btnentrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnentrar.Location = new System.Drawing.Point(535, 369);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(109, 47);
            this.btnentrar.TabIndex = 79;
            this.btnentrar.Text = "Entrar";
            this.btnentrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnentrar.UseVisualStyleBackColor = true;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.Location = new System.Drawing.Point(828, 111);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(68, 20);
            this.lblestado.TabIndex = 85;
            this.lblestado.Text = "Estado :";
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcidade.Location = new System.Drawing.Point(829, 184);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(67, 20);
            this.lblcidade.TabIndex = 83;
            this.lblcidade.Text = "Cidade :";
            // 
            // lblendereco
            // 
            this.lblendereco.AutoSize = true;
            this.lblendereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblendereco.Location = new System.Drawing.Point(828, 40);
            this.lblendereco.Name = "lblendereco";
            this.lblendereco.Size = new System.Drawing.Size(86, 20);
            this.lblendereco.TabIndex = 82;
            this.lblendereco.Text = "Endereço :";
            // 
            // txtendereco
            // 
            this.txtendereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtendereco.Location = new System.Drawing.Point(829, 73);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(346, 26);
            this.txtendereco.TabIndex = 81;
            // 
            // txtcidade
            // 
            this.txtcidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcidade.Location = new System.Drawing.Point(829, 212);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(242, 26);
            this.txtcidade.TabIndex = 80;
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcep.Location = new System.Drawing.Point(829, 257);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(49, 20);
            this.lblcep.TabIndex = 87;
            this.lblcep.Text = "CEP :";
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf.Location = new System.Drawing.Point(414, 38);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(48, 20);
            this.lblcpf.TabIndex = 89;
            this.lblcpf.Text = "CPF :";
            // 
            // cbxestado
            // 
            this.cbxestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxestado.FormattingEnabled = true;
            this.cbxestado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbxestado.Location = new System.Drawing.Point(829, 144);
            this.cbxestado.Name = "cbxestado";
            this.cbxestado.Size = new System.Drawing.Size(121, 28);
            this.cbxestado.TabIndex = 91;
            // 
            // txtcep
            // 
            this.txtcep.Location = new System.Drawing.Point(833, 290);
            this.txtcep.Mask = "00.00-00";
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(99, 20);
            this.txtcep.TabIndex = 92;
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(418, 73);
            this.txtcpf.Mask = "000.000.000-00";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(126, 20);
            this.txtcpf.TabIndex = 93;
            // 
            // frmcadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 452);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.txtcep);
            this.Controls.Add(this.cbxestado);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.lblcep);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.lblcidade);
            this.Controls.Add(this.lblendereco);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblestado_civ);
            this.Controls.Add(this.cbxestado_civ);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.dtpdata);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.lblsexo);
            this.Controls.Add(this.cbxsexo);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtsenha);
            this.Name = "frmcadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmcadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.DateTimePicker dtpdata;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.ComboBox cbxsexo;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Label lblestado_civ;
        private System.Windows.Forms.ComboBox cbxestado_civ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.OpenFileDialog ofdfoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Label lblcidade;
        private System.Windows.Forms.Label lblendereco;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.Label lblcep;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.ComboBox cbxestado;
        private System.Windows.Forms.MaskedTextBox txtcep;
        private System.Windows.Forms.MaskedTextBox txtcpf;
    }
}