namespace LadyParty.WinForms.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract string ToolTipInserir { get; }

        public abstract string ToolTipEditar { get; }

        public abstract string ToolTipExcluir { get; }
        public virtual string ToolTipFiltrar { get; }

        public abstract string ObterTipoCadastro { get; }


        public virtual bool InserirHabilitado => true;
        public virtual bool EditarHabilitado => true;
        public virtual bool ExcluirHabilitado => true;

        public virtual bool FiltrarHabilitado => false;
        public virtual bool AdicionarItensHabilitado => false;
        public virtual bool ConcluirItensHabilitado => false;

        public virtual void Filtrar() { }
        public virtual void ItensConcluidos() { }
        public virtual void AddItem() { }
        public abstract void Inserir();
        public abstract void Editar();
        public abstract void Excluir();
        public abstract UserControl ObterListagem();

    }
}
