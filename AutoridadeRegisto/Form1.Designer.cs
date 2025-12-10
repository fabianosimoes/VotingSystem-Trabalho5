namespace AutoridadeRegisto
{
    partial class FrmAutoridadeRegisto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutoridadeRegisto));
            grpDadosEleitor = new GroupBox();
            btnObterCredencial = new Button();
            txtCartaoCidadao = new TextBox();
            label1 = new Label();
            grpResultado = new GroupBox();
            txtCredencial = new TextBox();
            label4 = new Label();
            lblElegivelValor = new Label();
            label2 = new Label();
            label3 = new Label();
            lblStatus = new Label();
            grpDadosEleitor.SuspendLayout();
            grpResultado.SuspendLayout();
            SuspendLayout();
            // 
            // grpDadosEleitor
            // 
            grpDadosEleitor.Controls.Add(btnObterCredencial);
            grpDadosEleitor.Controls.Add(txtCartaoCidadao);
            grpDadosEleitor.Controls.Add(label1);
            grpDadosEleitor.Location = new Point(12, 12);
            grpDadosEleitor.Name = "grpDadosEleitor";
            grpDadosEleitor.Size = new Size(762, 162);
            grpDadosEleitor.TabIndex = 3;
            grpDadosEleitor.TabStop = false;
            grpDadosEleitor.Text = "Dados do Eleitor";
            // 
            // btnObterCredencial
            // 
            btnObterCredencial.Location = new Point(208, 96);
            btnObterCredencial.Name = "btnObterCredencial";
            btnObterCredencial.Size = new Size(151, 42);
            btnObterCredencial.TabIndex = 5;
            btnObterCredencial.Text = "Obter Credencial";
            btnObterCredencial.UseVisualStyleBackColor = true;
            btnObterCredencial.Click += btnObterCredencial_Click;
            // 
            // txtCartaoCidadao
            // 
            txtCartaoCidadao.Location = new Point(183, 44);
            txtCartaoCidadao.Name = "txtCartaoCidadao";
            txtCartaoCidadao.Size = new Size(176, 23);
            txtCartaoCidadao.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 47);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 3;
            label1.Text = "Nº Cartão de Cidadão:";
            // 
            // grpResultado
            // 
            grpResultado.Controls.Add(txtCredencial);
            grpResultado.Controls.Add(label4);
            grpResultado.Controls.Add(lblElegivelValor);
            grpResultado.Controls.Add(label2);
            grpResultado.Location = new Point(12, 189);
            grpResultado.Name = "grpResultado";
            grpResultado.Size = new Size(762, 191);
            grpResultado.TabIndex = 4;
            grpResultado.TabStop = false;
            grpResultado.Text = "Resultado";
            // 
            // txtCredencial
            // 
            txtCredencial.BackColor = Color.White;
            txtCredencial.Location = new Point(52, 81);
            txtCredencial.Multiline = true;
            txtCredencial.Name = "txtCredencial";
            txtCredencial.ReadOnly = true;
            txtCredencial.Size = new Size(326, 92);
            txtCredencial.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 63);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 2;
            label4.Text = "Credencial:";
            // 
            // lblElegivelValor
            // 
            lblElegivelValor.AutoSize = true;
            lblElegivelValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblElegivelValor.Location = new Point(108, 36);
            lblElegivelValor.Name = "lblElegivelValor";
            lblElegivelValor.Size = new Size(30, 15);
            lblElegivelValor.TabIndex = 1;
            lblElegivelValor.Text = "N/D";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 36);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 0;
            label2.Text = "Elegível:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(462, 383);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 5;
            label3.Text = "Status:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(510, 383);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(172, 15);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "A contactar serviço de registo...";
            // 
            // FrmAutoridadeRegisto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStatus);
            Controls.Add(label3);
            Controls.Add(grpResultado);
            Controls.Add(grpDadosEleitor);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmAutoridadeRegisto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Autoridade de Registo";
            Load += Form1_Load;
            grpDadosEleitor.ResumeLayout(false);
            grpDadosEleitor.PerformLayout();
            grpResultado.ResumeLayout(false);
            grpResultado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpDadosEleitor;
        private Button btnObterCredencial;
        private TextBox txtCartaoCidadao;
        private Label label1;
        private GroupBox grpResultado;
        private TextBox txtCredencial;
        private Label label4;
        private Label lblElegivelValor;
        private Label label2;
        private Label label3;
        private Label lblStatus;
    }
}
