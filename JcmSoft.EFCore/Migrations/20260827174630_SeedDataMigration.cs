using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JcmSoft.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteId", "Email", "Nome", "Telefone" },
                values: new object[,]
                {
                    { 1, "contato@gulossw.com", "Gulos Softwares", "1130121001" },
                    { 2, "contato@technova.com", "TechNova Solutions", "1130121002" },
                    { 3, "contato@bompreco.com", "Mercado Bom Preco", "1130121003" },
                    { 4, "contato@hospitalvida.com", "Hospital Vida", "1130121004" },
                    { 5, "contato@transrapida.com", "Transportadora Rapida", "1130121005" },
                    { 6, "contato@escolafuturo.com", "Escola Futuro", "1130121006" },
                    { 7, "contato@restaurantesabor.com", "Restaurante Sabor", "1130121007" },
                    { 8, "contato@horizonte.com", "Construtora Horizonte", "1130121008" },
                    { 9, "contato@movimento.com", "Academia Movimento", "1130121009" },
                    { 10, "contato@bancopaulista.com", "Banco Paulista", "1130121010" },
                    { 11, "contato@clinicacentral.com", "Clinica Central", "1130121011" },
                    { 12, "contato@livrariacultura.com", "Livraria Cultura", "1130121012" },
                    { 13, "contato@petfeliz.com", "Pet Feliz", "1130121013" },
                    { 14, "contato@autocenter.com", "Auto Center Brasil", "1130121014" },
                    { 15, "contato@hotelcentral.com", "Hotel Central", "1130121015" },
                    { 16, "contato@farmaciasaude.com", "Farmacia Saude", "1130121016" },
                    { 17, "contato@comercialandrade.com", "Comercial Andrade", "1130121017" },
                    { 18, "contato@grupoalpha.com", "Grupo Educacional Alpha", "1130121018" },
                    { 19, "contato@metalforte.com", "Industria Metal Forte", "1130121019" },
                    { 20, "contato@logisticaexpress.com", "Logistica Express", "1130121020" }
                });

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "DepartamentoId", "Descricao", "Nome" },
                values: new object[,]
                {
                    { 1, "Desenvolvimento de sistemas e aplicações", "Desenvolvimento" },
                    { 2, "Pesquisa, análise e inovação de produtos", "Pesquisa" },
                    { 3, "Gestão financeira e contábil da empresa", "Financeiro" }
                });

            migrationBuilder.InsertData(
                table: "Funcionarios",
                columns: new[] { "FuncionarioId", "Cargo", "DataContratacao", "DepartamentoId", "Nome", "Salario" },
                values: new object[,]
                {
                    { 1, "Desenvolvedor C#", new DateOnly(2024, 1, 10), 1, "Luiz Almeida", 4500.00m },
                    { 2, "Desenvolvedora Front-end", new DateOnly(2024, 2, 15), 1, "Mariana Souza", 4200.00m },
                    { 3, "Desenvolvedor Back-end", new DateOnly(2024, 3, 20), 1, "Carlos Oliveira", 4800.00m },
                    { 4, "Analista de Sistemas", new DateOnly(2024, 4, 5), 1, "Ana Beatriz Santos", 5000.00m },
                    { 5, "Desenvolvedor Full Stack", new DateOnly(2024, 5, 12), 1, "Rafael Costa", 5500.00m },
                    { 6, "Pesquisadora", new DateOnly(2024, 6, 3), 2, "Juliana Martins", 3800.00m },
                    { 7, "Analista de Pesquisa", new DateOnly(2024, 6, 18), 2, "Pedro Henrique Lima", 4000.00m },
                    { 8, "UX Researcher", new DateOnly(2024, 7, 1), 2, "Camila Ferreira", 4300.00m },
                    { 9, "Cientista de Dados", new DateOnly(2024, 7, 15), 2, "Gabriel Rocha", 5200.00m },
                    { 10, "Analista de Produtos", new DateOnly(2024, 8, 22), 2, "Beatriz Mendes", 4700.00m },
                    { 11, "Analista Financeiro", new DateOnly(2024, 9, 10), 3, "Ricardo Gomes", 4200.00m },
                    { 12, "Contadora", new DateOnly(2024, 9, 20), 3, "Fernanda Alves", 5000.00m },
                    { 13, "Assistente Financeiro", new DateOnly(2024, 10, 1), 3, "Thiago Nunes", 3000.00m },
                    { 14, "Analista de Custos", new DateOnly(2024, 10, 15), 3, "Patricia Ramos", 4500.00m },
                    { 15, "Gerente Financeiro", new DateOnly(2024, 11, 1), 3, "Eduardo Castro", 6500.00m },
                    { 16, "Desenvolvedor C#", new DateOnly(2026, 3, 10), 1, "Lucas Barbosa", 4400.00m },
                    { 17, "Desenvolvedora Mobile", new DateOnly(2026, 6, 15), 1, "Isabela Dias", 4600.00m },
                    { 18, "Analista de Dados", new DateOnly(2026, 3, 1), 2, "Bruno Cardoso", 4900.00m },
                    { 19, "Pesquisadora de Mercado", new DateOnly(2026, 7, 15), 2, "Larissa Teixeira", 4100.00m },
                    { 20, "Analista Financeiro", new DateOnly(2026, 8, 1), 3, "Gustavo Freitas", 4300.00m }
                });

            migrationBuilder.InsertData(
                table: "Projetos",
                columns: new[] { "ProjetoId", "ClienteId", "DataAtualizacao", "DataFim", "DataInico", "Descricao", "Nome", "Orcamento", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2026, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sistema de vendas", "Sistema Gulosos", 15000.00m, 10 },
                    { 2, 2, new DateTime(2026, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Portal corporativo", "Portal TechNova", 28000.00m, 10 },
                    { 3, 3, new DateTime(2026, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sistema de estoque", "Sistema Mercado", 22000.00m, 10 },
                    { 4, 4, new DateTime(2026, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aplicativo hospitalar", "App Hospital Vida", 35000.00m, 10 },
                    { 5, 5, new DateTime(2026, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Controle de entregas", "Sistema de Entregas", 18000.00m, 10 },
                    { 6, 6, new DateTime(2026, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Portal acadêmico", "Portal Escola Futuro", 25000.00m, 10 },
                    { 7, 7, new DateTime(2026, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aplicativo de pedidos", "App Restaurante", 12000.00m, 10 },
                    { 8, 8, new DateTime(2026, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sistema de obras", "Gestao de Obras", 32000.00m, 10 },
                    { 9, 9, new DateTime(2026, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aplicativo fitness", "App Academia", 14000.00m, 10 },
                    { 10, 10, new DateTime(2026, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sistema bancário", "Internet Banking", 50000.00m, 10 },
                    { 11, 11, new DateTime(2026, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sistema de consultas", "Agenda Clinica", 16000.00m, 10 },
                    { 12, 12, new DateTime(2026, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loja virtual", "E-commerce Livraria", 27000.00m, 10 },
                    { 13, 13, new DateTime(2026, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sistema pet shop", "Pet Feliz Online", 13000.00m, 10 },
                    { 14, 14, new DateTime(2026, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agendamento oficina", "Auto Center App", 19000.00m, 10 },
                    { 15, 15, new DateTime(2026, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sistema hoteleiro", "Hotel Central", 24000.00m, 10 },
                    { 16, 16, new DateTime(2026, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "E-commerce farmacia", "Farmacia Online", 21000.00m, 10 },
                    { 17, 17, new DateTime(2026, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sistema comercial", "Comercial Andrade", 17000.00m, 10 },
                    { 18, 18, new DateTime(2026, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Portal educacional", "Portal Alpha", 30000.00m, 10 },
                    { 19, 19, new DateTime(2026, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ERP industrial", "Metal Forte ERP", 45000.00m, 10 },
                    { 20, 20, new DateTime(2026, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sistema logístico", "Logistica Express", 26000.00m, 10 }
                });

            migrationBuilder.InsertData(
                table: "FuncionarioDetalhes",
                columns: new[] { "FuncionarioDetalheId", "CPF", "Celular", "DataNascimento", "EnderecoResidencial", "Escolaridade", "EstadoCivil", "Foto", "FuncionarioId", "Genero", "Nacionalidade" },
                values: new object[,]
                {
                    { 1, "50231231231", "11987654321", new DateTime(1998, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua das Flores, 120", 3, 0, "luiz.jpg", 1, 0, "Brasileiro" },
                    { 2, "50231231232", "11987654322", new DateTime(1997, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua Augusta, 450", 3, 1, "mariana.jpg", 2, 1, "Brasileira" },
                    { 3, "50231231233", "11987654323", new DateTime(1995, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua Vergueiro, 890", 3, 0, "carlos.jpg", 3, 0, "Brasileiro" },
                    { 4, "50231231234", "11987654324", new DateTime(1996, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Av. Paulista, 1500", 4, 1, "ana.jpg", 4, 1, "Brasileira" },
                    { 5, "50231231235", "11987654325", new DateTime(1994, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua Tatuape, 300", 4, 0, "rafael.jpg", 5, 0, "Brasileiro" },
                    { 6, "50231231236", "11987654326", new DateTime(1999, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua Mooca, 220", 3, 0, "juliana.jpg", 6, 1, "Brasileira" },
                    { 7, "50231231237", "11987654327", new DateTime(1997, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua Santana, 720", 3, 1, "pedro.jpg", 7, 0, "Brasileiro" },
                    { 8, "50231231238", "11987654328", new DateTime(1996, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua Vila Mariana, 180", 4, 0, "camila.jpg", 8, 1, "Brasileira" },
                    { 9, "50231231239", "11987654329", new DateTime(1993, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua Ipiranga, 550", 4, 1, "gabriel.jpg", 9, 0, "Brasileiro" },
                    { 10, "50231231240", "11987654330", new DateTime(1998, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua Consolacao, 900", 3, 0, "beatriz.jpg", 10, 1, "Brasileira" },
                    { 11, "50231231241", "11987654331", new DateTime(1992, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua Liberdade, 100", 3, 1, "ricardo.jpg", 11, 0, "Brasileiro" },
                    { 12, "50231231242", "11987654332", new DateTime(1990, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua Bela Vista, 340", 4, 1, "fernanda.jpg", 12, 1, "Brasileira" },
                    { 13, "50231231243", "11987654333", new DateTime(2000, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua Penha, 410", 3, 0, "thiago.jpg", 13, 0, "Brasileiro" },
                    { 14, "50231231244", "11987654334", new DateTime(1995, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua Lapa, 670", 3, 0, "patricia.jpg", 14, 1, "Brasileira" },
                    { 15, "50231231245", "11987654335", new DateTime(1988, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Av. Faria Lima, 2100", 4, 1, "eduardo.jpg", 15, 0, "Brasileiro" },
                    { 16, "50231231246", "11987654336", new DateTime(1999, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua Carrão, 230", 3, 0, "lucas.jpg", 16, 0, "Brasileiro" },
                    { 17, "50231231247", "11987654337", new DateTime(1998, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua Butanta, 580", 3, 0, "isabela.jpg", 17, 1, "Brasileira" },
                    { 18, "50231231248", "11987654338", new DateTime(1996, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua Pinheiros, 760", 4, 1, "bruno.jpg", 18, 0, "Brasileiro" },
                    { 19, "50231231249", "11987654339", new DateTime(1997, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua Santana, 820", 3, 0, "larissa.jpg", 19, 1, "Brasileira" },
                    { 20, "50231231250", "11987654340", new DateTime(1994, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua Moema, 450", 3, 1, "gustavo.jpg", 20, 0, "Brasileiro" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FuncionarioDetalhes",
                keyColumn: "FuncionarioDetalheId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FuncionarioDetalhes",
                keyColumn: "FuncionarioDetalheId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FuncionarioDetalhes",
                keyColumn: "FuncionarioDetalheId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FuncionarioDetalhes",
                keyColumn: "FuncionarioDetalheId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FuncionarioDetalhes",
                keyColumn: "FuncionarioDetalheId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FuncionarioDetalhes",
                keyColumn: "FuncionarioDetalheId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FuncionarioDetalhes",
                keyColumn: "FuncionarioDetalheId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "FuncionarioDetalhes",
                keyColumn: "FuncionarioDetalheId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "FuncionarioDetalhes",
                keyColumn: "FuncionarioDetalheId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "FuncionarioDetalhes",
                keyColumn: "FuncionarioDetalheId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "FuncionarioDetalhes",
                keyColumn: "FuncionarioDetalheId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "FuncionarioDetalhes",
                keyColumn: "FuncionarioDetalheId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "FuncionarioDetalhes",
                keyColumn: "FuncionarioDetalheId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "FuncionarioDetalhes",
                keyColumn: "FuncionarioDetalheId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "FuncionarioDetalhes",
                keyColumn: "FuncionarioDetalheId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "FuncionarioDetalhes",
                keyColumn: "FuncionarioDetalheId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "FuncionarioDetalhes",
                keyColumn: "FuncionarioDetalheId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "FuncionarioDetalhes",
                keyColumn: "FuncionarioDetalheId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "FuncionarioDetalhes",
                keyColumn: "FuncionarioDetalheId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "FuncionarioDetalhes",
                keyColumn: "FuncionarioDetalheId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Projetos",
                keyColumn: "ProjetoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projetos",
                keyColumn: "ProjetoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projetos",
                keyColumn: "ProjetoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projetos",
                keyColumn: "ProjetoId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Projetos",
                keyColumn: "ProjetoId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Projetos",
                keyColumn: "ProjetoId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Projetos",
                keyColumn: "ProjetoId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Projetos",
                keyColumn: "ProjetoId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Projetos",
                keyColumn: "ProjetoId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Projetos",
                keyColumn: "ProjetoId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Projetos",
                keyColumn: "ProjetoId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Projetos",
                keyColumn: "ProjetoId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Projetos",
                keyColumn: "ProjetoId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Projetos",
                keyColumn: "ProjetoId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Projetos",
                keyColumn: "ProjetoId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Projetos",
                keyColumn: "ProjetoId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Projetos",
                keyColumn: "ProjetoId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Projetos",
                keyColumn: "ProjetoId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Projetos",
                keyColumn: "ProjetoId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Projetos",
                keyColumn: "ProjetoId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "FuncionarioId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "FuncionarioId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "FuncionarioId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "FuncionarioId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "FuncionarioId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "FuncionarioId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "FuncionarioId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "FuncionarioId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "FuncionarioId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "FuncionarioId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "FuncionarioId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "FuncionarioId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "FuncionarioId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "FuncionarioId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "FuncionarioId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "FuncionarioId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "FuncionarioId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "FuncionarioId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "FuncionarioId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "FuncionarioId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "DepartamentoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "DepartamentoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "DepartamentoId",
                keyValue: 3);
        }
    }
}
