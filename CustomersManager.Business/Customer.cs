using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CustomersManager.Business
{
    public static class Customer
    {
        #region ==================== ATTRIBUTES ====================

        private static string path = @"C:\Data";

        #endregion ==================== ATTRIBUTES ====================

        #region ==================== METHODS ====================

        private static List<Models.Entity.Profile> GetData()
        {
            List<Models.Entity.Profile> result = new List<Models.Entity.Profile>();

            foreach (string item in Directory.GetFiles(path, "*.json"))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(item))
                    {
                        result.Add(JsonConvert.DeserializeObject<Models.Entity.Profile>(sr.ReadToEnd()));
                    }
                }
                catch (IOException e)
                {
                    return (new List<Models.Entity.Profile>());
                }
            }

            return (result);
        }

        private static void UpdateData(List<Models.Entity.Profile> db)
        {
            foreach (Models.Entity.Profile profile in db)
                File.WriteAllText(Path.Combine(path, string.Format("{0}.json", profile.Id)), JsonConvert.SerializeObject(profile));
        }

        public static bool Insert(DTOs.CustomerDTO customer)
        {
            List<Models.Entity.Profile> db = GetData();
            Models.Entity.Profile newCustomer = customer.Map();

            Models.Civil.Document cpf =
                (from document in newCustomer.Documents
                 where document.Name.ToLower() == "cpf"
                 select document).FirstOrDefault();

            if (cpf != null)
            {
                Models.Entity.Profile existingUser =
                    (from profile in db
                     from document in profile.Documents
                     where document.Name.ToLower() == "cpf"
                     && document.Value == cpf.Value
                     select profile).FirstOrDefault();

                if (existingUser != null)
                    return (false);
            }

            newCustomer.NewId();
            db.Add(newCustomer);
            UpdateData(db);

            return (true);
        }

        public static bool Update(DTOs.CustomerDTO customer)
        {
            List<Models.Entity.Profile> db = GetData();
            Models.Entity.Profile updateCustomer = customer.Map();

            for (int i = 0; i < db.Count; i++)
                if (db[i].Id == updateCustomer.Id)
                {
                    db[i] = updateCustomer;
                    UpdateData(db);

                    return (true);
                }

            return (false);
        }

        public static DTOs.CustomerDTO? SearchById(string id)
        {
            List<Models.Entity.Profile> db = GetData();

            Models.Entity.Profile search =
                (from profile in db
                 where profile.Id == id
                 select profile).FirstOrDefault();

            if (search != null)
            {
                DTOs.CustomerDTO result = new DTOs.CustomerDTO();
                result.Map(search);

                return (result);
            }

            return (null);
        }

        public static List<DTOs.CustomerDTO> GetAll()
        {
            List<Models.Entity.Profile> db = GetData();
            List<DTOs.CustomerDTO> result = new List<DTOs.CustomerDTO>();

            if (db.Count == 0)
                return (null);

            foreach (Models.Entity.Profile profile in db)
            {
                DTOs.CustomerDTO newCustomer = new DTOs.CustomerDTO();
                newCustomer.Map(profile);
                result.Add(newCustomer);
            }

            return (result);
        }

        public static bool Delete(string id)
        {
            List<Models.Entity.Profile> db = GetData();
            int index = -1;

            for (int i = 0; i < db.Count; i++)
                if (db[i].Id == id)
                {
                    index = i;
                    break;
                }

            if (index >= 0)
            {
                File.Delete(Path.Combine(path, string.Format("{0}.json", id)));

                return (true);
            }

            return (false);
        }

        #endregion ==================== METHODS ====================
    }
}