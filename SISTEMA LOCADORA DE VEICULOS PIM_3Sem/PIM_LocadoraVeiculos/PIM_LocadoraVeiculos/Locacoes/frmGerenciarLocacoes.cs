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
using dll_BS_LocadoraVeiculos;


namespace PIM_LocadoraVeiculos
{
    public partial class frmGerenciarLocacoes : Form
    {
        public int ID;
        public frmGerenciarLocacoes()
        {
            InitializeComponent();
        }

        private void GerenciarLocacoes_Load(object sender, EventArgs e)
        {
            PreencheDataGridView PreencheGrid = new PreencheDataGridView();

            dgvReservas.DataSource = PreencheGrid.PrencherDados("SELECT * FROM ConsultaReservados", "ConsultaReservados").Tables[0];
            dgvReservas.AutoResizeColumns();
            dgvReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            lblInfo.Text = "";
        }

        private void dgvReservas_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dgvReservas.Rows[e.RowIndex].Cells[0].Value.ToString());
                lblInfo.Text = "";
            }
            catch
            {
                ID = 0;
                lblInfo.Text = "Clique em um registro para iniciar o processo de Devolução!";
            }
        }

        private void dgvReservas_RowHeaderMouseClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dgvReservas.Rows[e.RowIndex].Cells[0].Value.ToString());
                lblInfo.Text = "";
            }
            catch
            {
                ID = 0;
                lblInfo.Text = "Clique em um registro para iniciar o processo de Devolução!";
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                frmAlocacao frmGerenciarDev = new frmAlocacao();
                frmGerenciarDev.Text = "Consultando Veículo Reservado";
                frmGerenciarDev.IDReserva = ID;
                frmGerenciarDev.operacao = 2;
                frmGerenciarDev.ShowDialog();
                this.dgvReservas.DataSource = null;

                GerenciarLocacoes_Load(this, e);

            }
           
            else
                lblInfo.Text = "Clique em um registro para iniciar o processo de Devolução!";
        }

        private void dgvReservas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar_Click(this, e);
        }

        private void dgvReservas_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEditar_Click(this, e);
        }
    }
}
