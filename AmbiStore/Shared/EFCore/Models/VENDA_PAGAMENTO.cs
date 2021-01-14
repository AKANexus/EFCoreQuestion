
namespace AmbiStore.Shared.EFCore.Models
{
    public class VENDA_PAGAMENTO : EntityBase
    {

        public decimal VLR_PAGTO { get; set; }
        public string NSU { get; set; }
        //==============
        public int VENDA_ID { get; set; }
        public VENDA VENDA_VENDA_PAGAMENTO { get; set; }
        public int FORMAPAGAMENTO_ID { get; set; }
        public FORMAPAGAMENTO FORMAPAGAMENTO_VENDA_PAGAMENTO { get; set; }
        public int PLANO_CONTA_ID { get; set; } = 5;
        public PLANO_CONTA PLANO_CONTA_VENDA_PAGAMENTO { get; set; }
    }
}
