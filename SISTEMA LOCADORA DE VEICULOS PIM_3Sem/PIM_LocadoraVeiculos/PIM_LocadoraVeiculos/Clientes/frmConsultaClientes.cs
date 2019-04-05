using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using dll_DB_LocadoraVeiculos;
using dll_BS_LocadoraVeiculos;

namespace PIM_LocadoraVeiculos
{
    public partial class frmConsultaClientes : Form
    {
        public int ID;
        public int OPReserva = 1;
        
        public frmConsultaClientes()
        {
            InitializeComponent();
        }

        public void frmConsultaClientes_Load(object sender, EventArgs e)
        {
            
            PreencheDataGridView PreencheGrid = new PreencheDataGridView();

            dgvClientes.DataSource = PreencheGrid.PrencherDados("SELECT * FROM ConsultaCLI","ConsultaCLI").Tables[0];
            dgvClientes.AutoResizeColumns();
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            lblInfo.Text = "";

            
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString());
                lblInfo.Text = "";
            }
            catch 
            {
                ID = 0;
                lblInfo.Text = "Clique em um registro para editar!";
            }
        }

        private void dgvClientes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString());
            lblInfo.Text = "";
            //txtAtuaLogin.Text = dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        public void btnEditar_Click(object sender, EventArgs e)
        {
            if (ID != 0 && OPReserva == 1)
            {
                frmCadClientes Clieditar = new frmCadClientes();
                Clieditar.Text = "Editando Cliente";
                Clieditar.ID = ID;
                Clieditar.operacao = 2;
                Clieditar.ShowDialog();
                this.dgvClientes.DataSource = null;
                dgvClientes.Rows.Clear();
                dgvClientes.Refresh();

                frmConsultaClientes_Load(this, e);
            }
            else if (ID != 0 && OPReserva == 2)
            {
                RetornaID();
                this.Close();
            }
            else
                lblInfo.Text = "Clique em um registro para editar!";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar_Click(this, e);

        }

        private void dgvClientes_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEditar_Click(this, e);
        }


        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            PreencheDataGridView PreencheGrid = new PreencheDataGridView();

            if (rdbNome.Checked) dgvClientes.DataSource = PreencheGrid.PrencherDados("SELECT * FROM ConsultaCLI WHERE NOME LIKE '%" + txtBuscar.Text + "%'", "ConsultaCLI").Tables[0];
            else dgvClientes.DataSource = PreencheGrid.PrencherDados("SELECT * FROM ConsultaCLI WHERE CPF LIKE '%" + txtBuscar.Text + "%'", "ConsultaCLI").Tables[0];
            dgvClientes.AutoResizeColumns();
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public int RetornaID()
        {
            return ID;
        }

        
        
       
    }
}
