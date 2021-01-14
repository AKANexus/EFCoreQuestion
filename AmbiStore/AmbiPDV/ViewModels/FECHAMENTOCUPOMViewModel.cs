using AmbiStore.Shared.EFCore.Data;
using AmbiStore.Shared.EFCore.Models;
using AmbiStore.Shared.Libraries.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Xml;
using System.Xml.Serialization;
using static AmbiStore.Shared.Libraries.Static;


namespace AmbiPDV.ViewModels
{
    public class FECHAMENTOCUPOMViewModel : ViewModelBase
    {
        public IEnumerable<FORMAPAGAMENTO> FORMASATIVAS => _context.FORMAPAGAMENTOs
                .Select(x => x)
                .Include(x => x.PARCELAMENTO)
                .Where(x =>
                    x.STATUS == Status.Ativo &&
                    (x.UTILIZACAO == UsoFMAPAGTO.Ambos || x.UTILIZACAO == UsoFMAPAGTO.CupomFiscal)
                    ).ToArray();
        public List<VENDA_PAGAMENTO> PAGAMENTOS_FEITOS { get; set; } = new List<VENDA_PAGAMENTO>();
        private readonly VENDA _venda_em_curso;
        private AmbiStoreDbContext _context;
        public decimal VALOR_DA_VENDA
        {
            get
            {
                decimal valorDaVenda = 0M;
                foreach (VENDA_ITEM item in _venda_em_curso.VENDA_ITEMs)
                {
                    valorDaVenda += (item.ESTOQUE.PRECO_VENDA - item.VLR_DESCONTO) * item.QTD_ITEM;
                }
                return valorDaVenda;
            }
        }
        private FORMAPAGAMENTO formaSelecionada;
        public int CODFORMAPAGTO
        {
            set
            {
                formaSelecionada = FORMASATIVAS.FirstOrDefault(x => x.ID == value);
            }
        }
        public decimal VALORPAGTO { get; set; }
        public int PARCELAS { get; set; } = 1;
        public decimal VALORPAGO { get; set; } = 0;
        public decimal DESCONTO { get; set; } = 0;
        public decimal TROCO { get; set; } = 0;
        public decimal SALDORESTANTE
        {
            get
            {
                return VALOR_DA_VENDA - _venda_em_curso.VENDA_PAGAMENTOs.Sum(x => x.VLR_PAGTO);
            }
        }

        public FECHAMENTOCUPOMViewModel()
        {

        }

        public event EventHandler ClosesWindow;

        public FECHAMENTOCUPOMViewModel(AmbiStoreDbContext context, VENDA vendaEmCurso)
        {
            _venda_em_curso = vendaEmCurso ?? throw new ArgumentNullException(nameof(VENDA));
            _context = context ?? throw new ArgumentNullException(nameof(AmbiStoreDbContext));
            VALORPAGTO = VALOR_DA_VENDA;
        }


        public void ProcessaMetodoAtual()
        {
            VENDA_PAGAMENTO pagamento = _context.VENDA_PAGAMENTOs.Add(new VENDA_PAGAMENTO()
            { 
            FORMAPAGAMENTO_VENDA_PAGAMENTO = formaSelecionada,
            VLR_PAGTO = VALORPAGTO,
            PLANO_CONTA_ID = 5
            }).Entity;

            VALORPAGTO = SALDORESTANTE;
            OnPropertyChanged(null);
            FinalizaProcessoDeVenda();

        }

        private void FinalizaProcessoDeVenda()
        {

            SalvaVendaNaBase();
            Application.Current.Dispatcher.Invoke(() => ClosesWindow?.Invoke(this, new EventArgs()));
        }

        private void SalvaVendaNaBase()
        {
            DateTime horaDaVenda = DateTime.Now;
            _venda_em_curso.DT_EMISSAO = horaDaVenda;
            _venda_em_curso.DT_SAIDA = horaDaVenda;
            _venda_em_curso.NF_MODELO = "59";
            _venda_em_curso.QUANTIDADE_VOLUME = _venda_em_curso.VENDA_ITEMs.Count;
            foreach (VENDA_ITEM item in _venda_em_curso.VENDA_ITEMs)
            {
                item.ESTOQUE.PRODUTO_ESTOQUE.QTD_ATUAL -= item.QTD_ITEM;
                item.ESTOQUE.ULTIMA_VENDA = horaDaVenda;
            }

            _context.Add(_venda_em_curso);

            _context.SaveChanges();
        }
    }
}
