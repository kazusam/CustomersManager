using System.Collections.Generic;

namespace CustomersManager.Business.DTOs
{
    public struct CustomerDTO
    {
        #region ==================== ATTRIBUTES ====================

        public string Id;
        public string Name;
        public int Age;
        public Models.Entity.Enumerators.Gender Gender;
        public IList<AddressDTO> Addresses;
        public IList<ContactDTO> Contacts;
        public IList<DocumentDTO> Documents;

        #endregion ==================== ATTRIBUTES ====================

        #region ==================== METHODS ====================

        public Models.Entity.Profile Map()
        {
            Models.Entity.Profile result = new Models.Entity.Profile()
            {
                Id = Id,
                Name = Name,
                Age = Age,
                Gender = Gender
            };

            foreach (AddressDTO address in Addresses)
                result.Addresses.Add(new Models.Entity.ProfileAddress() { Address = address.Map() });

            foreach (ContactDTO contact in Contacts)
                result.Contacts.Add(contact.Map());

            foreach (DocumentDTO document in Documents)
                result.Documents.Add(document.Map());

            return (result);
        }

        public void Map(Models.Entity.Profile profile)
        {
            Id = profile.Id;
            Name = profile.Name;
            Age = profile.Age;
            Gender = profile.Gender;
            Addresses = new List<AddressDTO>();
            Contacts = new List<ContactDTO>();
            Documents = new List<DocumentDTO>();

            foreach (Models.Entity.ProfileAddress item in profile.Addresses)
            {
                AddressDTO newAddress = new AddressDTO();
                newAddress.Map(item.Address);
                Addresses.Add(newAddress);
            }

            foreach (Models.Civil.Contact contact in profile.Contacts)
            {
                ContactDTO newContact = new ContactDTO();
                newContact.Map(contact);
                Contacts.Add(newContact);
            }

            foreach (Models.Civil.Document document in profile.Documents)
            {
                DocumentDTO newDocument = new DocumentDTO();
                newDocument.Map(document);
                Documents.Add(newDocument);
            }
        }

        #endregion ==================== METHODS ====================
    }
}