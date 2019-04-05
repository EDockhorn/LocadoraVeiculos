namespace PIM_LocadoraVeiculos.Funcionários
{
    partial class frmFuncionarios1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionarios1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskDataDemi = new System.Windows.Forms.DateTimePicker();
            this.mskDataAd = new System.Windows.Forms.DateTimePicker();
            this.mskDataNasc = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskRG = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtUF = new System.Windows.Forms.ComboBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbLogin = new System.Windows.Forms.ComboBox();
            this.btnUsu = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskDataDemi);
            this.groupBox1.Controls.Add(this.mskDataAd);
            this.groupBox1.Controls.Add(this.mskDataNasc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.chkAtivo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mskTelefone);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.mskCPF);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mskRG);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // mskDataDemi
            // 
            this.mskDataDemi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            resources.ApplyResources(this.mskDataDemi, "mskDataDemi");
            this.mskDataDemi.Name = "mskDataDemi";
            // 
            // mskDataAd
            // 
            this.mskDataAd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            resources.ApplyResources(this.mskDataAd, "mskDataAd");
            this.mskDataAd.Name = "mskDataAd";
            // 
            // mskDataNasc
            // 
            this.mskDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            resources.ApplyResources(this.mskDataNasc, "mskDataNasc");
            this.mskDataNasc.Name = "mskDataNasc";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Name = "label7";
            // 
            // chkAtivo
            // 
            resources.ApplyResources(this.chkAtivo, "chkAtivo");
            this.chkAtivo.Checked = true;
            this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            this.chkAtivo.CheckedChanged += new System.EventHandler(this.chkAtivo_CheckedChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Name = "label4";
            // 
            // mskTelefone
            // 
            resources.ApplyResources(this.mskTelefone, "mskTelefone");
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTelefone_MaskInputRejected);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Name = "label8";
            // 
            // mskCPF
            // 
            resources.ApplyResources(this.mskCPF, "mskCPF");
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCPF_MaskInputRejected);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Name = "label6";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Name = "label3";
            // 
            // mskRG
            // 
            resources.ApplyResources(this.mskRG, "mskRG");
            this.mskRG.Name = "mskRG";
            this.mskRG.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskRG_MaskInputRejected);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Name = "label2";
            // 
            // txtNome
            // 
            resources.ApplyResources(this.txtNome, "txtNome");
            this.txtNome.Name = "txtNome";
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Name = "label1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtUF);
            this.groupBox3.Controls.Add(this.txtnum);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtBairro);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtCidade);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtLogradouro);
            this.groupBox3.Controls.Add(this.mskCEP);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // txtUF
            // 
            this.txtUF.FormattingEnabled = true;
            this.txtUF.Items.AddRange(new object[] {
            resources.GetString("txtUF.Items"),
            resources.GetString("txtUF.Items1"),
            resources.GetString("txtUF.Items2"),
            resources.GetString("txtUF.Items3"),
            resources.GetString("txtUF.Items4"),
            resources.GetString("txtUF.Items5"),
            resources.GetString("txtUF.Items6"),
            resources.GetString("txtUF.Items7"),
            resources.GetString("txtUF.Items8"),
            resources.GetString("txtUF.Items9"),
            resources.GetString("txtUF.Items10"),
            resources.GetString("txtUF.Items11"),
            resources.GetString("txtUF.Items12"),
            resources.GetString("txtUF.Items13"),
            resources.GetString("txtUF.Items14"),
            resources.GetString("txtUF.Items15"),
            resources.GetString("txtUF.Items16"),
            resources.GetString("txtUF.Items17"),
            resources.GetString("txtUF.Items18"),
            resources.GetString("txtUF.Items19"),
            resources.GetString("txtUF.Items20"),
            resources.GetString("txtUF.Items21"),
            resources.GetString("txtUF.Items22"),
            resources.GetString("txtUF.Items23"),
            resources.GetString("txtUF.Items24"),
            resources.GetString("txtUF.Items25"),
            resources.GetString("txtUF.Items26")});
            resources.ApplyResources(this.txtUF, "txtUF");
            this.txtUF.Name = "txtUF";
            this.txtUF.SelectedIndexChanged += new System.EventHandler(this.txtUF_SelectedIndexChanged);
            // 
            // txtnum
            // 
            resources.ApplyResources(this.txtnum, "txtnum");
            this.txtnum.Name = "txtnum";
            this.txtnum.TextChanged += new System.EventHandler(this.txtnum_TextChanged);
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Name = "label14";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Name = "label13";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Name = "label12";
            // 
            // txtBairro
            // 
            resources.ApplyResources(this.txtBairro, "txtBairro");
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.TextChanged += new System.EventHandler(this.txtBairro_TextChanged);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Name = "label9";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Name = "label11";
            // 
            // txtCidade
            // 
            resources.ApplyResources(this.txtCidade, "txtCidade");
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.TextChanged += new System.EventHandler(this.txtCidade_TextChanged);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Name = "label10";
            // 
            // txtLogradouro
            // 
            resources.ApplyResources(this.txtLogradouro, "txtLogradouro");
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.TextChanged += new System.EventHandler(this.txtLogradouro_TextChanged);
            // 
            // mskCEP
            // 
            resources.ApplyResources(this.mskCEP, "mskCEP");
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCEP_MaskInputRejected);
            this.mskCEP.Leave += new System.EventHandler(this.mskCEP_Leave);
            // 
            // lblInfo
            // 
            resources.ApplyResources(this.lblInfo, "lblInfo");
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfo.Name = "lblInfo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbLogin);
            this.groupBox2.Controls.Add(this.btnUsu);
            this.groupBox2.Controls.Add(this.label19);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // cmbLogin
            // 
            this.cmbLogin.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.cmbLogin, "cmbLogin");
            this.cmbLogin.FormattingEnabled = true;
            this.cmbLogin.Name = "cmbLogin";
            this.cmbLogin.SelectedIndexChanged += new System.EventHandler(this.cmbLogin_SelectedIndexChanged);
            this.cmbLogin.Click += new System.EventHandler(this.cmbLogin_Click);
            // 
            // btnUsu
            // 
            this.btnUsu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUsu.BackgroundImage = global::PIM_LocadoraVeiculos.Properties.Resources.new_user_icon_47371;
            resources.ApplyResources(this.btnUsu, "btnUsu");
            this.btnUsu.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnUsu.Name = "btnUsu";
            this.toolTip1.SetToolTip(this.btnUsu, resources.GetString("btnUsu.ToolTip"));
            this.btnUsu.UseVisualStyleBackColor = false;
            this.btnUsu.Click += new System.EventHandler(this.btnUsu_Click);
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label19.Name = "label19";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSair.BackgroundImage = global::PIM_LocadoraVeiculos.Properties.Resources.exit_icon_3;
            resources.ApplyResources(this.btnSair, "btnSair");
            this.btnSair.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSair.Name = "btnSair";
            this.toolTip1.SetToolTip(this.btnSair, resources.GetString("btnSair.ToolTip"));
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSalvar.BackgroundImage = global::PIM_LocadoraVeiculos.Properties.Resources.disksave_4a90b428_e98a_4189_82cc_fd6163c92f1a;
            resources.ApplyResources(this.btnSalvar, "btnSalvar");
            this.btnSalvar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSalvar.Name = "btnSalvar";
            this.toolTip1.SetToolTip(this.btnSalvar, resources.GetString("btnSalvar.ToolTip"));
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmFuncionarios1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFuncionarios1";
            this.Load += new System.EventHandler(this.frmFuncionarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskRG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox txtUF;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DateTimePicker mskDataNasc;
        private System.Windows.Forms.DateTimePicker mskDataDemi;
        private System.Windows.Forms.DateTimePicker mskDataAd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnUsu;
        private System.Windows.Forms.ComboBox cmbLogin;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}