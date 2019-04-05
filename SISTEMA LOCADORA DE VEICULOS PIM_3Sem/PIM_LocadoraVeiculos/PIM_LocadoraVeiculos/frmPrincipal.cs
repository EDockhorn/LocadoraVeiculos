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


namespace PIM_LocadoraVeiculos
{
    public partial class frmPrincipal : Form
    {

        PreparaSQL preparasql = new PreparaSQL();
        Executa executa = new Executa();

        int codFunc = 0;


        public void CarregarPermissoes(string perfil)
        {
            switch (perfil)
            {
                case "Atendente":
                    toolStripSplitButton4.Visible = false;
                    toolStripButton1.Visible = false;
                    break;
                case "Gestor de frota":
                    toolStripSplitButton1.Visible = false;
                    toolStripSplitButton1.Visible = false;
                    break;
                case "Gerente geral":
                   
                    break;
                case "Gestor de RH":
                    toolStripSplitButton1.Visible = false;
                    toolStripSplitButton1.Visible = false;
                    toolStripSplitButton3.Visible = false;
                    toolStripButton1.Visible = false;
                    toolStripSplitButton2.Visible = false;
                    break;

            }
        }

        //Recebe o objeto para usar o método get do Login
        public void objUsuario(Usuarios usuarios)
        {
            


            String retorno = (executa.ExecutarConsulta(preparasql.ConsultaFunc(usuarios.getLogin())));
            String[] retornos = retorno.Split(',');

            toolUsuario.Text = retornos[0];
            toolPerfil.Text = retornos[1];
            codFunc = int.Parse(retornos[2]);

            CarregarPermissoes(usuarios.getPerfil());
            

        }

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes cli = new Clientes();

            MessageBox.Show("testando o construtor: " + cli.nome + " telefone " + cli.telefone);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RecuperaConexao con = new RecuperaConexao();

            con.TestaConexao();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void novoLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

        private void encerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            frmCadClientes frmcadclientes = new frmCadClientes();
            frmcadclientes.Text = "Incluindo Cliente";
            frmcadclientes.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmConsultaClientes consultacliente = new frmConsultaClientes();
            consultacliente.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuFunc_Click(object sender, EventArgs e)
        {
            Funcionários.frmFuncionarios1 frmFuncionarios1 = new Funcionários.frmFuncionarios1();
            frmFuncionarios1.Text = "Incluindo Funcionário";
            frmFuncionarios1.ShowDialog();
        }

        private void consultarFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaFunc consultafunc = new frmConsultaFunc();
            consultafunc.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmVeiculos veiculos = new frmVeiculos();
            veiculos.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmConsultaVeic consultaveic = new frmConsultaVeic();
            consultaveic.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmGerenciarLocacoes frmgerenciarlocacoes = new frmGerenciarLocacoes();
            frmgerenciarlocacoes.ShowDialog();
            
            
        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            Funcionários.frmFuncionarios1 func = new Funcionários.frmFuncionarios1();
            func.ShowDialog();

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            frmConsultaFunc consultafunc = new frmConsultaFunc();
            consultafunc.ShowDialog();
        }

        private void toolStripMenuItem2_Click_2(object sender, EventArgs e)
        {
            frmAlocacao alocar = new frmAlocacao();
            alocar.objUsuario(toolUsuario.Text, codFunc);
            alocar.ShowDialog();
        }

        private void alocaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorios relatorios = new frmRelatorios();
            relatorios.opcaoRelatorio = 1;
            relatorios.ShowDialog();
        }

        private void maisAlugadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorios relatorios = new frmRelatorios();
            relatorios.opcaoRelatorio = 4;
            relatorios.ShowDialog();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            frmRelatorios relatorios = new frmRelatorios();
            relatorios.opcaoRelatorio = 2;
            relatorios.ShowDialog();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            frmRelatorios relatorios = new frmRelatorios();
            relatorios.opcaoRelatorio = 3;
            relatorios.ShowDialog();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            frmCadClientes frmcadclientes = new frmCadClientes();
            frmcadclientes.Text = "Incluindo Cliente";
            frmcadclientes.ShowDialog();
        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {
            frmVeiculos veiculos = new frmVeiculos();
            veiculos.ShowDialog();

        }

        private void toolStripSplitButton4_ButtonClick(object sender, EventArgs e)
        {
            Funcionários.frmFuncionarios1 func = new Funcionários.frmFuncionarios1();
            func.ShowDialog();
        }

        private void toolStripSplitButton3_ButtonClick(object sender, EventArgs e)
        {
            frmAlocacao alocar = new frmAlocacao();
            alocar.objUsuario(toolUsuario.Text, codFunc);
            alocar.ShowDialog();
        }

        private void toolStripButton1_ButtonClick(object sender, EventArgs e)
        {
            frmRelatorios relatorios = new frmRelatorios();
            relatorios.opcaoRelatorio = 1;
            relatorios.ShowDialog();
        }


    }
}
