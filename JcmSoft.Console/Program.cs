// Top level statement program.cs

using JcmSoft.Domain.Entities;
using JcmSoft.EFCore;

using (AppDbContext context = new AppDbContext())
{
    context.Database.EnsureDeleted();
    Console.WriteLine("Criando o banco de dados... \n");
    context.Database.EnsureCreated();

    Console.WriteLine("Criando um departamento...\n");
    CriarDepartamento(context);
    Console.WriteLine("Departamento criado...\n");
}
Console.ReadKey();

void CriarDepartamento(AppDbContext context)
{
    var departamento = new Departamento
    {
        Nome = "Desenvolvimento",
        Descricao = "Desenvolvimento de projetos"
    };
    context.Departamentos.Add(departamento);
    //context.Add(departamento);
    context.SaveChanges();
}