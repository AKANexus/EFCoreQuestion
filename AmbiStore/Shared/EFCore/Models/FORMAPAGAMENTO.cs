using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AmbiStore.Shared.Libraries.Enums;

namespace AmbiStore.Shared.EFCore.Models
{
    public class FORMAPAGAMENTO : EntityBase
    {
        public string DESCRICAO { get; set; }
        public Status STATUS { get; set; }
        [Required]
        public UsoFMAPAGTO UTILIZACAO { get; set; }

        private string cfe_cod;

        public string CFE_COD
        {
            get { return cfe_cod; }
            set
            { 
                if (UTILIZACAO != UsoFMAPAGTO.NotaFiscal && value is null)
                {
                    cfe_cod = null;
                }
                else
                {
                    cfe_cod = value;
                }
            }
        }


        public int PARCELAMENTO_ID { get; set; }
        public PARCELAMENTO PARCELAMENTO { get; set; }

        public List<VENDA_PAGAMENTO> VENDA_PAGAMENTOS { get; set; }

        public FORMAPAGAMENTO()
        {

        }

    }
}