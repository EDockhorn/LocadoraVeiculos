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
using System.Data.SqlClient;

namespace PIM_LocadoraVeiculos.Funcionários
{
    public partial class frmFuncionarios1 : Form
    {
        VerificaCampos verificacampos = new VerificaCampos();
        Funcionarios funcionarios = new Funcionarios();
        RecuperaConexao conexao = new RecuperaConexao();
        PreparaSQL preparasql = new PreparaSQL();
        Executa executa = new Executa();

        public int operacao = 1; //Incluir [1] Editar [2]
        public int ID = 0;


        public frmFuncionarios1()
        {
            InitializeComponent();
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            if (operacao == 2) { CarregarFunc(ID); }
            
        }



        private void mskCEP_Leave(object sender, EventArgs e)
        {
            WebServiceCEP.WebServiceCEP cep = new WebServiceCEP.WebServiceCEP(mskCEP.Text);
            txtLogradouro.Text = cep.Lagradouro;
            txtCidade.Text = cep.Cidade;
            txtBairro.Text = cep.Bairro;
            txtUF.Text = cep.UF;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Saindo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string ret;

            ret = verificacampos.VerificaFuncionarios(txtNome.Text, mskRG.Text, mskTelefone.Text, mskCPF.Text, chkAtivo.Checked,
                mskDataNasc.Text, mskDataAd.Text, mskDataDemi.Text, mskCEP.Text, txtLogradouro.Text, txtCidade.Text,
                txtBairro.Text, txtUF.Text, txtnum.Text,cmbLogin.Text);

            if (ret == "")
            {
                //Passa os valores para classe
                funcionarios.nome = txtNome.Text;
                funcionarios.rg = mskRG.Text;
                funcionarios.telefone = mskTelefone.Text;
                funcionarios.cpf = mskCPF.Text;
                funcionarios.datanasc = Convert.ToDateTime(mskDataNasc.Text);
                funcionarios.datademissao = Convert.ToDateTime(mskDataAd.Text);
                if (chkAtivo.Checked == false) funcionarios.datademissao = Convert.ToDateTime(mskDataDemi.Text);
                funcionarios.endereco = txtLogradouro.Text;
                funcionarios.bairro = txtBairro.Text;
                funcionarios.estado = txtUF.Text;
                funcionarios.cidade = txtCidade.Text;

                if (operacao == 1)
                {
                    if (MessageBox.Show("Deseja salvar o funcionário?", "Salvando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        executa.Executar(preparasql.PreparaFunc(txtNome.Text, mskRG.Text, mskTelefone.Text, mskCPF.Text, chkAtivo.Checked,
                        mskDataNasc.Text, mskDataAd.Text, mskDataDemi.Text, mskCEP.Text, txtLogradouro.Text, txtCidade.Text,
                        txtBairro.Text, txtUF.Text, txtnum.Text,cmbLogin.Text));
                        MessageBox.Show("Funcionário cadastrado com sucesso!", "Incluindo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimparFuncionarios();
                    }
                }
                else if (operacao == 2)
                {
                    if (MessageBox.Show("Deseja alterar o funcionário?", "Salvando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        executa.Executar(preparasql.PreparaUPDATEFunc(ID, txtNome.Text, mskRG.Text, mskTelefone.Text, mskCPF.Text, chkAtivo.Checked,
                    mskDataNasc.Text, mskDataAd.Text, mskDataDemi.Text, mskCEP.Text, txtLogradouro.Text, txtCidade.Text,
                    txtBairro.Text, txtUF.Text, txtnum.Text, cmbLogin.Text));
                        MessageBox.Show("Funcionário alterado com sucesso!", "Editando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                }
               


            }
            else if (ret == "nome")
            {
                lblInfo.Text = "Por favor digite o nome do funcionário!";
                txtNome.BackColor = System.Drawing.Color.LightCyan;
                txtNome.Focus();
            }
            else if (ret == "nomecurto")
            {
                lblInfo.Text = "Verifique se o nome do funcionário está correto!";
                txtNome.BackColor = System.Drawing.Color.LightCyan;
                txtNome.Focus();
            }
            else if (ret == "rg")
            {
                lblInfo.Text = "RG inválido!";
                mskRG.Focus();
                mskRG.BackColor = System.Drawing.Color.LightCyan;
            }
            else if (ret == "telefone")
            {
                lblInfo.Text = "Telefone inválido!";
                mskTelefone.Focus();
                mskTelefone.BackColor = System.Drawing.Color.LightCyan;
            }
            else if (ret == "cpf")
            {
                lblInfo.Text = "CPF inválido!";
                mskCPF.Focus();
                mskCPF.BackColor = System.Drawing.Color.LightCyan;
            }

            else if (ret == "datanas")
            {
                lblInfo.Text = "Data de nascimento inválida";
                mskDataNasc.Focus();
                mskDataNasc.BackColor = System.Drawing.Color.LightCyan;
            }
            else if (ret == "menoridade")
            {
                lblInfo.Text = "O funcionário não pode ser menor de 18 anos! ";
                mskDataNasc.Focus();
                mskDataNasc.BackColor = System.Drawing.Color.LightCyan;
            }
            else if (ret == "dataAd")
            {
                lblInfo.Text = "Data de admissão inválida";
                mskDataAd.Focus();
                mskDataAd.BackColor = System.Drawing.Color.LightCyan;
            }
            else if (ret == "dataDemi")
            {
                lblInfo.Text = "Data de demissão inválida";
                mskDataDemi.Focus();
                mskDataDemi.BackColor = System.Drawing.Color.LightCyan;
            }
           
            else if (ret == "cep")
            {
                lblInfo.Text = "CEP inválido!";
                mskCEP.Focus();
                mskCEP.BackColor = System.Drawing.Color.LightCyan;
            }
            else if (ret == "logradouro")
            {
                lblInfo.Text = "Por favor preencha o logradouro!";
                txtLogradouro.Focus();
                txtLogradouro.BackColor = System.Drawing.Color.LightCyan;
            }
            else if (ret == "cidade")
            {
                lblInfo.Text = "Por favor preencha a cidade!";
                txtCidade.Focus();
                txtCidade.BackColor = System.Drawing.Color.LightCyan;
            }
            else if (ret == "bairro")
            {
                lblInfo.Text = "Por favor preencha o bairro!";
                txtBairro.Focus();
                txtBairro.BackColor = System.Drawing.Color.LightCyan;
            }
            else if (ret == "uf")
            {
                lblInfo.Text = "Por favor preencha o estado!";
                txtUF.Focus();
                txtUF.BackColor = System.Drawing.Color.LightCyan;
            }
            else if (ret == "numerocasa")
            {
                lblInfo.Text = "Por favor preencha o número de sua residência!";
                txtnum.Focus();
                txtnum.BackColor = System.Drawing.Color.LightCyan;
            }

            else if (ret == "usuario")
            {
                lblInfo.Text = "Por favor selecione um perfil de usuário!";
                cmbLogin.Focus();
                cmbLogin.BackColor = System.Drawing.Color.LightCyan;
            }
        }

        private void LimparFuncionarios()
        {
            //LIMPA
            txtNome.Text = "";
            mskRG.Text = "";
            mskCPF.Text = "";
            mskDataNasc.Text = "";
            mskDataDemi.Text = "";
            mskDataAd.Text = "";
            mskTelefone.Text = "";
            mskCEP.Text = "";
            txtLogradouro.Text = "";
            txtCidade.Text = "";
            txtBairro.Text = "";
            txtUF.Text = "";
            txtnum.Text = "";
            txtNome.Focus();
            cmbLogin.Text = "";
        }

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAtivo.Checked) mskDataDemi.Enabled = false; else mskDataDemi.Enabled = true;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void mskRG_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mskRG.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void mskTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mskTelefone.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void mskCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mskCPF.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void mskDataNasc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mskDataNasc.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void mskDataAd_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mskDataAd.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void mskDataDemi_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mskDataDemi.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void mskCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mskCEP.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void txtLogradouro_TextChanged(object sender, EventArgs e)
        {
            txtLogradouro.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            txtCidade.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void txtUF_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUF.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {
            txtBairro.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void txtnum_TextChanged(object sender, EventArgs e)
        {
            txtnum.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }
        public void CarregarFunc(int ID)
        {

            SqlConnection con = new SqlConnection(conexao.RecuperaCNN());

            try
            {

                SqlCommand cmd = new SqlCommand(preparasql.ConsultaFunc(ID), con);
                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    
                    while (reader.Read())
                    {
                        txtNome.Text = reader["nomeFUNC"].ToString();
                        mskRG.Text = reader["rgFUNC"].ToString();
                        mskCPF.Text = reader["cpfFUNC"].ToString();
                        mskDataAd.Text = reader["dataadmiss"].ToString();
                        mskDataNasc.Text = reader["datanascFUNC"].ToString();
                        mskDataDemi.Text = reader["datademiss"].ToString();
                        mskTelefone.Text = reader["telefoneFUNC"].ToString();
                        mskCEP.Text = reader["cepFUNC"].ToString();
                        txtLogradouro.Text = reader["enderFUNC"].ToString();
                        txtCidade.Text = reader["cidadeFUNC"].ToString();
                        txtUF.Text = reader["estadoFUNC"].ToString();
                        txtBairro.Text = reader["bairroFUNC"].ToString();
                        txtnum.Text = reader["numcasaFUNC"].ToString();
                        cmbLogin.Text = reader["perfilusuFUNC"].ToString();
                        
                    }
                }


            }
            catch (Exception ex)
            {
                string err = ex.Message;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
        public void CarregarPerfil()
        {
            try
            {
                cmbLogin.Items.Clear();
                RecuperaConexao conexao = new RecuperaConexao();
                PreparaSQL usuario = new PreparaSQL();

                SqlConnection con = new SqlConnection(conexao.RecuperaCNN());
                SqlCommand cmd = new SqlCommand(usuario.ConsultaUsuFUNC(), con);

                con.Open();
                using (SqlDataReader leitor = cmd.ExecuteReader())
                {
                    while (leitor.Read())
                    {

                        cmbLogin.Items.Add(leitor["PerfilUsu"].ToString());
                        


                    }
                    leitor.Close();
                }

                con.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao carregar os usuários", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLogin.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void btnUsu_Click(object sender, EventArgs e)
        {
            frmUsuarios usuarios = new frmUsuarios();
            usuarios.ShowDialog();
        }

        private void cmbLogin_Click(object sender, EventArgs e)
        {
            CarregarPerfil();
        }

       
    }
}
