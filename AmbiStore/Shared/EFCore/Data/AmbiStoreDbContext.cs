using AmbiStore.Shared.EFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using AmbiStore.Shared.Libraries;
using AmbiStore.Shared.Auxiliares;
using AmbiStore.Shared.Libraries.Enums;
using static AmbiStore.Shared.Extension.EnumExtensions;
using System.Linq;
using Org.BouncyCastle.Crypto.Prng.Drbg;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace AmbiStore.Shared.EFCore.Data
{
    public class AmbiStoreDbContext : DbContext
    {
        public AmbiStoreDbContext(DbContextOptions<AmbiStoreDbContext> options) : base(options)
        {

        }

        public DbSet<CFOP_SIS> CFOP_SISs { get; set; }
        public DbSet<CONTATO> CONTATOs { get; set; }
        public DbSet<CONTATO_PF> CONTATO_PFs { get; set; }
        public DbSet<CONTATO_PJ> CONTATO_PJs { get; set; }
        public DbSet<CST> CSTs { get; set; }
        public DbSet<CSOSN> CSOSNs { get; set; }
        public DbSet<EMITENTE> EMITENTEs { get; set; }
        public DbSet<ESTOQUE> ESTOQUEs { get; set; }
        public DbSet<FORMAPAGAMENTO> FORMAPAGAMENTOs { get; set; }
        public DbSet<FUNCIONARIO> FUNCIONARIOs { get; set; }
        public DbSet<GRUPO> GRUPOs { get; set; }
        public DbSet<NATUREZA_OPERACAO> NATUREZA_OPERACAOs { get; set; }
        public DbSet<PARCELAMENTO> PARCELAMENTOs { get; set; }
        public DbSet<PLANO_CONTA> PLANO_CONTAs { get; set; }
        public DbSet<PRODUTO> PRODUTOs { get; set; }
        public DbSet<SERVICO> SERVICOs { get; set; }
        public DbSet<TAXA_UF> TAXA_UFs { get; set; }
        public DbSet<UNI_MEDIDA> UNI_MEDIDAs { get; set; }
        public DbSet<VENDA> VENDAs { get; set; }
        public DbSet<VENDA_ITEM> VENDA_ITEMs { get; set; }
        public DbSet<VENDA_PAGAMENTO> VENDA_PAGAMENTOs { get; set; }


        protected override void OnModelCreating(ModelBuilder mb)
        {
            #if DEBUG
            //Debugger.Launch();
            #endif

            XmlRootAttribute xRoot = new XmlRootAttribute();
            XmlSerializer serializer;

            StringReader sr = new StringReader(null);

            xRoot.ElementName = "TB_CST_SIS";
            serializer = new XmlSerializer(typeof(CSTImportacao), xRoot);
            sr = new StringReader(Resources.cstseed_temp);
            CSTImportacao CSTs = (CSTImportacao)serializer.Deserialize(sr);
            mb.Entity<CST>().HasData(CSTs.TB_CST_SIS);

            xRoot.ElementName = "TB_CSOSN_SIS";
            serializer = new XmlSerializer(typeof(CSOSNImportacao), xRoot);
            sr = new StringReader(Resources.csosnseed_temp);
            CSOSNImportacao CSOSNs = (CSOSNImportacao)serializer.Deserialize(sr);
            mb.Entity<CSOSN>().HasData(CSOSNs.TB_CSOSN_SIS);

            xRoot.ElementName = "TB_CFOP_SIS";
            serializer = new XmlSerializer(typeof(CFOPImportacao), xRoot);
            sr = new StringReader(Resources.cfopseed_temp);
            CFOPImportacao cfopimpo = (CFOPImportacao)serializer.Deserialize(sr);
            mb.Entity<CFOP_SIS>().HasData(cfopimpo.deserializado());

            xRoot.ElementName = "SELECT_FROM_TB_PLANO_CONTAS";
            serializer = new XmlSerializer(typeof(SELECT_FROM_TB_PLANO_CONTAS), xRoot);
            sr = new StringReader(Resources.planoctaseed_temp);
            SELECT_FROM_TB_PLANO_CONTAS planoimpo = (SELECT_FROM_TB_PLANO_CONTAS)serializer.Deserialize(sr);
            mb.Entity<PLANO_CONTA>().HasData(planoimpo.listaPlanoContas());

            xRoot.ElementName = "SELECT_FROM_TB_TAXA_UF_ttu_";
            serializer = new XmlSerializer(typeof(SELECT_FROM_TB_TAXA_UF_ttu_), xRoot);
            sr = new StringReader(Resources.taxasseed_temp);
            SELECT_FROM_TB_TAXA_UF_ttu_ taxas = (SELECT_FROM_TB_TAXA_UF_ttu_)serializer.Deserialize(sr);
            mb.Entity<TAXA_UF>().HasData(taxas.retornaListaTaxas());


            CONTATO contatoSeed = new CONTATO();
            contatoSeed.NOME_JURIDICO = "CONTATOS DIVERSOS";
            contatoSeed.NOME_FANTASIA = "DIVERSOS";
            contatoSeed.STATUS = Status.Ativo;
            contatoSeed.ID = -2;
            mb.Entity<CONTATO>().HasData(contatoSeed);

            contatoSeed = new CONTATO();
            contatoSeed.NOME_JURIDICO = "ADMINISTRADOR";
            contatoSeed.NOME_FANTASIA = "ADMIN";
            contatoSeed.STATUS = Status.Ativo;
            contatoSeed.ID = -1;
            mb.Entity<CONTATO>().HasData(contatoSeed);

            mb.Entity<UNI_MEDIDA>().HasData(
                new UNI_MEDIDA("UN", "Unidade"),
                new UNI_MEDIDA("KG", "Quilograma"),
                new UNI_MEDIDA("MT", "Metro"),
                new UNI_MEDIDA("LT", "Litro"),
                new UNI_MEDIDA("PT", "Pacote"),
                new UNI_MEDIDA("PC", "Peça"),
                new UNI_MEDIDA("CX", "Caixa")
                );


            FUNCIONARIO admin = new FUNCIONARIO() { ID_CONTATO_FUNCIONARIO = -1, ID = -1, STATUS = Status.Ativo };

            List<PARCELAMENTO> parcelamentosSeed = new List<PARCELAMENTO> { 
                new PARCELAMENTO {ID = 1, DESCRICAO = "À Vista", ENTRADA = true, NUMERO_PARCELA = 1, STATUS = Status.Ativo, INTERVALOS = new List<int> { 0 } },
                new PARCELAMENTO {ID = 2, DESCRICAO = "Cartão À Vista", ENTRADA = true, NUMERO_PARCELA = 1, STATUS = Status.Ativo, INTERVALOS = new List<int> { 0 } },
                new PARCELAMENTO {ID = 3, DESCRICAO = "30 dias", ENTRADA = true, NUMERO_PARCELA = 1, STATUS = Status.Ativo, INTERVALOS = new List<int> { 30 } }
            };

            List<FORMAPAGAMENTO> formaspagamentosSeed = new List<FORMAPAGAMENTO>
            {
                new FORMAPAGAMENTO { ID = 1, DESCRICAO = "Dinheiro", STATUS = Status.Ativo, UTILIZACAO = UsoFMAPAGTO.Ambos, PARCELAMENTO_ID = 1},
                new FORMAPAGAMENTO { ID = 2, DESCRICAO = "A Prazo", STATUS = Status.Ativo, UTILIZACAO = UsoFMAPAGTO.CupomFiscal, PARCELAMENTO_ID = 3},
                new FORMAPAGAMENTO { ID = 3, DESCRICAO = "Cartão de Crédito", STATUS = Status.Ativo, UTILIZACAO = UsoFMAPAGTO.Ambos, PARCELAMENTO_ID = 2},
                new FORMAPAGAMENTO { ID = 4, DESCRICAO = "Cartão de Débito", STATUS = Status.Ativo, UTILIZACAO = UsoFMAPAGTO.Ambos, PARCELAMENTO_ID = 2},
                new FORMAPAGAMENTO { ID = 10, DESCRICAO = "Outros", STATUS = Status.Ativo, UTILIZACAO = UsoFMAPAGTO.Ambos, PARCELAMENTO_ID = 1}
            };

            List<NATUREZA_OPERACAO> natoperSeed = new List<NATUREZA_OPERACAO>
            {
                new NATUREZA_OPERACAO { ID = 1, DESCRICAO = "Venda à vista", RETEM_PIS_COFINS_CSLL = false, RETEM_INSS = false, RETEM_IRRF = false, PIS_COFINS = true, STATUS = Status.Ativo, CFOP_ID = 5102, TAXA_UF_ID = "X02", GERA_FINANCEIRO = true, GERA_REMESSA = false, BASE_COMISSAO = 1, CALCULA_IPI = true },
                new NATUREZA_OPERACAO { ID = 2, DESCRICAO = "Venda à prazo", RETEM_PIS_COFINS_CSLL = false, RETEM_INSS = false, RETEM_IRRF = false, PIS_COFINS = true, STATUS = Status.Ativo, CFOP_ID = 5102, TAXA_UF_ID = "X02", GERA_FINANCEIRO = true, GERA_REMESSA = false, BASE_COMISSAO = 1, CALCULA_IPI = true }
            };

            mb.Entity<FUNCIONARIO>()
                .HasOne(c => c.CONTATO_FUNCIONARIO)
                .WithOne(f => f.FUNCIONARIO)
                .HasForeignKey<FUNCIONARIO>(k => k.ID_CONTATO_FUNCIONARIO)
                .IsRequired(false);

            mb.Entity<CONTATO>()
                .HasOne(c => c.CONTATO_PF)
                .WithOne(c => c.CONTATO)
                .HasForeignKey<CONTATO_PF>(k => k.CONTATO_ID)
                .IsRequired(false);

            mb.Entity<CONTATO>()
                .HasOne(c => c.CONTATO_PJ)
                .WithOne(c => c.CONTATO)
                .HasForeignKey<CONTATO_PJ>(k => k.CONTATO_ID)
                .IsRequired(false);

            mb.Entity<FUNCIONARIO>()
                .HasMany(f => f.VENDEDOR_PREF_FUNCIONARIO)
                .WithOne(c => c.VENDEDOR_PREF)
                .HasForeignKey(k => k.CONTATO_VENDEDOR_PREF_ID);

            mb.Entity<ESTOQUE>()
                .HasOne(f => f.FORNECEDOR_PREFERENCIAL)
                .WithMany(e => e.FORNECEDOR_PREF_ESTOQUE)
                .HasForeignKey(k => k.FORNECEDOR_PREFERENCIAL_ID)
                .IsRequired(false);

            mb.Entity<ESTOQUE>()
                .HasOne(h => h.TAXA_UF)
                .WithMany(e => e.ESTOQUE_TAXA_UF)
                .HasForeignKey(k => k.TAXA_UF_ID)
                .IsRequired(false);
            mb.Entity<ESTOQUE>()
                 .HasOne(h => h.TAXA_UF_CFE)
                 .WithMany(e => e.ESTOQUE_TAXA_UF_CFE)
                 .HasForeignKey(k => k.TAXA_UF_CFE_ID)
                 .IsRequired(false);
            mb.Entity<ESTOQUE>()
                .HasOne(h => h.TAXA_ICMS_PART)
                .WithMany(e => e.ESTOQUE_TAXA_PART)
                .HasForeignKey(k => k.TAXA_ICMS_PART_ID)
                .IsRequired(false);
            mb.Entity<ESTOQUE>()
                 .HasOne(h => h.TAXA_ICMS_FCP)
                 .WithMany(e => e.ESTOQUE_TAXA_FCP)
                 .HasForeignKey(k => k.TAXA_ICMS_FCP_ID)
                 .IsRequired(false);

            mb.Entity<ESTOQUE>()
                .HasOne(c => c.CFOP_NF)
                .WithMany(e => e.ESTOQUE_CFOP_NFE)
                .HasForeignKey(k => k.CFOP_NF_ID)
                .IsRequired(true);
            mb.Entity<ESTOQUE>()
                .HasOne(c => c.CFOP_CFE)
                .WithMany(e => e.ESTOQUE_CFOP_CFE)
                .HasForeignKey(k => k.CFOP_CFE_ID)
                .IsRequired(true);

            mb.Entity<ESTOQUE>()
                .HasOne(u => u.UNI_MEDIDA)
                .WithMany(e => e.ESTOQUE_UNI_MEDIDA)
                .HasForeignKey(k => k.UNI_MEDIDA_ID);

            mb.Entity<ESTOQUE>()
                .HasOne(g => g.GRUPO)
                .WithMany(e => e.ESTOQUE_GRUPO)
                .HasForeignKey(k => k.GRUPO_ID)
                .IsRequired(false);

            mb.Entity<ESTOQUE>()
                .HasOne(cst => cst.CST_CFE)
                .WithMany(e => e.CST_CFE_ESTOQUE)
                .HasForeignKey(k => k.CST_CFE_ID)
                .IsRequired(false);
            mb.Entity<ESTOQUE>()
                .HasOne(cst => cst.CST_NFE)
                .WithMany(e => e.CST_NFE_ESTOQUE)
                .HasForeignKey(k => k.CST_NFE_ID)
                .IsRequired(false);
            mb.Entity<ESTOQUE>()
                .HasOne(csosn => csosn.CSOSN_CFE)
                .WithMany(e => e.CSOSN_CFE_ESTOQUE)
                .HasForeignKey(k => k.CSOSN_CFE_ID)
                .IsRequired(false);
            mb.Entity<ESTOQUE>()
                .HasOne(csosn => csosn.CSOSN_NFE)
                .WithMany(e => e.CSOSN_NFE_ESTOQUE)
                .HasForeignKey(k => k.CSOSN_NFE_ID)
                .IsRequired(false);

            mb.Entity<PRODUTO>()
                .HasOne(e => e.ESTOQUE)
                .WithOne(p => p.PRODUTO_ESTOQUE)
                .HasForeignKey<PRODUTO>(k => k.ESTOQUE_ID)
                .IsRequired(true);

            mb.Entity<SERVICO>()
                .HasOne(e => e.ESTOQUE)
                .WithOne(s => s.SERVICO_ESTOQUE)
                .HasForeignKey<SERVICO>(k => k.ESTOQUE_ID)
                .IsRequired(false);

            mb.Entity<VENDA>()
                .HasOne(v => v.NATUREZA_OPERACAO)
                .WithMany(n => n.VENDA_NATOPER)
                .HasForeignKey(n => n.NATUREZA_OPERACAO_ID);

            mb.Entity<VENDA>()
                .HasMany(x => x.VENDA_ITEMs)
                .WithOne(y => y.VENDA)
                .HasForeignKey(k => k.VENDA_ID);

            mb.Entity<VENDA>()
                .HasMany(x => x.VENDA_PAGAMENTOs)
                .WithOne(y => y.VENDA_VENDA_PAGAMENTO)
                .HasForeignKey(k => k.VENDA_ID);

            mb.Entity<VENDA_ITEM>()
                .HasOne(x => x.CFOP)
                .WithMany(y => y.VENDA_ITEM_CFE)
                .HasForeignKey(k => k.CFOP_ID);

            mb.Entity<VENDA_ITEM>()
                .HasOne(x => x.ESTOQUE)
                .WithMany(y => y.VENDA_ITEM_ESTOQUES)
                .HasForeignKey(k => k.ESTOQUE_ID);

            mb.Entity<VENDA_ITEM>()
                .HasOne(x => x.UNI_MEDIDA)
                .WithMany(y => y.VENDA_ITEM_UNI_MEDIDAS)
                .HasForeignKey(x => x.UNI_MEDIDA_ID);

            mb.Entity<VENDA>()
                .HasOne(x => x.TRANSPORTADORA)
                .WithMany(y => y.TRANSPORTADORA_CONTATO)
                .HasForeignKey(k => k.TRANSPORTADORA_ID)
                .IsRequired(false);

            mb.Entity<VENDA>()
                .HasOne(x => x.VENDEDOR)
                .WithMany(y => y.VENDA_VENDEDOR)
                .HasForeignKey(z => z.VENDEDOR_ID);

            mb.Entity<VENDA_PAGAMENTO>()
                .HasOne(x => x.FORMAPAGAMENTO_VENDA_PAGAMENTO)
                .WithMany(y => y.VENDA_PAGAMENTOS)
                .HasForeignKey(x => x.FORMAPAGAMENTO_ID);

            mb.Entity<VENDA_PAGAMENTO>()
                .HasOne(x => x.PLANO_CONTA_VENDA_PAGAMENTO)
                .WithMany(x => x.VENDA_PAGTO_PL_CONTA)
                .HasForeignKey(x => x.PLANO_CONTA_ID);

            mb.Entity<FORMAPAGAMENTO>()
                .HasOne(x => x.PARCELAMENTO)
                .WithMany(y => y.PARCELAMENTO_FORMAPAGAMENTO)
                .HasForeignKey(k => k.PARCELAMENTO_ID);

            mb.Entity<VENDA>()
                .HasOne(x => x.CLIENTE)
                .WithMany(y => y.CLIENTE_CONTATO)
                .HasForeignKey(k => k.CLIENTE_ID);

            mb.Entity<NATUREZA_OPERACAO>()
                .HasOne(x => x.CFOP)
                .WithMany(y => y.NATU_OPER_CFOP)
                .HasForeignKey(x => x.CFOP_ID);

            mb.Entity<NATUREZA_OPERACAO>()
                .HasOne(x => x.TAXA_UF)
                .WithMany(x => x.NATU_OPER_TAXA)
                .HasForeignKey(x => x.TAXA_UF_ID);

           
            mb.Entity<FUNCIONARIO>().HasData(admin);

            mb.Entity<PARCELAMENTO>()
                .HasData(parcelamentosSeed);

            mb.Entity<FORMAPAGAMENTO>()
                .HasData(formaspagamentosSeed);

            mb.Entity<NATUREZA_OPERACAO>()
                .HasData(natoperSeed);

            mb.Entity<CST>()
                .HasKey(x => x.COD_CST);

            mb.Entity<CSOSN>()
                .HasKey(x => x.CSOSN_COD);

            mb.Entity<CFOP_SIS>()
                .HasKey(x => x.CFOP);

            base.OnModelCreating(mb);
        }

    }
}