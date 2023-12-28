using System;
using System.Collections.Generic;
using TesteUnitario.Tarefas;
using Xunit;

namespace TesteUnitario.Tests.Tarefas
{
    public class TarefaTest
    {
        [Fact]
        public void CriarTarefaComSucesso()
        {
            // Estrutura Arrange, Act e Assert (AAA) 

            #region Arrange

            // Arrange (preparar)
            // Aqui configura o estado necessário para o teste.
            // Isso pode incluir a criação de instâncias de objetos,
            // configuração de variáveis, chamadas a métodos necessários e
            // preparação do ambiente para a execução do teste.

            var titulo = "Teste";
            var descricao = "Descrição";
            var dataVencimento = DateTime.Now;
            var prioridade = 1;
            var etiquetas = new List<string>() { "Teste1", "Teste2" };
            #endregion

            #region Act

            //Act (agir)
            // Nessa fase, é realizado a ação ou operação que está sendo testada.
            // Isso geralmente envolve a chamada do método ou execução do código que você está testando.
            // Esta é a parte do teste em que você executa a lógica de negócios que deseja avaliar.
            var tarefa = new Tarefa(titulo, descricao, dataVencimento, prioridade, etiquetas);
            #endregion

            #region Assert

            //Assert (Verificar)
            // Nessa fase é verificado se o resultado da ação (fase "Act") é o esperado.
            // Você compara o resultado obtido com o resultado esperado e verifica se o comportamento
            // está de acordo com o que você antecipou. Se os resultados não coincidirem, o teste falhará.
            
            Assert.Equal(titulo, tarefa.Titulo);
            Assert.Equal(descricao, tarefa.Descricao);
            Assert.Equal(dataVencimento, tarefa.DataVencimento);
            Assert.Equal(prioridade, tarefa.Prioridade);
            Assert.Equal(etiquetas.Count, tarefa.Etiquetas.Count);
            #endregion
        }
    }
}
