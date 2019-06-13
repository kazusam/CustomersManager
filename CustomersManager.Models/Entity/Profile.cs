using System.Collections.Generic;

namespace CustomersManager.Models.Entity
{
    public class Profile : Base.Abstracts.TableName
    {
        #region ==================== ATTRIBUTES ====================

        public int Age { get; set; }
        public Enumerators.Gender Gender { get; set; }

        public virtual IList<Civil.Contact> Contacts { get; set; } = new List<Civil.Contact>();
        public virtual Commerce.Customer Customer { get; set; }
        public virtual IList<Civil.Document> Documents { get; set; } = new List<Civil.Document>();
        public virtual IList<ProfileAddress> Addresses { get; set; } = new List<ProfileAddress>();

        #endregion ==================== ATTRIBUTES ====================

        #region ==================== CONSTRUCTORS ====================

        public Profile()
            : base()
        { }

        #endregion ==================== CONSTRUCTORS ====================
    }
}