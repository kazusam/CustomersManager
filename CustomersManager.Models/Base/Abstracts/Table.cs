using System;

namespace CustomersManager.Models.Base.Abstracts
{
    public abstract class Table
    {
        #region ==================== ATTRIBUTES ====================

        public string Id { get; set; }

        #endregion ==================== ATTRIBUTES ====================

        #region ==================== CONSTRUCTORS ====================

        public Table()
        {
            NewId();
        }

        #endregion ==================== CONSTRUCTORS ====================

        #region ==================== METHODS ====================

        public void NewId()
        {
            Id = Guid.NewGuid().ToString();
        }

        #endregion ==================== METHODS ====================
    }
}