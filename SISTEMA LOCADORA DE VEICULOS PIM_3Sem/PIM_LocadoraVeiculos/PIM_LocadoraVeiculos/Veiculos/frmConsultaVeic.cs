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
    public partial class frmConsultaVeic : Form
    {
        public int ID;
        public int OPReserva = 1;
        public int verFiltroDisp = 0;

        

        public frmConsultaVeic()
        {
            InitializeComponent();
        }

        private void frmConsultaVeic_Load(object sender, EventArgs e)
        {
            if (verFiltroDisp == 0) chkDisponivel.Visible = false ;
            PreencheDataGridView PreencheGrid = new PreencheDataGridView();

            if (chkDisponivel.Checked)
            {
                dgvVeic.DataSource = PreencheGrid.PrencherDados("SELECT * FROM ConsultaVeicDispon", "ConsultaVeicDispon").Tables[0];
            }
            else
            {
                dgvVeic.DataSource = PreencheGrid.PrencherDados("SELECT * FROM ConsultaVEIC", "ConsultaVEIC").Tables[0];
            }
            dgvVeic.AutoResizeColumns();
            dgvVeic.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            lblInfo.Text = "";


        }
     

        public void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (ID != 0 && OPReserva == 1)

            {
                frmVeiculos formveiculos = new frmVeiculos();
                formveiculos.Text = "Editando Veículos";
                formveiculos.ID = ID;
                formveiculos.operacao = 2;
                formveiculos.ShowDialog();
                this.dgvVeic.DataSource = null;

                frmConsultaVeic_Load(this, e);

            }
            else if (ID != 0 && OPReserva == 2)
            {
                RetornaID();
                this.Close();
            }
            else
                lblInfo.Text = "Clique em um registro para editar!";
            
        }

        public int RetornaID()
        {
            return ID;
        }
        
        private void dgvVeic_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dgvVeic.Rows[e.RowIndex].Cells[0].Value.ToString());
                lblInfo.Text = "";
            }
            catch
            {
                ID = 0;
                lblInfo.Text = "Clique em um registro para editar!";
            }
        }

        private void dgvVeic_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dgvVeic.Rows[e.RowIndex].Cells[0].Value.ToString());
            lblInfo.Text = "";
        }

        private void dgvVeic_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar_Click_1(this, e);
        }

        private void dgvVeic_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEditar_Click_1(this, e);
        }

        public void txtBuscar_KeyUp_1(object sender, KeyEventArgs e)
        {
            PreencheDataGridView PreencheGrid = new PreencheDataGridView();

            if (chkDisponivel.Checked)
            {
                if (rdbNome.Checked) dgvVeic.DataSource = PreencheGrid.PrencherDados("SELECT * FROM ConsultaVeicDispon WHERE MARCA LIKE '%" + txtBuscar.Text + "%'", "ConsultaVEIC").Tables[0];
                else dgvVeic.DataSource = PreencheGrid.PrencherDados("SELECT * FROM ConsultaVeicDispon WHERE FABRICANTE LIKE '%" + txtBuscar.Text + "%'", "FABRICANTE").Tables[0];
            }
            else
            {
                if (rdbNome.Checked) dgvVeic.DataSource = PreencheGrid.PrencherDados("SELECT * FROM ConsultaVeicDispon WHERE MARCA LIKE '%" + txtBuscar.Text + "%'", "ConsultaVEIC").Tables[0];
                else dgvVeic.DataSource = PreencheGrid.PrencherDados("SELECT * FROM ConsultaVeicDispon WHERE FABRICANTE LIKE '%" + txtBuscar.Text + "%'", "FABRICANTE").Tables[0];
            }

            dgvVeic.AutoResizeColumns();
            dgvVeic.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkDisponivel_CheckedChanged(object sender, EventArgs e)
        {
            frmConsultaVeic_Load(this, e);

        }

        
        


   

    }
}
