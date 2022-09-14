
namespace diamond_story_grupo3
{
    partial class inicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicial));
            this.lblalunos = new System.Windows.Forms.Label();
            this.imgdiamond = new System.Windows.Forms.PictureBox();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btnentrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgdiamond)).BeginInit();
            this.SuspendLayout();
            // 
            // lblalunos
            // 
            this.lblalunos.AutoSize = true;
            this.lblalunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalunos.Location = new System.Drawing.Point(265, 65);
            this.lblalunos.Name = "lblalunos";
            this.lblalunos.Size = new System.Drawing.Size(114, 20);
            this.lblalunos.TabIndex = 42;
            this.lblalunos.Text = "Diamond Story";
            // 
            // imgdiamond
            // 
            this.imgdiamond.Image = ((System.Drawing.Image)(resources.GetObject("imgdiamond.Image")));
            this.imgdiamond.Location = new System.Drawing.Point(186, 124);
            this.imgdiamond.Name = "imgdiamond";
            this.imgdiamond.Size = new System.Drawing.Size(296, 225);
            this.imgdiamond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgdiamond.TabIndex = 41;
            this.imgdiamond.TabStop = false;
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(220, 381);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(94, 30);
            this.btncadastrar.TabIndex = 43;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnentrar
            // 
            this.btnentrar.Location = new System.Drawing.Point(357, 381);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(94, 30);
            this.btnentrar.TabIndex = 44;
            this.btnentrar.Text = "Entrar";
            this.btnentrar.UseVisualStyleBackColor = true;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 480);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.lblalunos);
            this.Controls.Add(this.imgdiamond);
            this.Name = "inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.inicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgdiamond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblalunos;
        private System.Windows.Forms.PictureBox imgdiamond;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btnentrar;
    }
}

