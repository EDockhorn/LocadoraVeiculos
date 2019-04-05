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
    public partial class frmRelatorios : Form
    {
        public int opcaoRelatorio = 0;

        // Opção 1 = Relatório de todos os  veículos alugados
        // Opção 2 = Relatório de veículos mais alugados

        PreencheDataGridView PreencheGrid = new PreencheDataGridView();
        public frmRelatorios()
        {
            InitializeComponent();
        }

        private void frmRelatorios_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "";

            switch (opcaoRelatorio)
            {
                case 1:
                    dgvRelatorios.DataSource = PreencheGrid.PrencherDados("SELECT * FROM vw_VeiculosLocados", "vw_VeiculosLocados").Tables[0];
                    break;
                case 2:
                    dgvRelatorios.DataSource = PreencheGrid.PrencherDados("SELECT * FROM vw_VeiculosMaisUtilizados", "vw_VeiculosMaisUtilizados").Tables[0];
                    break;
                case 3:
                    dgvRelatorios.DataSource = PreencheGrid.PrencherDados("SELECT * FROM vw_Pagamentos", "vw_Pagamentos").Tables[0];
                    break;
                case 4:
                    dgvRelatorios.DataSource = PreencheGrid.PrencherDados("SELECT * FROM vw_MULTAS", "vw_MULTAS").Tables[0];
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();

            //Método para realizar a exportação para EXCEL
            Cursor.Current = Cursors.WaitCursor;
            lblInfo.Text = "Exportando...";

            if (dgvRelatorios.Rows.Count > 0)
            {
                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);

                    for (int i = 1; i < dgvRelatorios.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = dgvRelatorios.Columns[i - 1].HeaderText;
                    }
                    //
                    for (int i = 0; i < dgvRelatorios.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgvRelatorios.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = dgvRelatorios.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    //
                    XcelApp.Columns.AutoFit();
                    //
                    XcelApp.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                    XcelApp.Quit();
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                    lblInfo.Text = "";
                }
            }
        }

        
    }
}
