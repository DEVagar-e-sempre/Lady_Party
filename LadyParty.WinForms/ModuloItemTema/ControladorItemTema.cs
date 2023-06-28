using LadyParty.Dominio.ModuloItemTema;
using LadyParty.Infra.ModuloItemTema;
using LadyParty.WinForms.ModuloTema;

namespace LadyParty.WinForms.ModuloItemTema
{
    public class ControladorItemTema : ControladorBase
    {
        private TelaCadastroItemForm telaCadItem;
        private RepositorioItemTemaSQL repItem;
        private ItemTemaUserControl tabelaItem;
        public override string ObterTipoCadastro => "Item de Tema";

        public ControladorItemTema(RepositorioItemTemaSQL repItem)
        { 
            this.repItem = repItem;
        }

        public override void Editar() { }

        public override void Excluir() 
        {
            ItemTema itemSelec = ObterItemSelecionado();

            if (itemSelec == null)
            {
                MessageBox.Show($"Selecione um Item primeiro!",
                    "Exclusão de Item",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o Item {itemSelec.descricao}?",
                    "Exclusão de Item",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (opcaoEscolhida == DialogResult.OK)
                {
                    repItem.Excluir(itemSelec);

                    CarregarItens();
                }
            }
        }

        public override void Inserir()
        {
            telaCadItem = new TelaCadastroItemForm(repItem);

            telaCadItem.DefinirID(repItem.Contador);

            DialogResult opcaoEscolhida = telaCadItem.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                ItemTema item = telaCadItem.Item;

                repItem.Inserir(item);

                MessageBox.Show("Item Gravado com sucesso!");

                CarregarItens();
            }
        }

        private ItemTema ObterItemSelecionado()
        {
            int id = tabelaItem.ObterIdSelecionado();

            return repItem.SelecionarPorId(id);
        }

        private void CarregarItens()
        {

            List<ItemTema> listaItens = repItem.SelecionarTodos();//esta pegando a lista de Contatos e jogando para o contatos

            tabelaItem.AtualizarRegistros(listaItens);//vai passar a lista para o listBox por meio desse metodo 
        }

        public override UserControl ObterListagem()
        {
            if (tabelaItem == null)
            {
                tabelaItem = new ItemTemaUserControl();
            }

            CarregarItens();

            return tabelaItem;
        }
    }
}
