// Top level statement program.cs
using JcmSoft.Domain.Entities;
using JcmSoft.Domain.Enums;
using JcmSoft.EFCore;
using JcmSoft.EFCore.Funcoes;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using var context = new AppDbContext();

var funcionarios = await context.Funcionarios.FromSqlRaw("EXEC usp_ListarFuncionariosPorDepartamento {0}", 1).ToListAsync();

foreach (var f in funcionarios)
{
    Console.WriteLine(f);
}

var funcionarios2 = await context.Funcionarios.FromSql($"EXEC usp_ListarFuncionariosPorDepartamento {2}").ToListAsync();

Console.WriteLine();
Console.WriteLine();
foreach (var f in funcionarios2)
{
    Console.WriteLine(f);
}

var dataInicio = new DateOnly(2026, 01, 01);
var dataFim = new DateOnly(2026, 08, 01);

var parameters = new[]
{
    new SqlParameter("@DataInicio",dataInicio),
    new SqlParameter("@DataFim",dataFim)
};

var funcionariosContratacao = await context.Funcionarios.FromSqlRaw("usp_FuncionariosContratadosPorPeriodo @DataInicio, @DataFim", parameters).ToListAsync();

Console.WriteLine();
Console.WriteLine();
foreach (var f in funcionariosContratacao)
{
    Console.WriteLine(f);
}

var funcionariosDepartamento = await context.FuncionariosDepartamentosViews.OrderBy(f => f.Salario).ToListAsync();

Console.WriteLine();
Console.WriteLine();
foreach (var f in funcionariosDepartamento)
{
    Console.WriteLine(f);
}

// exercicio de função escalar
var funcionariosEscalar = await context.Funcionarios.Select(f => new
{
    f.Nome,
    f.DataContratacao,
    AnosDeServico = FuncoesSql.CalcularAnosDeServico(f.DataContratacao)
}).OrderByDescending(f => f.AnosDeServico).ToListAsync();

Console.WriteLine();
Console.WriteLine();
foreach (var f in funcionariosEscalar)
{
    Console.WriteLine(f.Nome + " - " + f.DataContratacao + " - Anos de servico: " + f.AnosDeServico);
}

// exercicio funções de tabela
//var dataConsulta = new DateTime(2026, 01, 01);

//var projetosAtivos = await context.ProjetosAtivosApos(dataConsulta).OrderBy(p => p.DataInico).ToListAsync();

//Console.WriteLine();
//Console.WriteLine();
//foreach (var p in projetosAtivos)
//{
//    Console.WriteLine(p);
//}

// exercicios sequencias
for (int i = 0; i < 3; i++)
{
    var projeto = new Projeto
    {
        Nome = $"Projeto Alpha {i + 1}",
        Descricao = $"Descrição detalhada do Projeto Alpha {i + 1}",
        Orcamento = 50000.00m + (i * 10000),
        DataInico = DateTime.Now.AddDays(i * 30),
        DataAtualizacao = DateTime.Now.AddDays(i * 30),
        DataFim = DateTime.Now.AddDays(i * 30 + 120),
        Status = StatusProjeto.Iniciado,
        ClienteId = 5
    };
    context.Projetos.Add(projeto);
}

await context.SaveChangesAsync();

Console.WriteLine("projetos gerados: ");

var projetosalvos = await context.Projetos.OrderBy(p => p.NumeroOrdemServico).ToListAsync();

foreach (var p in projetosalvos)
{
    Console.Write("ID: " + p.ProjetoId);
    Console.WriteLine(" | OS: " + p.NumeroOrdemServico + " | Nome: " + p.Nome);
}