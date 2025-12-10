using VotingSystem;

namespace AutoridadeRegisto
{
    public partial class FrmAutoridadeRegisto : Form
    {
        public FrmAutoridadeRegisto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private async void btnObterCredencial_Click(object sender, EventArgs e)
        {
            Reset();

            var ccNumber = txtCartaoCidadao.Text?.Trim();
            if (string.IsNullOrWhiteSpace(ccNumber))
            {
                MessageBox.Show("Introduza o número do Cartão de Cidadão.");
                return;
            }

            try
            {
                lblStatus.Text = "A contactar serviço de registo...";

                var request = new VoterRequest
                {
                    CitizenCardNumber = ccNumber
                };

                var response = await RegistoApi.Client.IssueVotingCredentialAsync(request);

                // primeiro, mostra o que veio do serviço
                bool elegivel = response.IsEligible;
                string cred = response.VotingCredential ?? string.Empty;

                // se a credencial for inválida, forçamos "não elegível"
                if (cred.StartsWith("INVALID", StringComparison.OrdinalIgnoreCase))
                {
                    elegivel = false;
                }

                lblElegivelValor.Text = elegivel ? "Sim" : "Não";
                txtCredencial.Text = cred;

                if (!elegivel)
                {
                    Invalido();
                }
                else
                {
                    Valido();
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Erro ao obter credencial.";
                MessageBox.Show("Erro ao contactar o serviço: " + ex.Message);
            }
        }

        private void Valido()
        {
            lblStatus.Text = "Credencial válida obtida com sucesso.";
            lblStatus.ForeColor = Color.Green;
            lblElegivelValor.ForeColor = Color.Green;
        }
        private void Invalido()
        {
            lblStatus.Text = "Credencial inválida. Eleitor não elegível.";
            lblStatus.ForeColor = Color.Red;
            lblElegivelValor.ForeColor = Color.Red;
        }

        private void Reset()
        {
            lblElegivelValor.Text = "N/D";
            lblStatus.Text = "Pronto";
            lblStatus.ForeColor = Color.Black;
            lblElegivelValor.ForeColor = Color.Black;
        }


    }
}
