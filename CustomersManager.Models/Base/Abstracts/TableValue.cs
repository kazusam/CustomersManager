namespace CustomersManager.Models.Base.Abstracts
{
    public abstract class TableValue : TableName
    {
        #region ==================== ATTRIBUTES ====================

        public string Value { get; set; }

        #endregion ==================== ATTRIBUTES ====================

        #region ==================== CONSTRUCTORS ====================

        public TableValue()
            : base()
        { }

        #endregion ==================== CONSTRUCTORS ====================
    }
}