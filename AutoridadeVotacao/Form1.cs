using VotingSystem.Voting;

namespace AutoridadeVotacao
{
    public partial class FrmAutoridadeVotacao : Form
    {
        public FrmAutoridadeVotacao()
        {
            InitializeComponent();
            lblStatus.Text = "Pronto.";
        }

        private void FrmAutoridadeVotacao_Load(object sender, EventArgs e)
        {

        }

        private async void btnCarregarCandidatos_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Text = "A carregar candidatos...";

                var response = await VotacaoApi.Client.GetCandidatesAsync(new GetCandidatesRequest());

                lstCandidatos.DataSource = response.Candidates;
                lstCandidatos.DisplayMember = "Name";
                lstCandidatos.ValueMember = "Id";

                lblStatus.Text = "Candidatos carregados.";
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Erro ao obter candidatos.";
                MessageBox.Show("Erro ao obter candidatos: " + ex.Message);
            }
        }

        private async void btnVotar_Click(object sender, EventArgs e)
        {
            var cred = txtCredencial.Text?.Trim();
            if (string.IsNullOrWhiteSpace(cred))
            {
                MessageBox.Show("Introduza a credencial de voto.");
                return;
            }

            if (lstCandidatos.SelectedItem is not Candidate cand)
            {
                MessageBox.Show("Selecione um candidato.");
                return;
            }

            try
            {
                lblStatus.Text = "A submeter voto...";

                var request = new VoteRequest
                {
                    VotingCredential = cred,
                    CandidateId = cand.Id
                };

                var response = await VotacaoApi.Client.VoteAsync(request);

                if (response.Success)
                    lblStatus.Text = "Voto registado com sucesso.";
                else
                    lblStatus.Text = "Voto recusado: " + response.Message;

                MessageBox.Show($"Sucesso: {response.Success}\nMensagem: {response.Message}");
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Erro ao submeter voto.";
                MessageBox.Show("Erro ao votar: " + ex.Message);
            }
        }

        private async void btnVerResultados_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Text = "A obter resultados...";

                var response = await VotacaoApi.Client.GetResultsAsync(new GetResultsRequest());

                gridResultados.AutoGenerateColumns = true;

                gridResultados.DataSource = response.Results;

                lblStatus.Text = "Resultados atualizados.";
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Erro ao obter resultados.";
                MessageBox.Show("Erro ao obter resultados: " + ex.Message);
            }
        }



    }
}
