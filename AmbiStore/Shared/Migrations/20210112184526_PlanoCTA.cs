using Microsoft.EntityFrameworkCore.Migrations;

namespace AmbiStore.Shared.Migrations
{
    public partial class PlanoCTA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PLANO_CONTAs",
                columns: new[] { "ID", "COD_CONTA", "COD_PAI", "COD_SPED", "DESCRICAO" },
                values: new object[,]
                {
                    { 1, "1.", "", null, "ATIVO" },
                    { 108, "3.", "", null, "DESPESAS" },
                    { 109, "3.01", "3.", null, "DESPESAS OPERACIONAIS" },
                    { 110, "3.01.01", "3.01", null, "DESPESAS OPERACIONAIS DAS ATIVIDADES EM" },
                    { 111, "3.01.01.01", "3.01.01", null, "DESPESAS E ENCARGOS COM PESSOAL" },
                    { 112, "3.01.01.01.01", "3.01.01.01", null, "Remuneração de Dirigentes" },
                    { 113, "3.01.01.01.02", "3.01.01.01", null, "Ordenados, Salários, Gratificações dos E" },
                    { 114, "3.01.01.01.03", "3.01.01.01", null, "Prestação de Serviços por Pessoa Física" },
                    { 115, "3.01.01.01.04", "3.01.01.01", null, "Prestação de Serviços por Pessoa Jurídic" },
                    { 116, "3.01.01.01.05", "3.01.01.01", null, "Outros Gastos com Pessoal" },
                    { 117, "3.01.01.01.06", "3.01.01.01", null, "Encargos Sociais - Previdência Social" },
                    { 118, "3.01.01.01.07", "3.01.01.01", null, "Encargos Sociais - FGTS" },
                    { 119, "3.01.01.01.08", "3.01.01.01", null, "Encargos Sociais - Outros" },
                    { 120, "3.01.01.01.09", "3.01.01.01", null, "PIS/Pasep" },
                    { 121, "3.01.01.01.10", "3.01.01.01", null, "Cofins" },
                    { 122, "3.01.01.01.11", "3.01.01.01", null, "Demais Impostos, Taxas e Contribuições" },
                    { 123, "3.01.01.03", "3.01.01", null, "DESPESAS GERAIS E ADMINISTRATIVAS" },
                    { 124, "3.01.01.03.01", "3.01.01.03", null, "Aluguéis" },
                    { 107, "2.07.07.01.02", "2.07.07.01", null, "(-) Prejuízos Acumulados" },
                    { 125, "3.01.01.03.02", "3.01.01.03", null, "Despesas com Veiculos e Conservação de B" },
                    { 106, "2.07.07.01.01", "2.07.07.01", null, "Lucros Acumulados" },
                    { 104, "2.07.07", "2.07", null, "OUTRAS CONTAS" },
                    { 87, "2.01.01.04.04", "2.01.01.04", null, "Outros tributos a Recolher" },
                    { 88, "2.01.01.07", "2.01.01", null, "OBRIGAÇÕES TRABALHISTAS" },
                    { 89, "2.01.01.07.01", "2.01.01.07", null, "Salários a Pagar" },
                    { 90, "2.01.01.07.02", "2.01.01.07", null, "Pró-Labore a Pagar" },
                    { 91, "2.01.01.13", "2.01.01", null, "OUTRAS CONTAS" },
                    { 92, "2.01.01.13.01", "2.01.01.13", null, "Outras contas a pagar" },
                    { 93, "2.03", "2.", null, "NÃO CIRCULANTE" },
                    { 94, "2.03.01", "2.03", null, "OBRIGAÇÕES A LONGO PRAZO" },
                    { 95, "2.03.01.02.00", "2.03.01.02", null, "Financiamentos a Longo Prazo - Sistema F" },
                    { 96, "2.07", "2.", null, "PATRIMÔNIO LIQUIDO" },
                    { 97, "2.07.01", "2.07", null, "CAPITAL REALIZADO" },
                    { 98, "2.07.01.01", "2.07.01", null, "CAPITAL SOCIAL" },
                    { 99, "2.07.01.01.00", "2.07.01.01", null, "Capital Subscrito" },
                    { 100, "2.07.01.01.01", "2.07.01.01", null, "(-) Capital a Integralizar" },
                    { 101, "2.07.04.01", "2.07.04", null, "RESERVAS" },
                    { 102, "2.07.04.01.01", "2.07.04.01", null, "Reservas de Capital" },
                    { 103, "2.07.04.01.02", "2.07.04.01", null, "Reservas de Lucros" },
                    { 105, "2.07.07.01", "2.07.07", null, "LUCROS OU PREJUIZOS ACUMULADOS" },
                    { 126, "3.01.01.03.03", "3.01.01.03", null, "Propaganda e publicidade" },
                    { 127, "3.01.01.03.04", "3.01.01.03", null, "Multas" },
                    { 128, "3.01.01.03.05", "3.01.01.03", null, "Provisão para Férias e 13o Salário" },
                    { 151, "4.01.01.03", "4.01.01", null, "DEDUÇÕES DA RECEITA BRUTA" },
                    { 152, "4.01.01.03.01", "4.01.01.03", null, "(-) Vendas Canceladas, Devoluções e Desc" },
                    { 153, "4.01.01.03.02", "4.01.01.03", null, "(-) ICMS" },
                    { 154, "4.01.01.03.03", "4.01.01.03", null, "(-) Cofins" },
                    { 155, "4.01.01.03.04", "4.01.01.03", null, "(-) PIS/Pasep" },
                    { 156, "4.01.01.03.05", "4.01.01.03", null, "(-) ISS" },
                    { 157, "4.01.01.03.06", "4.01.01.03", null, "(-) Demais Impostos e Contribuições inci" },
                    { 158, "4.01.03", "4.01", null, "CUSTOS DOS BENS E SERVIÇOS VENDIDOS" },
                    { 159, "4.01.03.01", "4.01.03", null, "CUSTOS DOS PRODUTOS DE FABRICAÇÃO PRÓPRI" },
                    { 160, "4.01.03.01.01", "4.01.03.01", null, "Custo dos Produtos de Fabricação Própria" },
                    { 161, "4.01.03.02", "4.01.03", null, "CUSTO DAS MERCADORIAS REVENDIDAS" },
                    { 162, "4.01.03.02.01", "4.01.03.02", null, "Custo das Mercadorias Revendidas" },
                    { 163, "4.01.03.03", "4.01.03", null, "CUSTO DOS SERVIÇOS VENDIDOS" },
                    { 164, "4.01.03.03.01", "4.01.03.03", null, "Custo dos Serviços Vendidos" },
                    { 165, "4.01.05", "4.01", null, "OUTRAS RECEITAS OPERACIONAIS" },
                    { 166, "4.01.05.01", "4.01.05", null, "RECEITAS FINANCEIRAS" },
                    { 167, "4.01.05.01.02", "4.01.05.01", null, "Recebimento de Juros" },
                    { 150, "4.01.01.01.20", "4.01.01.01", null, "Outras Receitas" },
                    { 149, "4.01.01.01.15", "4.01.01.01", null, "Receita de Locação de Bens" },
                    { 148, "4.01.01.01.10", "4.01.01.01", null, "Receita da Prestação de Serviços" },
                    { 147, "4.01.01.01.05", "4.01.01.01", null, "Receita da Revenda de Mercadorias" },
                    { 129, "3.01.01.03.06", "3.01.01.03", null, "Bens de Natureza Permanente" },
                    { 130, "3.01.01.03.07", "3.01.01.03", null, "Despesas com viagens, diárias e ajuda de" },
                    { 131, "3.01.01.05", "3.01.01", null, "DESPESAS OPERACIONAIS" },
                    { 132, "3.01.01.05.01", "3.01.01.05", null, "Água" },
                    { 133, "3.01.01.05.02", "3.01.01.05", null, "Energia Elétrica" },
                    { 134, "3.01.01.05.03", "3.01.01.05", null, "Telefone" },
                    { 135, "3.01.01.05.04", "3.01.01.05", null, "Correios e Malotes" },
                    { 136, "3.01.01.05.05", "3.01.01.05", null, "Fretes e Carretos" },
                    { 86, "2.01.01.04.03", "2.01.01.04", null, "Contribuição Previdenciária a Recolher" },
                    { 137, "3.01.01.05.06", "3.01.01.05", null, "Contabilidade" },
                    { 139, "3.01.01.05.08", "3.01.01.05", null, "Outras Despesas Operacionais" },
                    { 140, "3.01.01.07", "3.01.01", null, "DESPESAS FINANCEIRAS" },
                    { 141, "3.01.01.07.02", "3.01.01.07", null, "Pagamento de Juros" },
                    { 142, "4.", "", null, "RECEITAS" },
                    { 143, "4.01", "4.", null, "RECEITA LIQUIDA" },
                    { 144, "4.01.01", "4.01", null, "RECEITA BRUTA" },
                    { 145, "4.01.01.01", "4.01.01", null, "RECEITAS COM VENDAS DE PRODUTOS" },
                    { 146, "4.01.01.01.01", "4.01.01.01", null, "Receita com Vendas de Produtos de Fabric" },
                    { 138, "3.01.01.05.07", "3.01.01.05", null, "Assessoria Jurídica" },
                    { 168, "2.03.01.02", "2.03.01", null, "FINANCIAMENTOS A LONGO PRAZO" },
                    { 85, "2.01.01.04.02", "2.01.01.04", null, "PIS e COFINS a Recolher" },
                    { 83, "2.01.01.04", "2.01.01", null, "OBRIGAÇÕES SOCIAIS" },
                    { 23, "1.01.03.01.02", "1.01.03.01", null, "Insumos (materiais diretos)" },
                    { 24, "1.01.03.01.04", "1.01.03.01", null, "Produtos Acabados" },
                    { 25, "1.01.03.01.05", "1.01.03.01", null, "Serviços em Andamento" },
                    { 26, "1.01.05", "1.01", null, "CRÉDITOS" },
                    { 27, "1.01.05.01", "1.01.05", null, "FORNECEDORES" },
                    { 28, "1.01.05.01.00", "1.01.05.01", null, "Adiantamento Fornecedores" },
                    { 29, "1.01.05.02", "1.01.05", null, "CLIENTES" },
                    { 30, "1.01.05.02.00", "1.01.05.02", null, "Contas a receber - Clientes Diversos" },
                    { 31, "1.01.05.02.01", "1.01.05.02", null, "Créditos com Cartão de Crédito - VISA" },
                    { 32, "1.01.05.02.02", "1.01.05.02", null, "Créditos com Cartão de Crédito - AMERICA" },
                    { 33, "1.01.05.02.03", "1.01.05.02", null, "Créditos com Cartão de Crédito - MASTERC" },
                    { 34, "1.01.05.02.04", "1.01.05.02", null, "Créditos com Cartão de Crédito - BNDES" },
                    { 35, "1.01.07", "1.01", null, "DESPESAS DO EXERCÍCIO SEGUINTE" },
                    { 36, "1.01.07.01", "1.01.07", null, "DESPESAS DIVERSAS DO EXERCÍCIO SEGUINTE" },
                    { 37, "1.01.07.01.00", "1.01.07.01", null, "Despesas pagas do exercício seguinte" },
                    { 38, "1.01.09", "1.01", null, "CONTAS RETIFICADORAS" },
                    { 39, "1.01.09.01.01", "1.09.01.01", null, "(-) Duplicatas Descontadas" },
                    { 22, "1.01.03.01.01", "1.01.03.01", null, "Mercadorias para Revenda" },
                    { 40, "1.07", "1.", null, "NÃO CIRCULANTE" },
                    { 21, "1.01.03.01", "1.01.03", null, "MERCADORIAS E SERVICOS" },
                    { 19, "1.01.01.07.06", "1.01.01.07", null, "Banco SICREDI (aplic.)" },
                    { 2, "1.01", "1.", null, "CIRCULANTE" },
                    { 3, "1.01.01", "1.01", null, "DISPONIBILIDADES" },
                    { 4, "1.01.01.01", "1.01.01", null, "CAIXA" },
                    { 5, "1.01.01.01.01", "1.01.01.01", null, "Caixa Geral" },
                    { 6, "1.01.01.02", "1.01.01", null, "BANCOS - CONTA MOVIMENTO" },
                    { 7, "1.01.01.02.01", "1.01.01.02", null, "Banco do Brasil (movto.)" },
                    { 8, "1.01.01.02.02", "1.01.01.02", null, "Banco Santander (movto.)" },
                    { 9, "1.01.01.02.03", "1.01.01.02", null, "Banco Bradesco (movto.)" },
                    { 10, "1.01.01.02.04", "1.01.01.02", null, "Banco Itau (movto.)" },
                    { 11, "1.01.01.02.05", "1.01.01.02", null, "Banco CEF (movto.)" },
                    { 12, "1.01.01.02.06", "1.01.01.02", null, "Banco SICREDI (movto.)" },
                    { 13, "1.01.01.07", "1.01.01", null, "BANCOS - CONTA APLICACAO" },
                    { 14, "1.01.01.07.01", "1.01.01.07", null, "Banco do Brasil (aplic.)" },
                    { 15, "1.01.01.07.02", "1.01.01.07", null, "Banco Santander (aplic.)" },
                    { 16, "1.01.01.07.03", "1.01.01.07", null, "Banco Bradesco (aplic.)" },
                    { 17, "1.01.01.07.04", "1.01.01.07", null, "Banco Itau (aplic.)" },
                    { 18, "1.01.01.07.05", "1.01.01.07", null, "Banco CEF (aplic.)" },
                    { 20, "1.01.03", "1.01", null, "ESTOQUES" },
                    { 41, "1.07.00", "1.07", null, "REALIZÁVEL A LONGO PRAZO" },
                    { 42, "1.07.00.01", "1.07.00", null, "CLIENTES" },
                    { 43, "1.07.00.01.00", "1.07.00.01", null, "Contas a receber - Clientes Diversos (ex" },
                    { 66, "1.07.05", "1.07", null, "INTANGÍVEL" },
                    { 67, "1.07.05.03", "1.07.05", null, "REGISTRO DE MARCAS E PATENTES" },
                    { 68, "1.07.05.03.00", "1.07.05.03", null, "Marcas e Patentes" },
                    { 69, "1.07.05.09", "1.07.05", null, "SOFTWARES OU PROGRAMAS DE COMPUTADOR" },
                    { 70, "1.07.05.09.00", "1.07.05.09", null, "Software ou Programas de Computador" },
                    { 71, "2.", "", null, "PASSIVO" },
                    { 72, "2.01", "2.", null, "CIRCULANTE" },
                    { 73, "2.01.01", "2.01", null, "OBRIGAÇÕES A CURTO PRAZO" },
                    { 74, "2.01.01.01", "2.01.01", null, "FORNECEDORES E ADIANTAMENTO DE CLIENTES" },
                    { 75, "2.01.01.01.00", "2.01.01.01", null, "Fornecedores - Contas a Pagar" },
                    { 76, "2.01.01.01.01", "2.01.01.01", null, "Adiantamentos de Clientes" },
                    { 77, "2.01.01.02", "2.01.01", null, "FINANCIAMENTOS" },
                    { 78, "2.01.01.02.01", "2.01.01.02", null, "Financiamentos a Curto Prazo - Sistema F" },
                    { 79, "2.01.01.03", "2.01.01", null, "OBRIGAÇÕES FISCAIS" },
                    { 80, "2.01.01.03.01", "2.01.01.03", null, "IPI a Recolher" },
                    { 81, "2.01.01.03.02", "2.01.01.03", null, "ICMS e Contribuições a Recolher" },
                    { 82, "2.01.01.03.03", "2.01.01.03", null, "Tributos Municipais a Recolher" },
                    { 65, "1.07.04.12.00", "1.07.04.12", null, "(-) Depreciações, Amortizações e Quotas" },
                    { 64, "1.07.04.12", "1.07.04", null, "DEPRECIAÇÃO DO IMOBILIZADO" },
                    { 63, "1.07.04.05.00", "1.07.04.05", null, "Móveis, Utensílios e Instalações Comerci" },
                    { 62, "1.07.04.05", "1.07.04", null, "MÓVEIS, UTENSILIOS E INSTALAÇÕES" },
                    { 44, "1.07.00.01.01", "1.01.05.02", null, "Créditos com Cartão de Crédito - VISA (e" },
                    { 45, "1.07.00.01.02", "1.01.05.02", null, "Créditos com Cartão de Crédito - AMERICA" },
                    { 46, "1.07.00.01.03", "1.01.05.02", null, "Créditos com Cartão de Crédito - MASTERC" },
                    { 47, "1.07.00.01.04", "1.01.05.02", null, "Créditos com Cartão de Crédito - BNDES" },
                    { 48, "1.07.00.03", "1.07.00", null, "APLICAÇÕES FINANCEIRAS" },
                    { 49, "1.07.00.03.00", "1.07.00.03", null, "Aplicações (exerc. seguinte)" },
                    { 50, "1.07.00.90", "1.07.00", null, "DUPLICATAS, LIQUIDAÇÃO DUVIDOSA E ESTOQU" },
                    { 51, "1.07.00.90.00", "1.07.00.90", null, "(-) Duplicatas Descontadas" },
                    { 84, "2.01.01.04.01", "2.01.01.04", null, "FGTS a Recolher" },
                    { 52, "1.07.01", "1.07", null, "INVESTIMENTOS" },
                    { 54, "1.07.01.03.01", "1.07.01.03", null, "Outros Investimentos" },
                    { 55, "1.07.04", "1.07", null, "IMOBILIZADO" },
                    { 56, "1.07.04.01", "1.07.04", null, "TERRENOS" },
                    { 57, "1.07.04.01.00", "1.07.04.01", null, "Terrenos" },
                    { 58, "1.07.04.02", "1.07.04", null, "EDIFICAÇÕES" },
                    { 59, "1.07.04.02.00", "1.07.04.02", null, "Edifícios e Construções" },
                    { 60, "1.07.04.04", "1.07.04", null, "VEÍCULOS" },
                    { 61, "1.07.04.04.00", "1.07.04.04", null, "Veiculos" },
                    { 53, "1.07.01.03", "1.07.01", null, "INVESTIMENTOS DIVERSOS" },
                    { 169, "4.01.05.01.03", "4.01.05.01", null, "Recebimento de Troco" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "PLANO_CONTAs",
                keyColumn: "ID",
                keyValue: 169);
        }
    }
}
