using System;

namespace CustomersManager.Business.DTOs
{
    public struct DocumentDTO
    {
        #region ==================== ATTRIBUTES ====================

        public string Id;
        public string Name;
        public string Value;
        public string Authority;
        public DateTime? ExpirationDate;
        public DateTime? IssueDate;
        public string IssuingCountry;

        #endregion ==================== ATTRIBUTES ====================

        #region ==================== METHODS ====================

        public Models.Civil.Document Map()
        {
            return (new Models.Civil.Document()
            {
                Id = Id,
                Name = Name,
                Value = Value,
                Authority = Authority,
                ExpirationDate = ExpirationDate,
                IssueDate = IssueDate,
                IssuingCountry = IssuingCountry
            });
        }

        public void Map(Models.Civil.Document document)
        {
            Id = document.Id;
            Name = document.Name;
            Value = document.Value;
            Authority = document.Authority;
            ExpirationDate = document.ExpirationDate;
            IssueDate = document.IssueDate;
            IssuingCountry = document.IssuingCountry;
        }

        #endregion ==================== METHODS ====================
    }
}