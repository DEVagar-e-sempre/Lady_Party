using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LadyParty.WinForms.ModuloCliente
{
    public class Cliente : EntidadeBase<Cliente>
    {
        public string nomeCliente { get; set; }
        public string telefoneCliente { get; set; }
        public bool ehEspecial { get; set; }
        public bool temFestaMarcada { get; set; }
        public DateTime dataDeCadastro { get; set; }

        public Cliente(string nomeCliente, string telefoneCliente, bool ehEspecial)
        {
            this.nomeCliente = nomeCliente;
            this.telefoneCliente = telefoneCliente;
            this.ehEspecial = ehEspecial;
            this.dataDeCadastro = DateTime.Now.Date;
        }
        public override void AtualizarInformacoes(Cliente registroAtualizado)
        {
            this.nomeCliente = registroAtualizado.nomeCliente;
            this.telefoneCliente = registroAtualizado.telefoneCliente;
        }

        public void TornarEspecial()
        {

        }
        public void MarcarStatusFesta()
        {

        }
        public void DesmarcarStatusFesta()
        {

        }
        public override string[] Validar() //precisa retornar uma string pelo base
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(nomeCliente))
                erros.Add($"O campo 'nome cliente' é obrigatório.");

            if (string.IsNullOrEmpty(telefoneCliente))
                erros.Add($"O campo 'numero de celular' é obrigatório.");

            return erros.ToArray();
        }
    }
}
