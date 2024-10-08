using Sale.Domain.Entities.Base;
using Sale.Domain.Enumerations;

namespace Sale.Domain.Entities.Accounting
{
    public class AccountingDoucument : BaseImportantEntity<long>
    {
        public string Code { get; set; }
        public DateOnly Date  { get; set; }
        public AccountingDocumentType Type { get; set; }
        public string Attachment { get; set; }
        public bool IsLock { get; set; }
        public AccountingYear Year { get; set; }        
        public List<AccountingDoucumentItem> DoucumentItems { get; set; } = [];
    }

}
