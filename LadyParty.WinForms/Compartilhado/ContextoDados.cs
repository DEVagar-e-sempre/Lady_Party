using LadyParty.WinForms.ModuloAluguel;
using LadyParty.WinForms.ModuloCliente;
using LadyParty.WinForms.ModuloTema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using LadyParty.WinForms.ModuloItemTema;

namespace LadyParty.WinForms.Compartilhado
{
    public class ContextoDados
    {
        public const string NOME_ARQUIVO = "LadyParty.json";

        public List<Cliente> Clientes;

        public List<Tema> Temas;

        public List<ItemTema> ItemTemas;

        public List<Aluguel> Alugueis;

        public int ContadorClientes;

        public int ContadorTemas;

        public int ContadorItemTemas;

        public int ContadorAlugueis;

        public ContextoDados()
        {
            Clientes = new List<Cliente>();
            Temas = new List<Tema>();
            ItemTemas = new List<ItemTema>();
            Alugueis = new List<Aluguel>();

            ContadorClientes = 0;
            ContadorTemas = 0;
            ContadorItemTemas = 0;
            ContadorAlugueis = 0;

        }

        public void PreencherRepositorios(RepositorioArquivoCliente repCliente, RepositorioArquivoTema repTema, RepositorioArquivoItemTema repItemTema, RepositorioArquivoAluguel repAluguel)
        {

            repCliente.AdicionarRegistroEContador(Clientes, ContadorClientes); 
            repTema.AdicionarRegistroEContador(Temas, ContadorTemas);
            repItemTema.AdicionarRegistroEContador(ItemTemas, ContadorItemTemas);
            repAluguel.AdicionarRegistroEContador(Alugueis, ContadorAlugueis);
 
        }

        public void GravarEmJson(RepositorioArquivoCliente repCliente, RepositorioArquivoTema repTema, RepositorioArquivoItemTema repItemTema, RepositorioArquivoAluguel repAluguel) {
            this.Clientes = repCliente.SelecionarTodos();
            this.Temas = repTema.SelecionarTodos();
            this.ItemTemas = repItemTema.SelecionarTodos();
            this.Alugueis = repAluguel.SelecionarTodos();

            this.ContadorClientes = repCliente.Contador;
            this.ContadorTemas = repTema.Contador;
            this.ContadorItemTemas = repItemTema.Contador;
            this.ContadorAlugueis = repAluguel.Contador;

            string registrosJson = JsonSerializer.Serialize(this, ObterConfiguracoes());

            File.WriteAllText(NOME_ARQUIVO, registrosJson);
        }

        public void CarregarDadosJson()
        {
            if (File.Exists(NOME_ARQUIVO))
            {
                string arquivoJson = File.ReadAllText(NOME_ARQUIVO);
                if(!String.IsNullOrEmpty(arquivoJson))
                {
                    ContextoDados contextoDados = JsonSerializer.Deserialize<ContextoDados>(arquivoJson, ObterConfiguracoes());
                    this.Clientes = contextoDados.Clientes;
                    this.Temas = contextoDados.Temas;
                    this.ItemTemas = contextoDados.ItemTemas;
                    this.Alugueis = contextoDados.Alugueis;

                    this.ContadorClientes = contextoDados.ContadorClientes;
                    this.ContadorTemas = contextoDados.ContadorTemas;
                    this.ContadorItemTemas = contextoDados.ContadorItemTemas;
                    this.ContadorAlugueis = contextoDados.ContadorAlugueis;

                }
            }
        }

        private JsonSerializerOptions ObterConfiguracoes()
        {
            JsonSerializerOptions opcoes = new JsonSerializerOptions();
            opcoes.IncludeFields = true;
            opcoes.WriteIndented = true;
            opcoes.ReferenceHandler = ReferenceHandler.Preserve;

            return opcoes;
        }
    }

}
