namespace CustomersManager.Models.Civil
{
    public class Contact : Base.Abstracts.TableValue
    {
        #region ==================== ATTRIBUTES ====================

        public string Description { get; set; }
        public string ProfileId { get; set; }

        public virtual Entity.Profile Profile { get; set; }

        #endregion ==================== ATTRIBUTES ====================

        #region ==================== CONSTRUCTORS ====================

        public Contact()
            : base()
        { }

        #endregion ==================== CONSTRUCTORS ====================
    }
}