using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Priority;

namespace CustomersManager.XUnitTest
{
    [TestCaseOrderer(PriorityOrderer.Name, PriorityOrderer.Assembly)]
    public class CustomerTest
    {
        private Business.DTOs.CustomerDTO mockData = new Business.DTOs.CustomerDTO()
        {
            Name = "Cliente Teste",
            Age = 35,
            Gender = Models.Entity.Enumerators.Gender.Male,
            Addresses = new List<Business.DTOs.AddressDTO>()
            {
                new Business.DTOs.AddressDTO()
                {
                    Name = "Residencial",
                    Street = "Rua teste do teste",
                    Number = 123,
                    Complement = null,
                    Neighborhood = "Bairro TesteTeste",
                    ZipCode = "12345-678",
                    City = "Testópolis",
                    Country = "Testárnia",
                    State = "TT",
                    Description = null
                }
            },
            Contacts = new List<Business.DTOs.ContactDTO>()
            {
                new Business.DTOs.ContactDTO()
                {
                    Name = "Celular",
                    Value = "99 99999-9999"
                }
            },
            Documents = new List<Business.DTOs.DocumentDTO>()
            {
                new Business.DTOs.DocumentDTO()
                {
                    Name = "CPF",
                    Value = "123.456.789-00"
                }
            }
        };

        [Fact, Priority(0)]
        public void Post_WhenCalled_ReturnsTrue()
        {
            var response = Business.Customer.Insert(mockData);
            Assert.True(response);
        }

        [Fact, Priority(1)]
        public void Get_WhenCalled_ReturnsAllItems()
        {
            var response = Business.Customer.GetAll();
            Assert.Single(response);
        }

        [Fact, Priority(2)]
        public void Get_WhenCalled_ReturnsObjectNotNull()
        {
            var result = Business.Customer.GetAll();
            var response = Business.Customer.SearchById(result[0].Id);
            Assert.NotNull(response);
        }

        [Fact, Priority(3)]
        public void Put_WenCalled_ReturnsTrue()
        {
            var result = Business.Customer.GetAll();
            var client = result[0];
            client.Name = "Novo Nome Teste";
            var response = Business.Customer.Update(client);
            Assert.True(response);
        }

        [Fact, Priority(4)]
        public void Delete_WhenCalled_ReturnsTrue()
        {
            var result = Business.Customer.GetAll();
            var response = Business.Customer.Delete(result[0].Id);
            Assert.True(response);
        }
    }
}
