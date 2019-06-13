namespace CustomersManager.Models.Commerce
{
    public class Customer : Base.Abstracts.Table
    {
        #region ==================== ATTRIBUTES ====================

        public string ProfileId { get; set; }

        public virtual Entity.Profile Profile { get; set; }

        #endregion ==================== ATTRIBUTES ====================

        #region ==================== CONSTRUCTORS ====================

        public Customer()
            : base()
        { }

        #endregion ==================== CONSTRUCTORS ====================
    }
}