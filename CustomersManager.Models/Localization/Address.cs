using System.Collections.Generic;

namespace CustomersManager.Models.Localization
{
    public class Address : Base.Abstracts.TableName
    {
        #region ==================== ATTRIBUTES ====================

        public string Street { get; set; }
        public int Number { get; set; }
        public string Complement { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Description { get; set; }

        public virtual IList<Entity.ProfileAddress> Profiles { get; set; } = new List<Entity.ProfileAddress>();

        #endregion ==================== ATTRIBUTES ====================

        #region ==================== CONSTRUCTORS ====================

        public Address()
            : base()
        { }

        #endregion ==================== CONSTRUCTORS ====================
    }
}