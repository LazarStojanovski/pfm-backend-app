using Data.Entities.Enums;

namespace Data.Entities
{
    public class TransactionModel
    {
        public string Id { get; set; }
         public string BeneficiaryName { get; set; }
         public string Date { get; set; }
         public Direction Direction { get; set; }
         public double Amount { get; set; }
         public string Description { get; set; }
         public string Currency { get; set; }
         public int? Mcc { get; set; }
         public TransactionKind Kind { get; set; }
    }
}