using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dll_BS_LocadoraVeiculos;
using dll_DB_LocadoraVeiculos;
using dll_Uteis;

namespace PIM_LocadoraVeiculos
{
    public partial class frmChecklistDevolucao : Form
    {
        Pagamentos pagamentos = new Pagamentos();
        PreparaSQL preparasql = new PreparaSQL();
        Executa executa = new Executa();

        double valorparcial = 0.00;
        double valorreal = 0.00;
        double valordiaria = 0.00;
        DateTime dataReserva;

        public bool salvo = false; 

        int intCodReserva = 0;

        bool multasalva = false;
        
        public frmChecklistDevolucao()
        {
            InitializeComponent();
        }

        private void frmChecklistDevolucao_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "";
        }
        public void objReservas(Reservas reservas)
        {
            txtPlaca.Text = reservas.placa;
            txtValorDiaria.Text = Convert.ToString(reservas.valordiaria);
            txtProtoloco.Text = reservas.protoloco;
            mskDataDevolu.Text = Convert.ToString(reservas.datadevolucao);

            txtValorTotal.Text = Convert.ToString(reservas.valortotal);

            valordiaria = reservas.valordiaria;
            valorreal = reservas.valortotal;
            dataReserva = reservas.datareserva;

            intCodReserva = reservas.codigoreserva;
            //OBS: Precisa obter os códigos de veículo e cliente



        }

        private void btnFormaPGTO_Click(object sender, EventArgs e)
        {
            frmFormaPagamento frmFormaPagamento = new frmFormaPagamento();
            pagamentos.valortotal = Convert.ToDouble(txtValorTotal.Text);

            
            pagamentos.codigoreserva = intCodReserva;
            frmFormaPagamento.objPagamento(pagamentos);


            frmFormaPagamento.ShowDialog();

            txtPGTO.Text = frmFormaPagamento.RetornarPGTO();
           
        }

        private void CalcularTotal()
        {
            TimeSpan difference = dataReserva - Convert.ToDateTime(mskDatarealDev.Text);
            string dias = Convert.ToString(difference.Days).Replace("-", "");
            valorparcial = Convert.ToInt16(dias) * Convert.ToDouble(valordiaria);
            if (txtInfracoes.Text == "") txtInfracoes.Text = "0.00";

            Convert.ToDouble(valorparcial);
            double valorinfracoes = Convert.ToDouble(txtInfracoes.Text);
            
            txtValorTotal.Text = "0.00";
            double valorapagar = 0.00;

            valorapagar = valorparcial + valorinfracoes;

            txtValorTotal.Text = Convert.ToString(valorapagar);


            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (VerificarPendencias(2) == true)
            {
                CalcularTotal();
                MessageBox.Show("Calculado");
            }
            
        }

        public Reservas retornaObjReserva(){

            Reservas reservafinalizada = new Reservas();
            reservafinalizada.codigoreserva = intCodReserva;
            reservafinalizada.situacaoreserva = "D";
           

            return reservafinalizada;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (VerificarPendencias() == true)
            {
                if (MessageBox.Show("Deseja marcar o veículo como devolvido?", "Devolução", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    executa.Executar(preparasql.PreparaDevolucao(intCodReserva));
                    
                    MessageBox.Show("Devolução realizada com sucesso!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    retornaObjReserva();

                    salvo = true;


                    this.Close();
                }
            }
        }
        private Boolean VerificarPendencias(int verificar =1)
        {
            bool retorno = true;
            if (chk1.Checked == false || chk2.Checked == false || chk3.Checked == false || chk4.Checked == false && txtInfracoes.Text == "")
            {
                lblInfo.Text = "Por favor preencha o campo de \n situação do veículo!";
                txtSituacao.BackColor = System.Drawing.Color.LightCyan;
                txtSituacao.Focus();
                retorno = false;
            }
            else if (txtInfracoes.Text != "0.00" && txtInfracoes.Text != "" &&  txtMotivo.Text == "") 
            {
                txtMotivo.BackColor = System.Drawing.Color.LightCyan;
                txtMotivo.Focus();
                lblInfo.Text = "Por favor preencha o campo de \n Motivo das infrações!";
                retorno = false;
            }
            else if (txtPGTO.Text == "" && verificar == 1)
            {
                txtPGTO.BackColor = System.Drawing.Color.LightCyan;
                btnFormaPGTO.Focus();
                lblInfo.Text = "Por favor selecione uma\n Condição de Pagamento!";
                retorno = false;
            }
            else if (multasalva == false && txtInfracoes.Text != "0.00" && verificar==1)
            {
                lblInfo.Text = "Você deve salvar a multa\n antes de devolver o veículo!";
                retorno = false;
            }

            return retorno;
        }

        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            txtSituacao.BackColor = System.Drawing.Color.White;
        }

        private void chk2_CheckedChanged(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            txtSituacao.BackColor = System.Drawing.Color.White;
        }

        private void chk3_CheckedChanged(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            txtSituacao.BackColor = System.Drawing.Color.White;
        }

        private void chk4_CheckedChanged(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            txtSituacao.BackColor = System.Drawing.Color.White;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            txtSituacao.BackColor = System.Drawing.Color.White;
        }

        private void txtSituacao_TextChanged(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            txtSituacao.BackColor = System.Drawing.Color.White;
        }

        private void txtPGTO_TextChanged(object sender, EventArgs e)
        {
            txtInfracoes.Enabled = false;
            mskDatarealDev.Enabled = false;
        }

        private void btnSalvarMult_Click(object sender, EventArgs e)
        {
            multasalva = true;
            lblInfo.Text = "";
        }
    }
}
