namespace PIM_LocadoraVeiculos
{
    partial class frmFormaPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormaPagamento));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtParcelas = new System.Windows.Forms.NumericUpDown();
            this.txtValorParcelado = new System.Windows.Forms.TextBox();
            this.rdbDinheiro = new System.Windows.Forms.RadioButton();
            this.rdbCredito = new System.Windows.Forms.RadioButton();
            this.rdbDebito = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtValorTotal);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(12, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 260);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Condições de Pagamento:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtParcelas);
            this.groupBox1.Controls.Add(this.txtValorParcelado);
            this.groupBox1.Controls.Add(this.rdbDinheiro);
            this.groupBox1.Controls.Add(this.rdbCredito);
            this.groupBox1.Controls.Add(this.rdbDebito);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 139);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formas de Pagamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 9.5F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(15, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "Parcelas";
            // 
            // txtParcelas
            // 
            this.txtParcelas.Enabled = false;
            this.txtParcelas.Location = new System.Drawing.Point(21, 92);
            this.txtParcelas.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.txtParcelas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtParcelas.Name = "txtParcelas";
            this.txtParcelas.Size = new System.Drawing.Size(72, 21);
            this.txtParcelas.TabIndex = 45;
            this.txtParcelas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtParcelas.ValueChanged += new System.EventHandler(this.txtParcelas_ValueChanged);
            // 
            // txtValorParcelado
            // 
            this.txtValorParcelado.Enabled = false;
            this.txtValorParcelado.Location = new System.Drawing.Point(183, 92);
            this.txtValorParcelado.Name = "txtValorParcelado";
            this.txtValorParcelado.Size = new System.Drawing.Size(77, 21);
            this.txtValorParcelado.TabIndex = 46;
            this.txtValorParcelado.Text = "0.00";
            // 
            // rdbDinheiro
            // 
            this.rdbDinheiro.AutoSize = true;
            this.rdbDinheiro.Location = new System.Drawing.Point(21, 23);
            this.rdbDinheiro.Name = "rdbDinheiro";
            this.rdbDinheiro.Size = new System.Drawing.Size(72, 19);
            this.rdbDinheiro.TabIndex = 33;
            this.rdbDinheiro.TabStop = true;
            this.rdbDinheiro.Text = "Dinheiro";
            this.rdbDinheiro.UseVisualStyleBackColor = true;
            this.rdbDinheiro.CheckedChanged += new System.EventHandler(this.rdbDinheiro_CheckedChanged);
            // 
            // rdbCredito
            // 
            this.rdbCredito.AutoSize = true;
            this.rdbCredito.Location = new System.Drawing.Point(196, 23);
            this.rdbCredito.Name = "rdbCredito";
            this.rdbCredito.Size = new System.Drawing.Size(64, 19);
            this.rdbCredito.TabIndex = 35;
            this.rdbCredito.TabStop = true;
            this.rdbCredito.Text = "Crédito";
            this.rdbCredito.UseVisualStyleBackColor = true;
            this.rdbCredito.CheckedChanged += new System.EventHandler(this.rdbCredito_CheckedChanged);
            // 
            // rdbDebito
            // 
            this.rdbDebito.AutoSize = true;
            this.rdbDebito.Location = new System.Drawing.Point(119, 23);
            this.rdbDebito.Name = "rdbDebito";
            this.rdbDebito.Size = new System.Drawing.Size(61, 19);
            this.rdbDebito.TabIndex = 34;
            this.rdbDebito.TabStop = true;
            this.rdbDebito.Text = "Débito";
            this.rdbDebito.UseVisualStyleBackColor = true;
            this.rdbDebito.CheckedChanged += new System.EventHandler(this.rdbDebito_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 9.5F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(18, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Valor total a ser pago:";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(208, 51);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(106, 21);
            this.txtValorTotal.TabIndex = 32;
            this.txtValorTotal.Text = "0.00";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSair.BackgroundImage = global::PIM_LocadoraVeiculos.Properties.Resources.exit_icon_3;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSair.Location = new System.Drawing.Point(330, 343);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(64, 51);
            this.btnSair.TabIndex = 47;
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
            this.btnSalvar.Location = new System.Drawing.Point(207, 343);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(69, 51);
            this.btnSalvar.TabIndex = 46;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar");
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(406, 406);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFormaPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formas de Pagamento";
            this.Load += new System.EventHandler(this.frmFormaPagamento_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtParcelas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtParcelas;
        private System.Windows.Forms.TextBox txtValorParcelado;
        private System.Windows.Forms.RadioButton rdbDinheiro;
        private System.Windows.Forms.RadioButton rdbCredito;
        private System.Windows.Forms.RadioButton rdbDebito;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}