using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using dll_BS_LocadoraVeiculos;
using dll_DB_LocadoraVeiculos;
using dll_Uteis;
using System.Data.SqlClient;

namespace PIM_LocadoraVeiculos
{
    public partial class frmVeiculos : Form
    {
        VerificaCampos verificacampos = new VerificaCampos();
        Veiculos veic = new Veiculos();
        RecuperaConexao conexao = new RecuperaConexao();
        PreparaSQL preparasql = new PreparaSQL();
        Executa executa = new Executa();

        public int operacao = 1; //Incluir [1] Editar [2]
        public int ID = 0;
        
        public frmVeiculos()
        {
            InitializeComponent();
        }


        private void btnFoto_Click(object sender, EventArgs e)
        {
            if (dlgFoto.ShowDialog() == DialogResult.OK)
            {
                lblFoto.Text = dlgFoto.FileName;
                pictureFoto.Image = Image.FromFile(lblFoto.Text);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Saindo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string ret;

            ret = verificacampos.VerificaVeiculos(txtChassis.Text, txtFabricante.Text, txtPlaca.Text, txtMarca.Text, txtCor.Text, txtKM.Text.Replace(",", "."), mskDataFabr.Text, mskDataCompr.Text,
                mskDataUltimaRev.Text, lblFoto.Text, txtObs.Text);

            if (ret == "")
            {
                //Passa os valores para classe
                veic.chassis = txtChassis.Text;
                veic.fabricante = txtFabricante.Text;
                veic.placa = txtPlaca.Text;
                veic.marca = txtMarca.Text;
                veic.cor = txtCor.Text;
                veic.km = Convert.ToDouble(txtKM.Text);
                veic.datafabricacao  = Convert.ToDateTime(mskDataFabr.Text);
                veic.datacompra = Convert.ToDateTime(mskDataCompr.Text);
                veic.dataultimarevisao = Convert.ToDateTime(mskDataCompr.Text);

                if (operacao == 1)
                {
                    if (MessageBox.Show("Deseja cadastrar o veículo?", "Salvando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        executa.Executar(preparasql.PreparaVeiculo(txtChassis.Text, txtFabricante.Text, txtPlaca.Text, txtMarca.Text, txtCor.Text, txtKM.Text.Replace(",", "."), 
                        mskDataFabr.Text, mskDataCompr.Text,mskDataUltimaRev.Text, lblFoto.Text, txtObs.Text));

                        MessageBox.Show("Veículo cadastrado com sucesso!", "Incluindo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();

                    }


                }
                else if (operacao == 2)
                {
                    if (MessageBox.Show("Deseja Alterar o veículo?", "Salvando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        executa.Executar(preparasql.PreparaUPDATEVeiculo(ID, txtChassis.Text, txtFabricante.Text, txtPlaca.Text, txtMarca.Text, txtCor.Text, txtKM.Text.Replace(",", "."),
                         mskDataFabr.Text, mskDataCompr.Text, mskDataUltimaRev.Text, lblFoto.Text, txtObs.Text));

                        MessageBox.Show("Veículo alterado com sucesso!", "Salvando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }


            }
            else if (ret == "chassis")
            {
                lblInfo.Text = "Numeração do chassis inválida";
                txtChassis.BackColor = System.Drawing.Color.LightCyan;
                txtChassis.Focus();
            }
            else if (ret == "fabricante")
            {
                lblInfo.Text = "Por favor digite o fabricante!";
                txtFabricante.BackColor = System.Drawing.Color.LightCyan;
                txtFabricante.Focus();
            }
            else if (ret == "placa")
            {
                lblInfo.Text = "Placa inválida";
                txtPlaca.BackColor = System.Drawing.Color.LightCyan;
                txtPlaca.Focus();
            }
            else if (ret == "marca")
            {
                lblInfo.Text = "Por favor digite a marca!";
                txtMarca.BackColor = System.Drawing.Color.LightCyan;
                txtMarca.Focus();
            }
            else if (ret == "cor")
            {
                lblInfo.Text = "Por favor digite a cor!";
                txtCor.BackColor = System.Drawing.Color.LightCyan;
                txtCor.Focus();
            }
            else if (ret == "km")
            {
                lblInfo.Text = "Por favor digite a kilometragem!";
                txtKM.BackColor = System.Drawing.Color.LightCyan;
                txtKM.Focus();
            }
            else if (ret == "kmnum")
            {
                lblInfo.Text = "Este campo só aceita valores númericos!";
                txtKM.BackColor = System.Drawing.Color.LightCyan;
                txtKM.Focus();
            }

        }

        private void frmVeiculos_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            if (operacao == 2) { CarregarVeiculo(ID); }

        }

        private void CarregarVeiculo(int ID)
        {
            SqlConnection con = new SqlConnection(conexao.RecuperaCNN());

            try
            {

                SqlCommand cmd = new SqlCommand(preparasql.ConsultaVeiculo(ID), con);
                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        txtChassis.Text = reader["chasVEIC"].ToString();
                        txtFabricante.Text = reader["fabricanteVEIC"].ToString();
                        txtPlaca.Text = reader["placaVEIC"].ToString();
                        txtMarca.Text = reader["marcaVEIC"].ToString();
                        txtCor.Text = reader["corVEIC"].ToString();
                        txtKM.Text = reader["kmVEIC"].ToString();
                        mskDataFabr.Text = reader["datafabrVEIC"].ToString();
                        mskDataCompr.Text = reader["datacompraVEIC"].ToString();
                        mskDataUltimaRev.Text = reader["ultimarevisaoVEIC"].ToString();
                        lblFoto.Text = reader["imgVEIC"].ToString();
                        txtObs.Text = reader["descVEIC"].ToString();

                        if (lblFoto.Text != "Foto")
                        {
                            pictureFoto.Image = Image.FromFile(lblFoto.Text);
                        }
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

        private void LimparCampos()
        {
            
            txtChassis.Text = "";
            txtFabricante.Text = "";
            txtPlaca.Text = "";
            txtMarca.Text = "";
            txtCor.Text = "";
            txtKM.Text = "";
            txtObs.Text = "";
            pictureFoto.Image = null;
        }

        private void txtChassis_TextChanged(object sender, EventArgs e)
        {
            txtChassis.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void txtFabricante_TextChanged(object sender, EventArgs e)
        {
            txtFabricante.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void txtPlaca_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            txtPlaca.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            txtMarca.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void txtCor_TextChanged(object sender, EventArgs e)
        {
            txtCor.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void txtKM_TextChanged(object sender, EventArgs e)
        {
            txtKM.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }
    }
}
