namespace JogoGourmet_Warllison
{
    public partial class Principal : Form
    {
        string[] tipoPratoArray = { "massa", "Bolo de chocolate" };
        int COUNT = 0;
        const string PERGUNTAR_TIPO_PRATO = "O prato que você pensou é";
        const string RESPOSTA_CERTA = "Acertei de novo!";
        const string PERGUNTA_PRATO_PENSADO = "Qual prato você pensou?";

        public Principal()
        {
            InitializeComponent();
        }

        private void BtnSetPratoPensado(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_informaPratoPensado.Text))
            {
                RetornaInicio();
                return;
            }


            List<string> values = tipoPratoArray.ToList();
            values.Add(_informaPratoPensado.Text);
            tipoPratoArray = values.ToArray();
            RetornaInicio();
        }

        private void BtnOk(object sender, EventArgs e)
        {
            Button? btnMensagem = sender as Button;

            if (btnMensagem.Text == "OK")
            {
                _okPrincipalButton.Visible = false;

                ImprimeTextLabel($"{PERGUNTAR_TIPO_PRATO} {tipoPratoArray[COUNT]}?");
                COUNT++;

                SimButtonInitialize();
                NaoButtonInitialize();
            }
        }

        private void BtnSim(object sender, EventArgs e)
        {
            Button? btnMensagem = sender as Button;

            if (btnMensagem.Text == "Sim")
            {
                ImprimeTextLabel(RESPOSTA_CERTA);
                _simButton.Visible = false;
                _naoButton.Visible = false;
            }
        }
        private void BtnNao(object sender, EventArgs e)
        {
            Button? btnMensagem = sender as Button;

            if (COUNT < tipoPratoArray.Length && btnMensagem.Text == "Não")
            {
                ImprimeTextLabel($"{PERGUNTAR_TIPO_PRATO} {tipoPratoArray[COUNT]}?");
                COUNT++;
            }
            else
            {
                ImprimeTextLabel(PERGUNTA_PRATO_PENSADO);

                _simButton.Visible = false;
                _naoButton.Visible = false;

                TextBoxInicialize();
                SetPratoButtonInitialize();
                CancelarButtonInitialize();
            }
        }

        private void BtnCancelar(object sender, EventArgs e)
        {
            RetornaInicio();
        }
        private void ImprimeTextLabel(string text)
        {
            string textlabel = $"{text}";
            LabelInicialize(textlabel);
        }

        private void RetornaInicio()
        {
            _simButton.Visible = false;
            _naoButton.Visible = false;
            _setPratoButton.Visible = false;
            _informaPratoPensado.Visible = false;
            _cancelarButton.Visible = false;
            _principalLabel.Text = "";
            COUNT = 0;

            InitializeComponent();
        }
    }
}