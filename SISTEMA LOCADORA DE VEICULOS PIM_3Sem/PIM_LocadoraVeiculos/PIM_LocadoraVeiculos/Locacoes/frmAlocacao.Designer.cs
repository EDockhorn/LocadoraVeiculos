namespace PIM_LocadoraVeiculos
{
    partial class frmAlocacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlocacao));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLocalVeicu = new System.Windows.Forms.Button();
            this.pictureFoto = new System.Windows.Forms.PictureBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mskCNH = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLocalCliente = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnContrato = new System.Windows.Forms.Button();
            this.mskDataDevolu = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProtoloco = new System.Windows.Forms.TextBox();
            this.mskDataReserva = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorDiaria = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblFoto = new System.Windows.Forms.Label();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.dlgPrintPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.docPrint = new System.Drawing.Printing.PrintDocument();
            this.dlgPrint = new System.Windows.Forms.PrintDialog();
            this.lblEnder = new System.Windows.Forms.Label();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFabricante);
            this.groupBox1.Controls.Add(this.txtPlaca);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnLocalVeicu);
            this.groupBox1.Controls.Add(this.pictureFoto);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 223);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha o veículo";
            // 
            // txtFabricante
            // 
            this.txtFabricante.Enabled = false;
            this.txtFabricante.Location = new System.Drawing.Point(23, 59);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(152, 21);
            this.txtFabricante.TabIndex = 32;
            this.txtFabricante.TextChanged += new System.EventHandler(this.txtFabricante_TextChanged);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Enabled = false;
            this.txtPlaca.Location = new System.Drawing.Point(23, 174);
            this.txtPlaca.Mask = "aaa-0000";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(85, 21);
            this.txtPlaca.TabIndex = 31;
            this.txtPlaca.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtPlaca_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 9.5F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(20, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Placa";
            // 
            // btnLocalVeicu
            // 
            this.btnLocalVeicu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLocalVeicu.BackgroundImage = global::PIM_LocadoraVeiculos.Properties.Resources.Magnifying_Glass_icon;
            this.btnLocalVeicu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLocalVeicu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalVeicu.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnLocalVeicu.Location = new System.Drawing.Point(128, 155);
            this.btnLocalVeicu.Name = "btnLocalVeicu";
            this.btnLocalVeicu.Size = new System.Drawing.Size(47, 47);
            this.btnLocalVeicu.TabIndex = 28;
            this.toolTip1.SetToolTip(this.btnLocalVeicu, "Buscar veículos");
            this.btnLocalVeicu.UseVisualStyleBackColor = false;
            this.btnLocalVeicu.Click += new System.EventHandler(this.btnLocalVeicu_Click);
            // 
            // pictureFoto
            // 
            this.pictureFoto.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureFoto.Image = global::PIM_LocadoraVeiculos.Properties.Resources._7_512;
            this.pictureFoto.Location = new System.Drawing.Point(201, 33);
            this.pictureFoto.Name = "pictureFoto";
            this.pictureFoto.Size = new System.Drawing.Size(205, 127);
            this.pictureFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureFoto.TabIndex = 25;
            this.pictureFoto.TabStop = false;
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Location = new System.Drawing.Point(23, 114);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(152, 21);
            this.txtMarca.TabIndex = 4;
            this.txtMarca.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 9.5F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(20, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Marca";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 9.5F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(20, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Fabricante";
            // 
            // mskCPF
            // 
            this.mskCPF.Enabled = false;
            this.mskCPF.Location = new System.Drawing.Point(22, 104);
            this.mskCPF.Mask = "000.000.000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(100, 21);
            this.mskCPF.TabIndex = 8;
            this.mskCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCPF_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 9.5F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mskCNH);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtCliente);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnLocalCliente);
            this.groupBox2.Controls.Add(this.mskCPF);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(463, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 195);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Escolha o cliente";
            // 
            // mskCNH
            // 
            this.mskCNH.Enabled = false;
            this.mskCNH.Location = new System.Drawing.Point(22, 152);
            this.mskCNH.Mask = "00000000000";
            this.mskCNH.Name = "mskCNH";
            this.mskCNH.Size = new System.Drawing.Size(100, 21);
            this.mskCNH.TabIndex = 34;
            this.mskCNH.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCNH_MaskInputRejected);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Fax", 9.5F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(19, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 16);
            this.label11.TabIndex = 35;
            this.label11.Text = "CNH";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(22, 52);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(197, 21);
            this.txtCliente.TabIndex = 33;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 9.5F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(19, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "CPF";
            // 
            // btnLocalCliente
            // 
            this.btnLocalCliente.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLocalCliente.BackgroundImage = global::PIM_LocadoraVeiculos.Properties.Resources.Magnifying_Glass_icon;
            this.btnLocalCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLocalCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalCliente.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnLocalCliente.Location = new System.Drawing.Point(172, 126);
            this.btnLocalCliente.Name = "btnLocalCliente";
            this.btnLocalCliente.Size = new System.Drawing.Size(47, 47);
            this.btnLocalCliente.TabIndex = 28;
            this.toolTip1.SetToolTip(this.btnLocalCliente, "Buscar clientes");
            this.btnLocalCliente.UseVisualStyleBackColor = false;
            this.btnLocalCliente.Click += new System.EventHandler(this.btnLocalCliente_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnContrato);
            this.groupBox3.Controls.Add(this.mskDataDevolu);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtProtoloco);
            this.groupBox3.Controls.Add(this.mskDataReserva);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtValorDiaria);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(12, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(432, 215);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informações sobre a locação";
            // 
            // btnContrato
            // 
            this.btnContrato.ForeColor = System.Drawing.Color.Black;
            this.btnContrato.Location = new System.Drawing.Point(25, 155);
            this.btnContrato.Name = "btnContrato";
            this.btnContrato.Size = new System.Drawing.Size(301, 40);
            this.btnContrato.TabIndex = 38;
            this.btnContrato.Text = "Emitir contrato";
            this.toolTip1.SetToolTip(this.btnContrato, "Realizar a emissão do contrato de locação");
            this.btnContrato.UseVisualStyleBackColor = true;
            this.btnContrato.Click += new System.EventHandler(this.btnContrato_Click);
            // 
            // mskDataDevolu
            // 
            this.mskDataDevolu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mskDataDevolu.Location = new System.Drawing.Point(183, 54);
            this.mskDataDevolu.Name = "mskDataDevolu";
            this.mskDataDevolu.Size = new System.Drawing.Size(100, 21);
            this.mskDataDevolu.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 9.4F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(180, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "Previsão de Devolução";
            // 
            // txtProtoloco
            // 
            this.txtProtoloco.Enabled = false;
            this.txtProtoloco.Location = new System.Drawing.Point(183, 113);
            this.txtProtoloco.Name = "txtProtoloco";
            this.txtProtoloco.Size = new System.Drawing.Size(143, 21);
            this.txtProtoloco.TabIndex = 35;
            this.txtProtoloco.TextChanged += new System.EventHandler(this.txtProtoloco_TextChanged);
            // 
            // mskDataReserva
            // 
            this.mskDataReserva.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mskDataReserva.Location = new System.Drawing.Point(25, 54);
            this.mskDataReserva.Name = "mskDataReserva";
            this.mskDataReserva.Size = new System.Drawing.Size(100, 21);
            this.mskDataReserva.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 9.4F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(21, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Data da Reserva";
            // 
            // txtValorDiaria
            // 
            this.txtValorDiaria.Location = new System.Drawing.Point(23, 113);
            this.txtValorDiaria.Name = "txtValorDiaria";
            this.txtValorDiaria.Size = new System.Drawing.Size(71, 21);
            this.txtValorDiaria.TabIndex = 32;
            this.txtValorDiaria.Text = "0.00";
            this.txtValorDiaria.TextChanged += new System.EventHandler(this.txtValorDiaria_TextChanged);
            this.txtValorDiaria.Leave += new System.EventHandler(this.txtValorDiaria_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 9.5F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(20, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Valor da Diária";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 9.5F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(180, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Protocolo";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfo.Location = new System.Drawing.Point(460, 270);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(134, 18);
            this.lblInfo.TabIndex = 34;
            this.lblInfo.Text = "Informativo usuário";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Fax", 9.5F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(460, 366);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "Usuário";
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.BackColor = System.Drawing.Color.Transparent;
            this.lblFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFoto.Location = new System.Drawing.Point(460, 241);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(39, 18);
            this.lblFoto.TabIndex = 36;
            this.lblFoto.Text = "Foto";
            this.lblFoto.Visible = false;
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Enabled = false;
            this.txtFuncionario.Location = new System.Drawing.Point(463, 385);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(166, 20);
            this.txtFuncionario.TabIndex = 34;
            // 
            // dlgPrintPreview
            // 
            this.dlgPrintPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.dlgPrintPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.dlgPrintPreview.ClientSize = new System.Drawing.Size(400, 300);
            this.dlgPrintPreview.Document = this.docPrint;
            this.dlgPrintPreview.Enabled = true;
            this.dlgPrintPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("dlgPrintPreview.Icon")));
            this.dlgPrintPreview.Name = "dlgPrintPreview";
            this.dlgPrintPreview.Visible = false;
            // 
            // docPrint
            // 
            this.docPrint.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.docPrint_PrintPage);
            // 
            // dlgPrint
            // 
            this.dlgPrint.Document = this.docPrint;
            this.dlgPrint.UseEXDialog = true;
            // 
            // lblEnder
            // 
            this.lblEnder.AutoSize = true;
            this.lblEnder.BackColor = System.Drawing.Color.Transparent;
            this.lblEnder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEnder.Location = new System.Drawing.Point(460, 303);
            this.lblEnder.Name = "lblEnder";
            this.lblEnder.Size = new System.Drawing.Size(72, 18);
            this.lblEnder.TabIndex = 37;
            this.lblEnder.Text = "Endereco";
            this.lblEnder.Visible = false;
            // 
            // btnDevolver
            // 
            this.btnDevolver.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDevolver.BackgroundImage = global::PIM_LocadoraVeiculos.Properties.Resources.Hands_Holding_Key_512;
            this.btnDevolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolver.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDevolver.Location = new System.Drawing.Point(459, 434);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(69, 51);
            this.btnDevolver.TabIndex = 38;
            this.toolTip1.SetToolTip(this.btnDevolver, "Devolver");
            this.btnDevolver.UseVisualStyleBackColor = false;
            this.btnDevolver.Visible = false;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSair.BackgroundImage = global::PIM_LocadoraVeiculos.Properties.Resources.exit_icon_3;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSair.Location = new System.Drawing.Point(645, 434);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(64, 51);
            this.btnSair.TabIndex = 35;
            this.toolTip1.SetToolTip(this.btnSair, "Sair");
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSalvar.BackgroundImage = global::PIM_LocadoraVeiculos.Properties.Resources.disksave_4a90b428_e98a_4189_82cc_fd6163c92f1a;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSalvar.Location = new System.Drawing.Point(459, 434);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(69, 51);
            this.btnSalvar.TabIndex = 33;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar");
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmAlocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(734, 523);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.lblEnder);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.lblFoto);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlocacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reservando Veículos";
            this.Load += new System.EventHandler(this.frmAlocacao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureFoto;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLocalVeicu;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLocalCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorDiaria;
        private System.Windows.Forms.DateTimePicker mskDataDevolu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProtoloco;
        private System.Windows.Forms.DateTimePicker mskDataReserva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnContrato;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.PrintPreviewDialog dlgPrintPreview;
        private System.Drawing.Printing.PrintDocument docPrint;
        private System.Windows.Forms.PrintDialog dlgPrint;
        private System.Windows.Forms.MaskedTextBox mskCNH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblEnder;
        public System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}