namespace CustomersManager.Business.DTOs
{
    public struct AddressDTO
    {
        #region ==================== ATTRIBUTES ====================

        public string Id;
        public string Name;
        public string Street;
        public int Number;
        public string Complement;
        public string Neighborhood;
        public string ZipCode;
        public string City;
        public string Country;
        public string State;
        public string Description;

        #endregion ==================== ATTRIBUTES ====================

        #region ==================== METHODS ====================

        public Models.Localization.Address Map()
        {
            return (new Models.Localization.Address()
            {
                Id = Id,
                Name = Name,
                Street = Street,
                Number = Number,
                Complement = Complement,
                Neighborhood = Neighborhood,
                ZipCode = ZipCode,
                City = City,
                Country = Country,
                State = State,
                Description = Description
            });
        }

        public void Map(Models.Localization.Address address)
        {
            Id = address.Id;
            Name = address.Name;
            Street = address.Street;
            Number = address.Number;
            Complement = address.Complement;
            Neighborhood = address.Neighborhood;
            ZipCode = address.ZipCode;
            City = address.City;
            Country = address.Country;
            State = address.State;
            Description = address.Description;
        }

        #endregion ==================== METHODS ====================
    }
}