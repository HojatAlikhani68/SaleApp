using System.ComponentModel.DataAnnotations;

namespace Sale.Domain.Entities.Base
{
    public abstract class BaseDocumentEntity<TKey>: BaseImportantEntity<TKey>
    {
        public string Code { get; set; }
        public DateTime DateTime { get; set; }
        [Timestamp]
        public byte Timestamp { get; set; }
    }
}
