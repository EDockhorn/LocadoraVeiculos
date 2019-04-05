namespace PIM_LocadoraVeiculos
{
    partial class frmVeiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVeiculos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.pictureFoto = new System.Windows.Forms.PictureBox();
            this.txtKM = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChassis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.mskDataFabr = new System.Windows.Forms.DateTimePicker();
            this.mskDataCompr = new System.Windows.Forms.DateTimePicker();
            this.mskDataUltimaRev = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dlgFoto = new System.Windows.Forms.OpenFileDialog();
            this.lblFoto = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPlaca);
            this.groupBox1.Controls.Add(this.btnFoto);
            this.groupBox1.Controls.Add(this.pictureFoto);
            this.groupBox1.Controls.Add(this.txtKM);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.txtFabricante);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtCor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtChassis);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 201);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Veículo";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(98, 72);
            this.txtPlaca.Mask = "aaa-0000";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(85, 21);
            this.txtPlaca.TabIndex = 3;
            this.txtPlaca.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtPlaca_MaskInputRejected);
            // 
            // btnFoto
            // 
            this.btnFoto.ForeColor = System.Drawing.Color.Black;
            this.btnFoto.Location = new System.Drawing.Point(504, 144);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(188, 37);
            this.btnFoto.TabIndex = 7;
            this.btnFoto.Text = "Foto do veículo";
            this.toolTip1.SetToolTip(this.btnFoto, "Buscar a foto do veículo");
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // pictureFoto
            // 
            this.pictureFoto.BackColor = System.Drawing.Color.Transparent;
            this.pictureFoto.Location = new System.Drawing.Point(504, 34);
            this.pictureFoto.Name = "pictureFoto";
            this.pictureFoto.Size = new System.Drawing.Size(188, 104);
            this.pictureFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureFoto.TabIndex = 25;
            this.pictureFoto.TabStop = false;
            // 
            // txtKM
            // 
            this.txtKM.Location = new System.Drawing.Point(331, 101);
            this.txtKM.Name = "txtKM";
            this.txtKM.Size = new System.Drawing.Size(67, 21);
            this.txtKM.TabIndex = 6;
            this.txtKM.TextChanged += new System.EventHandler(this.txtKM_TextChanged);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(331, 70);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(152, 21);
            this.txtMarca.TabIndex = 4;
            this.txtMarca.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            // 
            // txtFabricante
            // 
            this.txtFabricante.Location = new System.Drawing.Point(331, 34);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(152, 21);
            this.txtFabricante.TabIndex = 2;
            this.txtFabricante.TextChanged += new System.EventHandler(this.txtFabricante_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Fax", 9.4F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(250, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "KM";
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(98, 103);
            this.txtCor.MaxLength = 8;
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(134, 21);
            this.txtCor.TabIndex = 5;
            this.txtCor.TextChanged += new System.EventHandler(this.txtCor_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 9.5F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(24, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cor";
            // 
            // txtChassis
            // 
            this.txtChassis.Location = new System.Drawing.Point(98, 36);
            this.txtChassis.MaxLength = 17;
            this.txtChassis.Name = "txtChassis";
            this.txtChassis.Size = new System.Drawing.Size(134, 21);
            this.txtChassis.TabIndex = 1;
            this.txtChassis.TextChanged += new System.EventHandler(this.txtChassis_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 9.4F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(24, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Placa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 9.5F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(24, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Chassis";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 9.5F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(250, 75);
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
            this.label9.Location = new System.Drawing.Point(250, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Fabricante";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(384, 297);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(340, 42);
            this.txtObs.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 9.5F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(513, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Observações";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 9.4F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(13, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Data de Fabricação";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 9.4F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(13, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Data de compra";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Fax", 9.5F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(13, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Data da última revisão";
            // 
            // mskDataFabr
            // 
            this.mskDataFabr.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mskDataFabr.Location = new System.Drawing.Point(196, 29);
            this.mskDataFabr.Name = "mskDataFabr";
            this.mskDataFabr.Size = new System.Drawing.Size(100, 21);
            this.mskDataFabr.TabIndex = 8;
            // 
            // mskDataCompr
            // 
            this.mskDataCompr.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mskDataCompr.Location = new System.Drawing.Point(196, 68);
            this.mskDataCompr.Name = "mskDataCompr";
            this.mskDataCompr.Size = new System.Drawing.Size(100, 21);
            this.mskDataCompr.TabIndex = 9;
            // 
            // mskDataUltimaRev
            // 
            this.mskDataUltimaRev.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mskDataUltimaRev.Location = new System.Drawing.Point(196, 105);
            this.mskDataUltimaRev.Name = "mskDataUltimaRev";
            this.mskDataUltimaRev.Size = new System.Drawing.Size(100, 21);
            this.mskDataUltimaRev.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mskDataUltimaRev);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.mskDataCompr);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.mskDataFabr);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(12, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 140);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controle";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfo.Location = new System.Drawing.Point(20, 396);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(134, 18);
            this.lblInfo.TabIndex = 34;
            this.lblInfo.Text = "Informativo usuário";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSair.BackgroundImage = global::PIM_LocadoraVeiculos.Properties.Resources.exit_icon_3;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSair.Location = new System.Drawing.Point(664, 381);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(64, 51);
            this.btnSair.TabIndex = 13;
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
            this.btnSalvar.Location = new System.Drawing.Point(384, 381);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(69, 51);
            this.btnSalvar.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar");
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dlgFoto
            // 
            this.dlgFoto.FileName = "Escolha a foto do seu veículo";
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.BackColor = System.Drawing.Color.Transparent;
            this.lblFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFoto.Location = new System.Drawing.Point(381, 351);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(39, 18);
            this.lblFoto.TabIndex = 35;
            this.lblFoto.Text = "Foto";
            this.lblFoto.Visible = false;
            // 
            // frmVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(740, 464);
            this.Controls.Add(this.lblFoto);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVeiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastrar Veículos";
            this.Load += new System.EventHandler(this.frmVeiculos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChassis;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.DateTimePicker mskDataFabr;
        private System.Windows.Forms.DateTimePicker mskDataCompr;
        private System.Windows.Forms.DateTimePicker mskDataUltimaRev;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.PictureBox pictureFoto;
        private System.Windows.Forms.OpenFileDialog dlgFoto;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.TextBox txtKM;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}