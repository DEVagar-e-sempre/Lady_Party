namespace LadyParty.WinForms.Compartilhado
{
    public abstract class EntidadeBase<T>
    {
        public int id { get; set; }

        public abstract string[] Validar();

        public abstract void AtualizarInformacoes(T entidade);

        public abstract bool VerificarRepeticao(T entidade);
    }
}
