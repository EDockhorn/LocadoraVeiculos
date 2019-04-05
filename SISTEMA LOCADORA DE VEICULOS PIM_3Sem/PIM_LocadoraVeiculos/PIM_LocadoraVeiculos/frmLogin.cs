using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dll_DB_LocadoraVeiculos;
using System.Data.SqlClient;
using dll_Uteis;
using dll_BS_LocadoraVeiculos;


namespace PIM_LocadoraVeiculos
{
    public partial class frmLogin : Form
    {
        RecuperaConexao conexao = new RecuperaConexao();
        PreparaSQL usuario = new PreparaSQL();
           
        public frmLogin()
        {
            InitializeComponent();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "";
         
        }

        private void cmbLogin_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                cmbLogin.Items.Clear();
                SqlConnection con = new SqlConnection(conexao.RecuperaCNN());
                SqlCommand cmd = new SqlCommand(usuario.ConsultaUsuario(), con);

                con.Open();
                using (SqlDataReader leitor = cmd.ExecuteReader())
                {
                    while (leitor.Read())
                    {

                        cmbLogin.Items.Add(leitor["loginUSU"].ToString());

                    }
                    leitor.Close();
                }

                con.Close();
            }
            catch 
            {
                MessageBox.Show("Erro ao conectar à base de dados", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cmbLogin.SelectedIndex;

            cmbLogin.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";

        }


 

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.BackColor = System.Drawing.Color.White;
            if (lblInfo.Text != "Usuário ou senha inválidos!") lblInfo.Text = "";
            
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            VerificaCampos verificacampos = new VerificaCampos();
            CarregarForm Usuarios = new CarregarForm();

            string ret;

            ret = (verificacampos.VerificaUsuario(cmbLogin.Text, txtSenha.Text));
            if (ret == "")
            {

                if (Usuarios.Usuario(cmbLogin.Text, txtSenha.Text) == true)
                {
                    string perfil = Usuarios.CarregarPerfil(cmbLogin.Text, txtSenha.Text);

                    this.Hide();
                    frmPrincipal sistema = new frmPrincipal();


                    //Transmite para a classe de usuários o usuário LOGADO;
                    Usuarios usuarios = new Usuarios();
                    usuarios.setLogin(cmbLogin.Text);
                    usuarios.setSenha(txtSenha.Text);
                    usuarios.setPerfil(perfil);

                    //Passa o objeto para o formulário principal:
                    sistema.objUsuario(usuarios);


                    sistema.ShowDialog();


                }
                else
                lblInfo.Text = "Usuário ou senha inválidos!";
                txtSenha.Text = "";
                txtSenha.Focus();
                }
            else if (ret == "Usuario")
            {
                lblInfo.Text = "Por favor selecione um usuário!";
                cmbLogin.BackColor = System.Drawing.Color.LightCyan;
                cmbLogin.Focus();
            }
            else if (ret == "Senha")
            {
                lblInfo.Text = "Por favor digite sua senha!";
                txtSenha.BackColor = System.Drawing.Color.LightCyan;
            }
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }

        private void uSUARIOSBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }



       

           
    }



}
