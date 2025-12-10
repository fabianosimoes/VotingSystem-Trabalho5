namespace AutoridadeVotacao
{
    partial class FrmAutoridadeVotacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutoridadeVotacao));
            label1 = new Label();
            lblStatus = new Label();
            groupBox1 = new GroupBox();
            txtCredencial = new TextBox();
            lstCandidatos = new ListBox();
            btnVotar = new Button();
            btnCarregarCandidatos = new Button();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox3 = new GroupBox();
            gridResultados = new DataGridView();
            btnVerResultados = new Button();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridResultados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 559);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Status";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(82, 559);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(43, 15);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Pronto";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCredencial);
            groupBox1.Controls.Add(lstCandidatos);
            groupBox1.Controls.Add(btnVotar);
            groupBox1.Controls.Add(btnCarregarCandidatos);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(15, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(601, 239);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Credencial e Voto";
            // 
            // txtCredencial
            // 
            txtCredencial.Location = new Point(309, 105);
            txtCredencial.Name = "txtCredencial";
            txtCredencial.Size = new Size(175, 23);
            txtCredencial.TabIndex = 16;
            // 
            // lstCandidatos
            // 
            lstCandidatos.FormattingEnabled = true;
            lstCandidatos.Location = new Point(22, 105);
            lstCandidatos.Name = "lstCandidatos";
            lstCandidatos.Size = new Size(247, 94);
            lstCandidatos.TabIndex = 15;
            // 
            // btnVotar
            // 
            btnVotar.Location = new Point(309, 163);
            btnVotar.Name = "btnVotar";
            btnVotar.Size = new Size(175, 36);
            btnVotar.TabIndex = 14;
            btnVotar.Text = "Votar";
            btnVotar.UseVisualStyleBackColor = true;
            btnVotar.Click += btnVotar_Click;
            // 
            // btnCarregarCandidatos
            // 
            btnCarregarCandidatos.Location = new Point(22, 24);
            btnCarregarCandidatos.Name = "btnCarregarCandidatos";
            btnCarregarCandidatos.Size = new Size(175, 36);
            btnCarregarCandidatos.TabIndex = 13;
            btnCarregarCandidatos.Text = "Carregar Candidatos";
            btnCarregarCandidatos.UseVisualStyleBackColor = true;
            btnCarregarCandidatos.Click += btnCarregarCandidatos_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 82);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 12;
            label5.Text = "Lista de Candidatos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(309, 82);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 11;
            label3.Text = "Credencial:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 559);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 0;
            label2.Text = "Status";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(332, 35);
            label8.Name = "label8";
            label8.Size = new Size(110, 15);
            label8.TabIndex = 12;
            label8.Text = "Lista de Candidatos";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 35);
            label9.Name = "label9";
            label9.Size = new Size(66, 15);
            label9.TabIndex = 11;
            label9.Text = "Credencial:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(gridResultados);
            groupBox3.Controls.Add(btnVerResultados);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(15, 260);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(601, 296);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resultados";
            // 
            // gridResultados
            // 
            gridResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridResultados.Location = new Point(22, 116);
            gridResultados.Name = "gridResultados";
            gridResultados.Size = new Size(557, 152);
            gridResultados.TabIndex = 15;
            // 
            // btnVerResultados
            // 
            btnVerResultados.Location = new Point(22, 29);
            btnVerResultados.Name = "btnVerResultados";
            btnVerResultados.Size = new Size(155, 36);
            btnVerResultados.TabIndex = 13;
            btnVerResultados.Text = "Consultar Resultados";
            btnVerResultados.UseVisualStyleBackColor = true;
            btnVerResultados.Click += btnVerResultados_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 93);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 11;
            label4.Text = "Resultados";
            // 
            // FrmAutoridadeVotacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 590);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(lblStatus);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmAutoridadeVotacao";
            Text = "Autoridade Votação";
            Load += FrmAutoridadeVotacao_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblStatus;
        private GroupBox groupBox1;
        private TextBox txtCredencial;
        private ListBox lstCandidatos;
        private Button btnVotar;
        private Button btnCarregarCandidatos;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label8;
        private Label label9;
        private GroupBox groupBox3;
        private DataGridView gridResultados;
        private Button btnVerResultados;
        private Label label4;
    }
}
