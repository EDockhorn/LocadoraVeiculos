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
    public partial class frmConsultaFunc : Form
    {
        public int ID;

        public frmConsultaFunc()
        {
            InitializeComponent();
        }

        private void frmConsultaFunc_Load(object sender, EventArgs e)
        {
            PreencheDataGridView PreencheGrid = new PreencheDataGridView();

            dgvFunc.DataSource = PreencheGrid.PrencherDados("SELECT * FROM ConsultaFUNC", "ConsultaFUNC").Tables[0];
            dgvFunc.AutoResizeColumns();
            dgvFunc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            lblInfo.Text = "";
        }

        private void dgvFunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dgvFunc.Rows[e.RowIndex].Cells[0].Value.ToString());
                lblInfo.Text = "";
            }
            catch
            {
                ID = 0;
                lblInfo.Text = "Clique em um registro para editar!";
            }
        }

        private void dgvFunc_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dgvFunc.Rows[e.RowIndex].Cells[0].Value.ToString());
            lblInfo.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                Funcionários.frmFuncionarios1 Funceditar = new Funcionários.frmFuncionarios1();
                Funceditar.Text = "Editando Funcionários";
                Funceditar.ID = ID;
                Funceditar.operacao = 2;
                Funceditar.ShowDialog();
                this.dgvFunc.DataSource = null;

                frmConsultaFunc_Load(this, e);
               
            }
            else
                lblInfo.Text = "Clique em um registro para editar!";
        }

        private void dgvFunc_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar_Click(this, e);
        }

        private void dgvFunc_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEditar_Click(this, e);
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            PreencheDataGridView PreencheGrid = new PreencheDataGridView();

            if (rdbNome.Checked) dgvFunc.DataSource = PreencheGrid.PrencherDados("SELECT * FROM ConsultaFUNC WHERE NOME LIKE '%" + txtBuscar.Text + "%'", "ConsultaFUNC").Tables[0];
            else dgvFunc.DataSource = PreencheGrid.PrencherDados("SELECT * FROM ConsultaFUNC WHERE CPF LIKE '%" + txtBuscar.Text + "%'", "ConsultaFUNC").Tables[0];
            dgvFunc.AutoResizeColumns();
            dgvFunc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }



   
    }
}
