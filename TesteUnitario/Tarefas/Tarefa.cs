using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace TesteUnitario.Tarefas
{
    public class Tarefa
    {
        public Tarefa(string titulo, string descricao, DateTime dataVencimento, int prioridade, List<string> etiquetas)
        {
            Titulo = titulo;
            Descricao = descricao;
            DataVencimento = dataVencimento;
            Prioridade = prioridade;
            Etiquetas = etiquetas;
        }

        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataVencimento { get; set; }
        public int Prioridade { get; set; }
        public List<string> Etiquetas { get; set; } = new List<string>();
    }
}
