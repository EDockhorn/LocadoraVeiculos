using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using dll_Uteis;
using dll_BS_LocadoraVeiculos;
using dll_DB_LocadoraVeiculos;


namespace PIM_LocadoraVeiculos
{
    public partial class frmCadClientes : Form
    {
        VerificaCampos verificacampos = new VerificaCampos();
        Clientes clientes = new Clientes();
        RecuperaConexao conexao = new RecuperaConexao();
        PreparaSQL preparasql = new PreparaSQL();
        Executa executa = new Executa();

        frmConsultaClientes consultacli = new frmConsultaClientes();

        public int operacao = 1; //Incluir [1] Editar [2]
        public int ID = 0;



        public frmCadClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebServiceCEP.WebServiceCEP cep = new WebServiceCEP.WebServiceCEP("05351-060");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ValidaDocumentos CPF = new ValidaDocumentos();
            CPF.ValideCPF("111.111.111-11");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //MessageBox.Show(dtDataNasc.Value.ToShortDateString());

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            WebServiceCEP.WebServiceCEP cep = new WebServiceCEP.WebServiceCEP("05351-060");
            MessageBox.Show(cep.Lagradouro);
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            WebServiceCEP.WebServiceCEP cep = new WebServiceCEP.WebServiceCEP(mskCEP.Text);
            txtLogradouro.Text = cep.Lagradouro;
            txtCidade.Text = cep.Cidade;
            txtBairro.Text = cep.Bairro;
            txtUF.Text = cep.UF;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Saindo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) this.Close();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            string ret;

            ret = verificacampos.VerificaClientes(txtNome.Text, mskRG.Text, mskCPF.Text, mskCNH.Text, mskDataNas.Text, mskCelular.Text, txtEmail.Text
                , mskCEP.Text, txtLogradouro.Text, txtCidade.Text, txtBairro.Text, txtUF.Text, txtnum.Text,mskTelComer.Text);
            if (ret == "")
            {
                //Passa os valores para classe
                clientes.nome = txtNome.Text;
                clientes.rg = mskRG.Text;
                clientes.cpf = mskCPF.Text;
                clientes.CNH = mskCNH.Text;
                clientes.datanasc = Convert.ToDateTime(mskDataNas.Text);
                clientes.telefone = mskTelComer.Text;
                clientes.celular = mskCelular.Text;
                clientes.email = txtEmail.Text;
                clientes.cep = mskCEP.Text;
                clientes.logradouro = txtLogradouro.Text;
                clientes.cidade = txtCidade.Text;
                clientes.bairro = txtBairro.Text;
                clientes.estado = txtUF.Text;
                clientes.numcasa = txtnum.Text;



                if (operacao == 1)
                {
                    if (MessageBox.Show("Deseja incluir o cliente?", "Salvando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        executa.Executar(preparasql.PreparaCliente(clientes.nome, clientes.rg, clientes.cpf, clientes.CNH, Convert.ToString(clientes.datanasc), clientes.celular, clientes.email, clientes.cep
                            , clientes.logradouro, clientes.cidade, clientes.bairro, clientes.estado, clientes.numcasa, clientes.telefone));
                        MessageBox.Show("Cliente cadastrado com sucesso!", "Incluindo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (operacao == 2)
                {
                    if (MessageBox.Show("Deseja alterar o cliente?", "Salvando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        executa.Executar(preparasql.PreparaUPDATECliente(ID, clientes.nome, clientes.rg, clientes.cpf, clientes.CNH, Convert.ToString(clientes.datanasc), clientes.celular, clientes.email, clientes.cep
                            , clientes.logradouro, clientes.cidade, clientes.bairro, clientes.estado, clientes.numcasa, clientes.telefone));
                        MessageBox.Show("Cliente alterado com sucesso!", "Editando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                //LIMPA
                txtNome.Text = "";
                mskRG.Text = "";
                mskCPF.Text = "";
                mskCNH.Text = "";
                mskDataNas.Text = "";
                mskTelComer.Text = "";
                mskCelular.Text = "";
                txtEmail.Text = "";
                mskCEP.Text = "";
                txtLogradouro.Text = "";
                txtCidade.Text = "";
                txtBairro.Text = "";
                txtUF.Text = "";
                txtnum.Text = "";
                txtNome.Focus();


            }
            else if (ret == "nome")
            {
                lblInfo.Text = "Por favor digite o nome do cliente!";
                txtNome.BackColor = System.Drawing.Color.LightCyan;
                txtNome.Focus();
            }
            else if (ret == "nomecurto")
            {
                lblInfo.Text = "Verifique se o nome do cliente está correto!";
                txtNome.BackColor = System.Drawing.Color.LightCyan;
                txtNome.Focus();
            }
            else if (ret == "rg")
            {
                lblInfo.Text = "RG inválido!";
                mskRG.Focus();
                mskRG.BackColor = System.Drawing.Color.LightCyan;
            }
            else if (ret == "cpf")
            {
                lblInfo.Text = "CPF inválido!";
                mskCPF.Focus();
                mskCPF.BackColor = System.Drawing.Color.LightCyan;
            }
            else if (ret == "cnh")
            {
                lblInfo.Text = "Número de CNH inválido!";
                mskCNH.Focus();
                mskCNH.BackColor = System.Drawing.Color.LightCyan;
            }
            else if (ret == "data")
            {
                lblInfo.Text = "Data de nascimento inválida";
                mskDataNas.Focus();
                mskDataNas.BackColor = System.Drawing.Color.LightCyan;
            }
            else if (ret == "menoridade")
            {
                lblInfo.Text = "O cliente não pode ser menor de 18 anos!";
                mskDataNas.Focus();
                mskDataNas.BackColor = System.Drawing.Color.LightCyan;
            }
            else if (ret == "email")
            {
                lblInfo.Text = "E-mail inválido!";
                txtEmail.Focus();
                txtEmail.BackColor = System.Drawing.Color.LightCyan;
            }
            else if (ret == "emailcom@")
            {
                lblInfo.Text = "E-mail inválido!";
                txtEmail.BackColor = System.Drawing.Color.LightCyan;
                txtEmail.Focus();
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
        }

        private void frmCadClientes_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            if (operacao == 2) { CarregarCliente(ID); }

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

        private void mskCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mskCPF.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void mskCNH_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mskCNH.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void mskDataNas_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mskDataNas.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void mskTelComer_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mskTelComer.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void mskCelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mskCelular.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.BackColor = System.Drawing.Color.White;
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

        private void txtUF_TextChanged(object sender, EventArgs e)
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
        public void CarregarCliente(int ID)
        {

            SqlConnection con = new SqlConnection(conexao.RecuperaCNN());

            try
            {

                SqlCommand cmd = new SqlCommand(preparasql.ConsultaCliente(ID), con);
                con.Open();



                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        txtNome.Text = reader["nomeCLI"].ToString();
                        mskRG.Text = reader["rgCLI"].ToString();
                        mskCPF.Text = reader["cpfCLI"].ToString();
                        mskCNH.Text = reader["CNHCLI"].ToString();
                        mskDataNas.Text = reader["datanascCLI"].ToString();
                        mskTelComer.Text = reader["telefonefixoCLI"].ToString();
                        mskCelular.Text = reader["telefonecelularCLI"].ToString();
                        txtEmail.Text = reader["emailCLI"].ToString();
                        mskCEP.Text = reader["cepCLI"].ToString();
                        txtLogradouro.Text = reader["enderCLI"].ToString();
                        txtCidade.Text = reader["cidadeCLI"].ToString();
                        txtUF.Text = reader["estadoCLI"].ToString();
                        txtBairro.Text = reader["bairroCLI"].ToString();
                        txtnum.Text = reader["numcasaCLI"].ToString();

                    }
                }
                /*nomeCLI,rgCLI,cpfCLI,CNHCLI,
                datanascCLI,telefonefixoCLI,telefonecelularCLI,emailCLI,
                cepCLI,enderCLI,cidadeCLI,estadoCLI,
                bairroCLI,numcasaCLI
                */


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

        private void mskDataNas_Leave(object sender, EventArgs e)
        {
            //MessageBox.Show(mskDataNas.Text);
            //MessageBox.Show(Convert.ToString(DateTime.Now.ToString("yyyy")));


        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }
    }
}

