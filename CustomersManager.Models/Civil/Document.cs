using System;

namespace CustomersManager.Models.Civil
{
    public class Document : Base.Abstracts.TableValue
    {
        #region ==================== ATTRIBUTES ====================

        public string Authority { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public DateTime? IssueDate { get; set; }
        public string IssuingCountry { get; set; }
        public string ProfileId { get; set; }

        public virtual Entity.Profile Profile { get; set; }

        #endregion ==================== ATTRIBUTES ====================

        #region ==================== CONSTRUCTORS ====================

        public Document()
            : base()
        { }

        #endregion ==================== CONSTRUCTORS ====================
    }
}