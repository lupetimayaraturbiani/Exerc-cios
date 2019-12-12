using System;
using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class EventoRepository : RepositoryBase
    {
        private const string PATH = "Database/Evento.csv";

        public EventoRepository()
        {
            if (!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Evento evento)
        {
            var quantidadeEventos = File.ReadAllLines(PATH).Length;
            evento.Id = (ulong) ++quantidadeEventos;
            var linha = new string[] {PrepararEventoCSV(evento)};
            File.AppendAllLines(PATH, linha);

            return true;
        }

        public List<Evento> ObterTodosPorCliente(string emailCliente)
        {
            var eventos = ObterTodos();
            List<Evento> eventosCliente = new List<Evento>();
            
            foreach (var evento in eventos)
            {
                if (evento.Cliente.Email.Equals(emailCliente))
                {
                    eventosCliente.Add(evento);
                }
            }
            return eventosCliente;
        }

        //CONTINUAR MÉTODO OBTER TODOS
        // TERMINAR REPOSITORY

        public List<Evento> ObterTodos()
        {
            var linhas = File.ReadAllLines(PATH);
            List<Evento> eventos = new List<Evento>();

            foreach (var linha in linhas)
            {
                Evento evento = new Evento();
                evento.Id = ulong.Parse(ExtrairValorDoCampo("id", linha));
                evento.Status = uint.Parse(ExtrairValorDoCampo("status", linha));
                evento.Cliente.Nome = ExtrairValorDoCampo("cliente_nome", linha);
                evento.Cliente.Email = ExtrairValorDoCampo("cliente_email", linha);
                evento.Cliente.Telefone = ExtrairValorDoCampo("cliente_telefone", linha);
                evento.NomeEvento = ExtrairValorDoCampo("nome_evento", linha);
                evento.TiposEvento.Nome = ExtrairValorDoCampo("tipos_evento_nome", linha);
                evento.TiposEvento.Preco = double.Parse(ExtrairValorDoCampo("tipos_evento_preco", linha));
                evento.ServicosAdicionais.Nome = ExtrairValorDoCampo("servicos_adicionais_nome", linha);
                evento.ServicosAdicionais.Preco = double.Parse(ExtrairValorDoCampo("servicos_adicionais_preco", linha));
                evento.DataEvento = DateTime.Parse(ExtrairValorDoCampo("data_evento", linha));
                evento.Horario = DateTime.Parse(ExtrairValorDoCampo("horario", linha));
                evento.Pagamento = ExtrairValorDoCampo("pagamento", linha);
                evento.Descricao = ExtrairValorDoCampo("descricao", linha);
                evento.PrecoTotal = double.Parse(ExtrairValorDoCampo("preco_total", linha));

                eventos.Add(evento);
            }

            return eventos;
        }

        public Evento ObterPor(ulong id)
        {
            var eventosTotais = ObterTodos();
            foreach (var evento in eventosTotais)
            {
                if (id.Equals(evento.Id))
                {
                    return evento;
                }
            }
            return null;
        }

        public bool Atualizar(Evento evento)
        {
            var eventosTotais = File.ReadAllLines(PATH);
            var eventoCSV = PrepararEventoCSV(evento);
            var linhaEvento = -1;
            var resultado = false;

            for (int i = 0; i < eventosTotais.Length; i++)
            {
                var idConvertido = ulong.Parse(ExtrairValorDoCampo("id", eventosTotais[i]));
                if (evento.Id.Equals(idConvertido))
                {
                    linhaEvento = i;
                    resultado = true;
                    break;
                }
                
            }

            if (resultado)
            {
                eventosTotais[linhaEvento] = eventoCSV;
                File.WriteAllLines(PATH, eventosTotais);
            }
            return resultado;
        }

        private string PrepararEventoCSV(Evento evento)
        {
            Cliente c = evento.Cliente;
            ServicosAdicionais sa = evento.ServicosAdicionais;
            TiposEvento te = evento.TiposEvento;

            return $"id={evento.Id};status={evento.Status};cliente_nome={c.Nome};cliente_email={c.Email};cliente_telefone={c.Telefone};nome_evento={evento.NomeEvento};tipos_evento_nome={te.Nome};tipos_evento_preco={te.Preco};servicos_adicionais_nome={sa.Nome};servicos_adicionais_preco={sa.Preco};data_evento={evento.DataEvento};horario={evento.Horario};pagamento={evento.Pagamento};descricao={evento.Descricao};preco_total={evento.PrecoTotal};";
        }

    }
}