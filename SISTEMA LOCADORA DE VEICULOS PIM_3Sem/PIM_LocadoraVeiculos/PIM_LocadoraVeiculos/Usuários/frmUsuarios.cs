using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dll_Uteis;
using dll_BS_LocadoraVeiculos;
using dll_DB_LocadoraVeiculos;

namespace PIM_LocadoraVeiculos
{
    public partial class frmUsuarios : Form
    {
        Usuarios usuarios = new Usuarios();
        VerificaCampos verificacampos = new VerificaCampos();
        PreparaSQL preparasql = new PreparaSQL();
        Executa executa = new Executa();

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string ret = string.Empty;

            ret = verificacampos.VerificaUsuario(txtLogin.Text, txtSenha.Text, txtPerfil.Text);

            if (ret == "")
            {
                usuarios.setLogin(txtLogin.Text);
                usuarios.setSenha(txtSenha.Text);
                usuarios.setPerfil(txtPerfil.Text);

                if (MessageBox.Show("Deseja salvar o usuário?", "Salvando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    executa.Executar(preparasql.PreparauUsuario(usuarios));
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Incluindo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparUsuarios();
                }

            }
            else if (ret == "login")
            {
                MessageBox.Show("Campo " + ret + " inválido", "Incluindo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLogin.BackColor = System.Drawing.Color.LightCyan;
                txtLogin.Focus();
            }
            else if (ret == "senha")
            {
                MessageBox.Show("Campo " + ret + " inválido", "Incluindo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenha.BackColor = System.Drawing.Color.LightCyan;
                txtSenha.Focus();
            }
            else if (ret == "função")
            {
                MessageBox.Show("Campo " + ret + " inválido", "Incluindo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPerfil.BackColor = System.Drawing.Color.LightCyan;
                txtPerfil.Focus();
            }
        }
        private void LimparUsuarios()
        {
            txtLogin.Text = "";
            txtSenha.Text = "";
            txtPerfil.Text = "";
            txtLogin.Text = "";
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            txtLogin.BackColor = System.Drawing.Color.White;
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.BackColor = System.Drawing.Color.White;
        }

        private void txtPerfil_TextChanged(object sender, EventArgs e)
        {
            txtPerfil.BackColor = System.Drawing.Color.White;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
