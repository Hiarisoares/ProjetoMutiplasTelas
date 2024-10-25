namespace AplicativoComMultiplasJanelas
{
    public partial class FormNovoFornecedor : Form
    {
        public string NomeEmpresa { get { return textBoxNomeEmpresa.Text; } }
        public string NomeContato { get { return textBoxNomeContato.Text; } }
        public string CNPJ { get { return textBoxCNPJ.Text; } }
        public string Telefone { get { return textBoxTelefone.Text; } }
        public string Email { get { return textBoxEmail.Text; } }

        public string Endereco
        {
            get
            {
                string endereco = "";
                endereco += $"{textBoxEnderecoLogradouro.Text}, ";
                endereco += $"{textBoxEnderecoNumero.Text}, ";
                endereco += $"({textBoxEnderecoComplemento.Text}), ";
                endereco += $"{textBoxEnderecoCidade.Text} - {textBoxEnderecoEstado.Text}, ";
                endereco += $"CEP: {textBoxEnderecoCEP.Text}";
                return endereco;
            }
        }

        public FormNovoFornecedor()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
