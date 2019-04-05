using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dll_Uteis;
using dll_BS_LocadoraVeiculos;
using dll_DB_LocadoraVeiculos;
using System.Data.SqlClient;

namespace PIM_LocadoraVeiculos
{
    public partial class frmAlocacao : Form
    {
        public int operacao = 1;
        public int IDReserva = 0;

        RecuperaConexao conexao = new RecuperaConexao();
        PreparaSQL preparasql = new PreparaSQL();
        VerificaCampos verificacampos = new VerificaCampos();
        Executa executar = new Executa();

        ValidaRegras validaregras = new ValidaRegras();


        frmConsultaVeic frmconsultaveic = new frmConsultaVeic();
        frmConsultaClientes frmconsultacli = new frmConsultaClientes();

        frmChecklistDevolucao checklist = new frmChecklistDevolucao();

        Clientes clientes = new Clientes();
        Reservas reservas = new Reservas();
        Veiculos veiculos = new Veiculos();

        //Variáveis para armazenar os objetos relacionados:
        int intVeic = 0;
        int intCli = 0;
        int intFunc = 0;
        int intReserva = 0;




        public void objUsuario(string nomeUsu,int codFunc)
        {
            txtFuncionario.Text = nomeUsu;
            intFunc = codFunc;
        }
        


        public frmAlocacao()
        {
            InitializeComponent();

        }

        

        private void frmAlocacao_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            if (operacao == 2)  // Devolução
            {
                CarregarReservas(IDReserva);
                CarregarCliente(intCli);
                CarregarVeiculo(intVeic);
                AlterarControles();

                //Passa os valores para a Classe:
                reservas.setCodigo(intVeic);
                reservas.placa = txtPlaca.Text;
                reservas.marca = txtMarca.Text;
                reservas.fabricante = txtFabricante.Text;

                reservas.codcli = intCli;
                reservas.nome = txtCliente.Text;
                reservas.cpf = mskCPF.Text;
                reservas.CNH = mskCNH.Text;

                reservas.datareserva = Convert.ToDateTime(mskDataReserva.Text);
                reservas.datadevolucao = Convert.ToDateTime(mskDataDevolu.Text);
                reservas.protoloco = txtProtoloco.Text;
                reservas.valordiaria = Convert.ToDouble(txtValorDiaria.Text);

              
                reservas.valortotal = Convert.ToDouble(CalculaDiasETotais());

                reservas.codigoreserva = intReserva;




                
            }
            
        }

        
        public void CarregarReservas(int IDReserva)
        {
            try
            {
                SqlConnection con = new SqlConnection(conexao.RecuperaCNN());
                SqlCommand cmd = new SqlCommand(preparasql.ConsultaInfoRESERVAS(IDReserva), con);

                con.Open();
                using (SqlDataReader leitor = cmd.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        // cliRES,veicRES,funcRES,imgVEIC
                        // dataRES,datadevolucaoRES,valordiariaRES,protocoloRES
                        intReserva = int.Parse(leitor["codRES"].ToString());
                        intCli = int.Parse(leitor["cliRES"].ToString());
                        intVeic = int.Parse(leitor["veicRES"].ToString());
                        intFunc = int.Parse(leitor["funcRES"].ToString());
                        lblFoto.Text = leitor["imgVEIC"].ToString();

                        mskDataReserva.Text = leitor["dataRES"].ToString();
                        mskDataDevolu.Text = leitor["datadevolucaoRES"].ToString();
                        txtValorDiaria.Text = leitor["valordiariaRES"].ToString();
                        txtProtoloco.Text = leitor["protocoloRES"].ToString();

                        txtFuncionario.Text = "admin";
                        if (lblFoto.Text != "Foto")
                        {
                            pictureFoto.Image = Image.FromFile(lblFoto.Text);
                        }

                    }
                    leitor.Close();
                }

                con.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao carregar a reserva", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CarregarVeiculo(int codigo)
        {
            try
            {
              
                SqlConnection con = new SqlConnection(conexao.RecuperaCNN());
                SqlCommand cmd = new SqlCommand(preparasql.ConsultaVeiculoReserva(codigo), con);

                con.Open();
                using (SqlDataReader leitor = cmd.ExecuteReader())
                {
                    while (leitor.Read())
                    {

                        txtFabricante.Text = leitor["fabricanteVEIC"].ToString();
                        txtPlaca.Text = leitor["placaVEIC"].ToString();
                        txtMarca.Text = leitor["marcaVEIC"].ToString();
                        lblFoto.Text = leitor["imgVEIC"].ToString();

                        if (lblFoto.Text != "Foto")
                        {
                            pictureFoto.Image = Image.FromFile(lblFoto.Text);
                        }

                    }
                    leitor.Close();
                }

                con.Close();
            }
               
            

            catch
            {
                MessageBox.Show("Erro ao carregar o veículo", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CarregarCliente(int codigo)
        {
            try
            {

                SqlConnection con = new SqlConnection(conexao.RecuperaCNN());
                SqlCommand cmd = new SqlCommand(preparasql.ConsultaClienteReserva(codigo), con);

                string endereco = string.Empty;

                con.Open();
                using (SqlDataReader leitor = cmd.ExecuteReader())
                {
                    while (leitor.Read())
                    {

                        txtCliente.Text = leitor["nomeCLI"].ToString();
                        mskCPF.Text = leitor["cpfCLI"].ToString();
                        mskCNH.Text = leitor["cnhCLI"].ToString();
                        endereco = leitor["enderCLI"].ToString();
                        endereco = endereco + " " + leitor["bairroCLI"].ToString();
                        endereco = endereco + " " + leitor["cidadeCLI"].ToString();
                        lblEnder.Text = endereco;
                        


                    }
                    leitor.Close();
                }

                con.Close();
            }

            catch
            {
                MessageBox.Show("Erro ao carregar os clientes!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLocalVeicu_Click(object sender, EventArgs e)
        {
            
            lblInfo.Text = "";
            frmconsultaveic.OPReserva = 2;
            frmconsultaveic.verFiltroDisp = 1;
            frmconsultaveic.chkDisponivel.Checked = true;
            frmconsultaveic.ShowDialog();

            intVeic = frmconsultaveic.RetornaID();

            CarregarVeiculo(intVeic);
       

            
        }

        private void btnLocalCliente_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            frmconsultacli.OPReserva = 2;
            frmconsultacli.ShowDialog();

            intCli = frmconsultacli.RetornaID();

            CarregarCliente(intCli);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string ret = string.Empty;
            string RN = string.Empty;

            if (intFunc == 0) intFunc =1;

            // -1 é o valor aceitável
            int comparacao = DateTime.Compare(Convert.ToDateTime(mskDataReserva.Text) , Convert.ToDateTime(mskDataDevolu.Text));
            TimeSpan difference = Convert.ToDateTime(mskDataReserva.Text) - Convert.ToDateTime(mskDataDevolu.Text);
            //,Convert.ToString(difference.Days).Replace("-","")
            ret = verificacampos.verificaReserva(intVeic, intCli, intFunc, Convert.ToString(mskDataReserva.Text), 
                Convert.ToString(mskDataDevolu.Text), double.Parse(txtValorDiaria.Text), txtProtoloco.Text, comparacao);

            if (ret == "")
            {
                //Verifica se o veiculo já está reservado
                veiculos.setCodigo(intVeic);
                ret = Convert.ToString(validaregras.DB_ReservasPORVeiculo(veiculos));
            }
            if (ret == "")
            {
                
                if (operacao ==1) 
                {

                    //Verifica se o cliente possui outro veículo reservado 
                    clientes.setCodigo(intCli);
                    RN = Convert.ToString(validaregras.DB_ReservasPORCliente(clientes));

                    if (RN == "")
                    {


                        if (MessageBox.Show("Deseja incluir a reserva?", "Salvando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            //Calcula o total da reserva para salvar no banco:
                            reservas.valortotal = Convert.ToDouble(CalculaDiasETotais());

                            //Salva na base de dados:
                            executar.Executar(preparasql.preparaReserva(intVeic, intCli, intFunc, mskDataReserva.Text, mskDataDevolu.Text,
                            txtValorDiaria.Text, txtProtoloco.Text, Convert.ToString(difference.Days).Replace("-", ""),Convert.ToString(reservas.valortotal)));
                            MessageBox.Show("Reserva incluída com sucesso!", "Incluindo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LimparReservas();

                        }
                    }
                    else if (RN == "reservado")
                    {
                        lblInfo.Text = "O cliente já reservou outro veículo!";

                    }
                }
                
                
            }
            
            else if (ret == "veiculoreservado")
            {
                lblInfo.Text = "O veículo já está reservado!";
                
            }
            else if (ret == "veiculo")
            {
                lblInfo.Text = "Por favor escolha o veículo!";
                txtMarca.BackColor = System.Drawing.Color.LightCyan;
                txtFabricante.BackColor = System.Drawing.Color.LightCyan;
                txtPlaca.BackColor = System.Drawing.Color.LightCyan;
                
            }
            else if (ret == "cliente")
            {
                lblInfo.Text = "Por favor escolha um cliente!";
                txtCliente.BackColor = System.Drawing.Color.LightCyan;
                mskCPF.BackColor = System.Drawing.Color.LightCyan;
            }
            else if (ret == "valordiaria")
            {
                lblInfo.Text = "Por favor preencha o valor da diária!";
                txtValorDiaria.BackColor = System.Drawing.Color.LightCyan;
                txtValorDiaria.Focus();
            }
            else if (ret == "datainvalida")
            {
                lblInfo.Text = "Data de devolução inválida!";
                txtValorDiaria.BackColor = System.Drawing.Color.LightCyan;
                txtValorDiaria.Focus();
            }

            
        }

        private void LimparReservas()
        {
            txtFabricante.Text = "";
            txtMarca.Text = "";
            txtPlaca.Text = "";
            txtCliente.Text = "";
            mskCPF.Text = "";
            mskCNH.Text = "";
            txtValorDiaria.Text = "0.00";
            txtProtoloco.Text = "";
            lblFoto.Text = "Foto";
            pictureFoto.Image = null;

            intCli = 0;
            intVeic = 0;
        }

        private void txtFabricante_TextChanged(object sender, EventArgs e)
        {
            txtFabricante.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            txtMarca.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void txtPlaca_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            txtPlaca.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            txtCliente.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void mskCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mskCPF.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void txtValorDiaria_TextChanged(object sender, EventArgs e)
        {
            txtValorDiaria.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void txtProtoloco_TextChanged(object sender, EventArgs e)
        {
            txtProtoloco.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void txtValorDiaria_Leave(object sender, EventArgs e)
        {
            txtProtoloco.Text = GeraProtocolo();
        }

        private string GeraProtocolo()
        {
            //Algoritmo para a geração da numeração única de protocolo
            string protoloco = string.Empty;

            protoloco = Convert.ToString(Convert.ToDateTime(mskDataDevolu.Text).Day);
            protoloco = protoloco + Convert.ToString(Convert.ToDateTime(mskDataReserva.Text).Day);
            protoloco = protoloco + txtCliente.Text.Length;
            protoloco = protoloco + txtValorDiaria.Text.Replace(",","");
            protoloco = protoloco + txtFuncionario.Text.Length;

            return protoloco;
        }

        private void btnContrato_Click(object sender, EventArgs e)
        {
            dlgPrintPreview.ShowDialog();
        }

        public string CalculaDiasETotais()
        {
            TimeSpan difference = Convert.ToDateTime(mskDataReserva.Text) - Convert.ToDateTime(mskDataDevolu.Text);
            string dias = Convert.ToString(difference.Days).Replace("-", "");
            string valortotal = Convert.ToString(Convert.ToInt16(dias) * Convert.ToDouble(txtValorDiaria.Text.Replace(".", ",")));

            Convert.ToString(Convert.ToDouble(valortotal));

            return valortotal;
            
        }

        private void docPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            TimeSpan difference = Convert.ToDateTime(mskDataReserva.Text) - Convert.ToDateTime(mskDataDevolu.Text);
            string dias = Convert.ToString(difference.Days).Replace("-", "");
            string valortotal = Convert.ToString(Convert.ToInt16(dias) * Convert.ToDouble(txtValorDiaria.Text.Replace(".", ",")));


            e.Graphics.DrawLine(new Pen(Color.Black, 2), 80, 90, 750, 90);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 80, 93, 750, 93);

            string strDisplay = "AlôCAR - Locação de Veículos";
            System.Drawing.Font fntString = new Font("Times New Roman", 28,
                                FontStyle.Bold);
            e.Graphics.DrawString(strDisplay, fntString,
                                Brushes.Black, 240, 100);

            strDisplay = "Pedido de Locação de Veículo";
            fntString = new System.Drawing.Font("Times New Roman", 22,
                                FontStyle.Regular);
            e.Graphics.DrawString(strDisplay, fntString,
                                Brushes.Black, 320, 150);

            e.Graphics.DrawLine(new Pen(Color.Black, 1), 80, 187, 750, 187);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 80, 190, 750, 190);

            fntString = new System.Drawing.Font("Times New Roman", 12,
                        FontStyle.Bold);
            e.Graphics.DrawString("Protocolo #:  ", fntString,
                        Brushes.Black, 100, 220);
            fntString = new System.Drawing.Font("Times New Roman", 12,
                        FontStyle.Regular);
            e.Graphics.DrawString(txtProtoloco.Text, fntString,
                                          Brushes.Black, 260, 220);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 100, 240, 380, 240);

            fntString = new System.Drawing.Font("Times New Roman", 12,
                        FontStyle.Bold);
            e.Graphics.DrawString("Processado Por:  ", fntString,
                        Brushes.Black, 420, 220);
            fntString = new System.Drawing.Font("Times New Roman", 12,
                        FontStyle.Regular);
            e.Graphics.DrawString(txtFuncionario.Text, fntString,
                                          Brushes.Black, 550, 220);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 420, 240, 720, 240);

            fntString = new Font("Times New Roman", 12, FontStyle.Bold);

            e.Graphics.FillRectangle(Brushes.Gray, new Rectangle(100, 260, 620, 20));
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(100, 260, 620, 20));

            e.Graphics.DrawString("Cliente", fntString,
                                          Brushes.White, 100, 260);

            fntString = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("Registro CNH #: ", fntString,
                                          Brushes.Black, 100, 300);
            e.Graphics.DrawString("Nome: ", fntString,
                                         Brushes.Black, 420, 300);
            fntString = new Font("Times New Roman", 12, FontStyle.Regular);
            e.Graphics.DrawString(mskCNH.Text, fntString,
                                          Brushes.Black, 260, 300);
            e.Graphics.DrawString(txtCliente.Text, fntString,
                                          Brushes.Black, 540, 300);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 100, 320, 720, 320);

            fntString = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("Endereco: ", fntString,
                                          Brushes.Black, 100, 330);
            fntString = new Font("Times New Roman", 12, FontStyle.Regular);
            e.Graphics.DrawString(lblEnder.Text, fntString,
                                          Brushes.Black, 260, 330);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 100, 350, 720, 350);

            fntString = new System.Drawing.Font("Times New Roman",
                12, FontStyle.Regular);
            e.Graphics.DrawString(strDisplay, fntString,
                                          Brushes.Black, 260, 360);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 260, 380, 720, 380);

            fntString = new Font("Times New Roman", 12, FontStyle.Bold);

            e.Graphics.FillRectangle(Brushes.Gray,
                new Rectangle(100, 410, 620, 20));
            e.Graphics.DrawRectangle(Pens.Black,
                new Rectangle(100, 410, 620, 20));

            e.Graphics.DrawString("Informação Veículo", fntString,
                                          Brushes.White, 100, 410);

            
            e.Graphics.DrawString("Fabricante: ", fntString,
                                  Brushes.Black, 100, 480);
            fntString = new Font("Times New Roman", 12, FontStyle.Regular);
            e.Graphics.DrawString(txtFabricante.Text, fntString,
                                  Brushes.Black, 260, 480);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 100, 500, 380, 500);

            fntString = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("Marca: ", fntString,
                                  Brushes.Black, 420, 480);
            fntString = new Font("Times New Roman", 12, FontStyle.Regular);
            e.Graphics.DrawString(txtMarca.Text, fntString,
                                  Brushes.Black, 530, 480);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 420, 500, 720, 500);


            fntString = new Font("Times New Roman", 12, FontStyle.Regular);
           
            fntString = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("Data da Reserva:", fntString,
                                  Brushes.Black, 100, 620);
            fntString = new Font("Times New Roman", 12, FontStyle.Regular);
            e.Graphics.DrawString(mskDataReserva.Value.ToString("D"), fntString,
                                  Brushes.Black, 260, 620);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 100, 640, 720, 640);

            fntString = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("Data da Devolução:", fntString,
                                  Brushes.Black, 100, 650);
            fntString = new Font("Times New Roman", 12, FontStyle.Regular);
            e.Graphics.DrawString(mskDataDevolu.Value.ToString("D"), fntString,
                                  Brushes.Black, 260, 650);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 100, 670, 520, 670);

            fntString = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("Dias:", fntString,
                                  Brushes.Black, 550, 650);
            fntString = new Font("Times New Roman", 12, FontStyle.Regular);
            e.Graphics.DrawString(dias, fntString,
                                  Brushes.Black, 640, 650);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 550, 670, 720, 670);

            e.Graphics.FillRectangle(Brushes.Gray, new Rectangle(100, 700, 620, 20));
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(100, 700, 620, 20));

            fntString = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("Avaliação Pedido", fntString,
                                  Brushes.White, 100, 700);

            StringFormat fmtString = new StringFormat();
            fmtString.Alignment = StringAlignment.Far;

            fntString = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("Valor da diária:", fntString,
                                  Brushes.Black, 100, 740);
            fntString = new Font("Times New Roman", 12, FontStyle.Regular);
            e.Graphics.DrawString(txtValorDiaria.Text, fntString,
                                  Brushes.Black, 300, 740, fmtString);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 100, 760, 380, 760);

            fntString = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("Total Locação:", fntString,
                                          Brushes.Black, 420, 800);
            fntString = new Font("Times New Roman", 12, FontStyle.Regular);
            e.Graphics.DrawString(valortotal, fntString,
                                          Brushes.Black, 640, 800, fmtString);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 420, 820, 720, 820);

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void mskCNH_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mskCNH.BackColor = System.Drawing.Color.White;
            lblInfo.Text = "";
        }

        private void AlterarControles()
        {
            //Veículo
            txtFabricante.Enabled = false;
            txtMarca.Enabled = false;
            txtPlaca.Enabled = false;
            btnLocalVeicu.Enabled = false;
            //Cliente
            txtCliente.Enabled = false;
            mskCPF.Enabled = false;
            mskCNH.Enabled = false;
            btnLocalCliente.Enabled = false;
            //Reserva
            mskDataReserva.Enabled = false;
            mskDataDevolu.Enabled = false;
            txtValorDiaria.Enabled = false;
            txtProtoloco.Enabled = false;
            //Usuario
            txtFuncionario.Enabled = false;
            //Métodos
            btnContrato.Text = "Consultar Contrato";
            btnSalvar.Enabled = false;
            btnSalvar.Visible = false;
            btnDevolver.Enabled = true;
            btnDevolver.Visible = true;


        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            Reservas reservaconcluida = new Reservas();
            reservaconcluida =  checklist.retornaObjReserva();
            if (reservaconcluida.situacaoreserva == "D" && reservaconcluida.codigoreserva != 0 && checklist.salvo == true)
            {
                btnDevolver.Enabled = false;
            }
            else
            {
                checklist.objReservas(reservas);
                checklist.ShowDialog();
            }
            
        }

       
    }
}
