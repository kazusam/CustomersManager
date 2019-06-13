namespace CustomersManager.Models.Entity
{
    public class ProfileAddress : Base.Abstracts.Table
    {
        #region ==================== ATTRIBUTES ====================

        public string ProfileId { get; set; }
        public string AddressId { get; set; }

        public virtual Profile Profile { get; set; }
        public virtual Localization.Address Address { get; set; }

        #endregion ==================== ATTRIBUTES ====================

        #region ==================== CONSTRUCTORS ====================

        public ProfileAddress()
            : base()
        { }

        #endregion ==================== CONSTRUCTORS ====================
    }
}