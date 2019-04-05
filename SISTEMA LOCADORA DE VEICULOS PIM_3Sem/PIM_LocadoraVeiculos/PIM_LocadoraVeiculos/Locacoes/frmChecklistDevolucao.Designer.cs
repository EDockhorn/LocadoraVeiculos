namespace PIM_LocadoraVeiculos
{
    partial class frmChecklistDevolucao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChecklistDevolucao));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk4 = new System.Windows.Forms.CheckBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.mskDataDevolu = new System.Windows.Forms.DateTimePicker();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProtoloco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorDiaria = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalvarMult = new System.Windows.Forms.Button();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInfracoes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtPGTO = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mskDatarealDev = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnFormaPGTO = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk2);
            this.groupBox1.Controls.Add(this.chk4);
            this.groupBox1.Controls.Add(this.chk3);
            this.groupBox1.Controls.Add(this.chk1);
            this.groupBox1.Controls.Add(this.mskDataDevolu);
            this.groupBox1.Controls.Add(this.txtPlaca);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtProtoloco);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtValorDiaria);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(25, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 266);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações da Reserva";
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Location = new System.Drawing.Point(223, 106);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(43, 19);
            this.chk2.TabIndex = 2;
            this.chk2.Text = "OK";
            this.chk2.UseVisualStyleBackColor = true;
            this.chk2.CheckedChanged += new System.EventHandler(this.chk2_CheckedChanged);
            // 
            // chk4
            // 
            this.chk4.AutoSize = true;
            this.chk4.Location = new System.Drawing.Point(223, 214);
            this.chk4.Name = "chk4";
            this.chk4.Size = new System.Drawing.Size(43, 19);
            this.chk4.TabIndex = 4;
            this.chk4.Text = "OK";
            this.chk4.UseVisualStyleBackColor = true;
            this.chk4.CheckedChanged += new System.EventHandler(this.chk4_CheckedChanged);
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Location = new System.Drawing.Point(223, 161);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(43, 19);
            this.chk3.TabIndex = 3;
            this.chk3.Text = "OK";
            this.chk3.UseVisualStyleBackColor = true;
            this.chk3.CheckedChanged += new System.EventHandler(this.chk3_CheckedChanged);
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Location = new System.Drawing.Point(223, 53);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(43, 19);
            this.chk1.TabIndex = 1;
            this.chk1.Text = "OK";
            this.chk1.UseVisualStyleBackColor = true;
            this.chk1.CheckedChanged += new System.EventHandler(this.chk1_CheckedChanged);
            // 
            // mskDataDevolu
            // 
            this.mskDataDevolu.Enabled = false;
            this.mskDataDevolu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mskDataDevolu.Location = new System.Drawing.Point(26, 210);
            this.mskDataDevolu.Name = "mskDataDevolu";
            this.mskDataDevolu.Size = new System.Drawing.Size(100, 21);
            this.mskDataDevolu.TabIndex = 37;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Enabled = false;
            this.txtPlaca.Location = new System.Drawing.Point(26, 53);
            this.txtPlaca.Mask = "aaa-0000";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(85, 21);
            this.txtPlaca.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 9.4F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(23, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "Previsão de Devolução";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 9.4F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(23, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Placa";
            // 
            // txtProtoloco
            // 
            this.txtProtoloco.Enabled = false;
            this.txtProtoloco.Location = new System.Drawing.Point(25, 161);
            this.txtProtoloco.Name = "txtProtoloco";
            this.txtProtoloco.Size = new System.Drawing.Size(143, 21);
            this.txtProtoloco.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 9.5F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(22, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Protocolo da Reserva";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 9.5F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(22, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Valor da Diária";
            // 
            // txtValorDiaria
            // 
            this.txtValorDiaria.Enabled = false;
            this.txtValorDiaria.Location = new System.Drawing.Point(25, 106);
            this.txtValorDiaria.Name = "txtValorDiaria";
            this.txtValorDiaria.Size = new System.Drawing.Size(71, 21);
            this.txtValorDiaria.TabIndex = 32;
            this.txtValorDiaria.Text = "0.00";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfo.Location = new System.Drawing.Point(17, 466);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(134, 18);
            this.lblInfo.TabIndex = 36;
            this.lblInfo.Text = "Informativo usuário";
            // 
            // txtSituacao
            // 
            this.txtSituacao.Location = new System.Drawing.Point(25, 334);
            this.txtSituacao.Multiline = true;
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Size = new System.Drawing.Size(290, 105);
            this.txtSituacao.TabIndex = 42;
            this.txtSituacao.TextChanged += new System.EventHandler(this.txtSituacao_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 9.5F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(92, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Situação da Checagem";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSalvarMult);
            this.groupBox2.Controls.Add(this.txtMotivo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtInfracoes);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(339, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 266);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Infrações de trânsito";
            // 
            // btnSalvarMult
            // 
            this.btnSalvarMult.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSalvarMult.BackgroundImage = global::PIM_LocadoraVeiculos.Properties.Resources.disksave_4a90b428_e98a_4189_82cc_fd6163c92f1a;
            this.btnSalvarMult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvarMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarMult.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSalvarMult.Location = new System.Drawing.Point(286, 237);
            this.btnSalvarMult.Name = "btnSalvarMult";
            this.btnSalvarMult.Size = new System.Drawing.Size(37, 23);
            this.btnSalvarMult.TabIndex = 50;
            this.toolTip1.SetToolTip(this.btnSalvarMult, "Salvar o total de multas");
            this.btnSalvarMult.UseVisualStyleBackColor = false;
            this.btnSalvarMult.Click += new System.EventHandler(this.btnSalvarMult_Click);
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(21, 124);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(293, 99);
            this.txtMotivo.TabIndex = 35;
            this.txtMotivo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 9.5F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(93, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Motivo das infrações";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 9.5F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(18, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Valor total das infrações";
            // 
            // txtInfracoes
            // 
            this.txtInfracoes.Location = new System.Drawing.Point(208, 51);
            this.txtInfracoes.Name = "txtInfracoes";
            this.txtInfracoes.Size = new System.Drawing.Size(106, 21);
            this.txtInfracoes.TabIndex = 32;
            this.txtInfracoes.Text = "0.00";
            this.txtInfracoes.MouseLeave += new System.EventHandler(this.textBox3_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(346, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 18);
            this.label4.TabIndex = 46;
            this.label4.Text = "Valor a ser pago:";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(583, 397);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(74, 26);
            this.txtValorTotal.TabIndex = 47;
            this.txtValorTotal.Text = "0.00";
            // 
            // txtPGTO
            // 
            this.txtPGTO.Enabled = false;
            this.txtPGTO.Location = new System.Drawing.Point(583, 344);
            this.txtPGTO.Name = "txtPGTO";
            this.txtPGTO.Size = new System.Drawing.Size(74, 20);
            this.txtPGTO.TabIndex = 38;
            this.txtPGTO.TextChanged += new System.EventHandler(this.txtPGTO_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Fax", 10F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(346, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 16);
            this.label10.TabIndex = 49;
            this.label10.Text = "Forma de pagamento:";
            // 
            // mskDatarealDev
            // 
            this.mskDatarealDev.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mskDatarealDev.Location = new System.Drawing.Point(583, 308);
            this.mskDatarealDev.Name = "mskDatarealDev";
            this.mskDatarealDev.Size = new System.Drawing.Size(100, 20);
            this.mskDatarealDev.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 9.4F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(346, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Data da Devolução";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalcular.BackgroundImage = global::PIM_LocadoraVeiculos.Properties.Resources.floppy_save_icon__231;
            this.btnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCalcular.Location = new System.Drawing.Point(663, 402);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(29, 21);
            this.btnCalcular.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnCalcular, "Calcular valor total da locaçã");
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnFormaPGTO
            // 
            this.btnFormaPGTO.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFormaPGTO.BackgroundImage = global::PIM_LocadoraVeiculos.Properties.Resources.Magnifying_Glass_icon;
            this.btnFormaPGTO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFormaPGTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormaPGTO.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnFormaPGTO.Location = new System.Drawing.Point(663, 344);
            this.btnFormaPGTO.Name = "btnFormaPGTO";
            this.btnFormaPGTO.Size = new System.Drawing.Size(29, 21);
            this.btnFormaPGTO.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnFormaPGTO, "Selecionar a forma de pagamento");
            this.btnFormaPGTO.UseVisualStyleBackColor = false;
            this.btnFormaPGTO.Click += new System.EventHandler(this.btnFormaPGTO_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSair.BackgroundImage = global::PIM_LocadoraVeiculos.Properties.Resources.exit_icon_3;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSair.Location = new System.Drawing.Point(625, 451);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(64, 51);
            this.btnSair.TabIndex = 45;
            this.toolTip1.SetToolTip(this.btnSair, "Sair");
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSalvar.BackgroundImage = global::PIM_LocadoraVeiculos.Properties.Resources._61360_2001;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSalvar.Location = new System.Drawing.Point(339, 451);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(69, 51);
            this.btnSalvar.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnSalvar, "Devolver");
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmChecklistDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(720, 527);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.mskDatarealDev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFormaPGTO);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPGTO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSituacao);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChecklistDevolucao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Check list Devolução";
            this.Load += new System.EventHandler(this.frmChecklistDevolucao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DateTimePicker mskDataDevolu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProtoloco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValorDiaria;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.CheckBox chk4;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtInfracoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtPGTO;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnFormaPGTO;
        private System.Windows.Forms.DateTimePicker mskDatarealDev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSalvarMult;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}