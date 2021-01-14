using System.Collections.Generic;
using System.Windows.Documents;
using System.Xml.Serialization;

namespace AmbiStore.Shared.EFCore.Models
{
    public class PLANO_CONTA : EntityBase
    {
        public string DESCRICAO { get; set; }
        public string COD_SPED { get; set; }
        public string COD_CONTA { get; set; }
        public string COD_PAI { get; set; }

        //============
        public List<VENDA> VENDAS_PLANO_CONTA { get; set; }
        public List<VENDA_PAGAMENTO> VENDA_PAGTO_PL_CONTA { get; set; }
    }
}