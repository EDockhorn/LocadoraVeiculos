namespace PIM_LocadoraVeiculos
{
    partial class frmConsultaVeic
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaVeic));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FILTROS = new System.Windows.Forms.GroupBox();
            this.chkDisponivel = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdbCFP = new System.Windows.Forms.RadioButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvVeic = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.FILTROS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeic)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FILTROS);
            this.groupBox1.Controls.Add(this.lblInfo);
            this.groupBox1.Controls.Add(this.btnSair);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.dgvVeic);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(15, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 420);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONSULTA VEICULOS";
            // 
            // FILTROS
            // 
            this.FILTROS.Controls.Add(this.chkDisponivel);
            this.FILTROS.Controls.Add(this.pictureBox1);
            this.FILTROS.Controls.Add(this.rdbCFP);
            this.FILTROS.Controls.Add(this.txtBuscar);
            this.FILTROS.Controls.Add(this.rdbNome);
            this.FILTROS.Location = new System.Drawing.Point(469, 19);
            this.FILTROS.Name = "FILTROS";
            this.FILTROS.Size = new System.Drawing.Size(294, 113);
            this.FILTROS.TabIndex = 35;
            this.FILTROS.TabStop = false;
            this.FILTROS.Text = "FILTROS";
            // 
            // chkDisponivel
            // 
            this.chkDisponivel.AutoSize = true;
            this.chkDisponivel.Location = new System.Drawing.Point(103, 90);
            this.chkDisponivel.Name = "chkDisponivel";
            this.chkDisponivel.Size = new System.Drawing.Size(115, 17);
            this.chkDisponivel.TabIndex = 37;
            this.chkDisponivel.Text = "Veículo disponível";
            this.chkDisponivel.UseVisualStyleBackColor = true;
            this.chkDisponivel.CheckedChanged += new System.EventHandler(this.chkDisponivel_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PIM_LocadoraVeiculos.Properties.Resources.Magnifying_Glass_icon;
            this.pictureBox1.Location = new System.Drawing.Point(19, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 50);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // rdbCFP
            // 
            this.rdbCFP.AutoSize = true;
            this.rdbCFP.Location = new System.Drawing.Point(205, 19);
            this.rdbCFP.Name = "rdbCFP";
            this.rdbCFP.Size = new System.Drawing.Size(75, 17);
            this.rdbCFP.TabIndex = 34;
            this.rdbCFP.Text = "Fabricante";
            this.rdbCFP.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(103, 49);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(177, 20);
            this.txtBuscar.TabIndex = 32;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp_1);
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Checked = true;
            this.rdbNome.Location = new System.Drawing.Point(103, 19);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(55, 17);
            this.rdbNome.TabIndex = 33;
            this.rdbNome.TabStop = true;
            this.rdbNome.Text = "Marca";
            this.rdbNome.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfo.Location = new System.Drawing.Point(6, 366);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(134, 18);
            this.lblInfo.TabIndex = 29;
            this.lblInfo.Text = "Informativo usuário";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSair.BackgroundImage = global::PIM_LocadoraVeiculos.Properties.Resources.exit_icon_3;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSair.Location = new System.Drawing.Point(699, 351);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(64, 51);
            this.btnSair.TabIndex = 28;
            this.toolTip1.SetToolTip(this.btnSair, "Sair");
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditar.BackgroundImage = global::PIM_LocadoraVeiculos.Properties.Resources.editarcliente;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnEditar.Location = new System.Drawing.Point(556, 351);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(69, 51);
            this.btnEditar.TabIndex = 27;
            this.toolTip1.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // dgvVeic
            // 
            this.dgvVeic.AllowUserToAddRows = false;
            this.dgvVeic.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvVeic.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVeic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVeic.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvVeic.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvVeic.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvVeic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVeic.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVeic.Location = new System.Drawing.Point(6, 155);
            this.dgvVeic.MultiSelect = false;
            this.dgvVeic.Name = "dgvVeic";
            this.dgvVeic.ReadOnly = true;
            this.dgvVeic.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVeic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVeic.Size = new System.Drawing.Size(757, 180);
            this.dgvVeic.TabIndex = 0;
            this.dgvVeic.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVeic_CellContentClick_1);
            this.dgvVeic.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVeic_CellContentDoubleClick_1);
            this.dgvVeic.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVeic_RowHeaderMouseClick_1);
            this.dgvVeic.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVeic_RowHeaderMouseDoubleClick_1);
            // 
            // frmConsultaVeic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(806, 471);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaVeic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Veículos Cadastrados";
            this.Load += new System.EventHandler(this.frmConsultaVeic_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.FILTROS.ResumeLayout(false);
            this.FILTROS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox FILTROS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rdbCFP;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.DataGridView dgvVeic;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.CheckBox chkDisponivel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}