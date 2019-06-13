namespace CustomersManager.Models.Base.Abstracts
{
    public abstract class TableName : Table
    {
        #region ==================== ATTRIBUTES ====================

        public string Name { get; set; }

        #endregion ==================== ATTRIBUTES ====================

        #region ==================== CONSTRUCTORS ====================

        public TableName()
            : base()
        { }

        #endregion ==================== CONSTRUCTORS ====================
    }
}