namespace CustomersManager.Business.DTOs
{
    public struct ContactDTO
    {
        #region ==================== ATTRIBUTES ====================

        public string Id;
        public string Name;
        public string Value;
        public string Description;

        #endregion ==================== ATTRIBUTES ====================

        #region ==================== METHODS ====================

        public Models.Civil.Contact Map()
        {
            return (new Models.Civil.Contact()
            {
                Id = Id,
                Name = Name,
                Value = Value,
                Description = Description
            });
        }

        public void Map(Models.Civil.Contact contact)
        {
            Id = contact.Id;
            Name = contact.Name;
            Value = contact.Value;
            Description = contact.Description;
        }

        #endregion ==================== METHODS ====================
    }
}