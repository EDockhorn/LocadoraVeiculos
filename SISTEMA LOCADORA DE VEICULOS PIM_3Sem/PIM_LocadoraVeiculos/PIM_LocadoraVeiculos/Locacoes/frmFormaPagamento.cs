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
    public partial class frmFormaPagamento : Form
    {
        PreparaSQL preparasql = new PreparaSQL();
        Executa executa = new Executa();

        string desCPGTO = string.Empty;
        int CodReserva = 0;

        public frmFormaPagamento()
        {
            InitializeComponent();
        }

        private void frmFormaPagamento_Load(object sender, EventArgs e)
        {
            txtParcelas.Value = 1;
            txtValorParcelado.Text = txtValorTotal.Text;
        }
        public void objPagamento(Pagamentos pagamento)
        {
            txtValorTotal.Text = Convert.ToString(pagamento.valortotal);
            CodReserva = pagamento.codigoreserva;
        }
        public string RetornarPGTO()
        {
            string pgto = string.Empty;

            pgto = desCPGTO;

            return pgto; 
        }

        private void rdbDebito_CheckedChanged(object sender, EventArgs e)
        {
            desCPGTO = rdbDebito.Text;
            txtParcelas.Enabled = false;
            txtValorParcelado.Enabled = false;
        }

        private void rdbCredito_CheckedChanged(object sender, EventArgs e)
        {
            desCPGTO = rdbCredito.Text;
            txtParcelas.Enabled = true;
            txtValorParcelado.Enabled = true;
        }

        private void rdbDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            desCPGTO = rdbDinheiro.Text;
            txtParcelas.Enabled = false;
            txtValorParcelado.Enabled = false;
        }

        private void txtParcelas_ValueChanged(object sender, EventArgs e)
        {
            txtValorParcelado.Text = Convert.ToString((Convert.ToDouble(txtValorTotal.Text) / Convert.ToDouble(txtParcelas.Value)));
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja salvar esta condição de pagamento?", "Salvando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                executa.Executar(preparasql.Preparapgto(desCPGTO,txtValorTotal.Text,Convert.ToInt16(txtParcelas.Value),CodReserva));
                RetornarPGTO();

                MessageBox.Show("Pagamento Salvo!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.Close();
            }
        }
    }
}
