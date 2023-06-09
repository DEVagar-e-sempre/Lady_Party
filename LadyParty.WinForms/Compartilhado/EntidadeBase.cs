namespace LadyParty.WinForms.Compartilhado
{
    public abstract class EntidadeBase<T>
    {
        public int id;

        public abstract void Validar();

        public abstract void AtualizarInformacoes(T entidade);
    }
}
