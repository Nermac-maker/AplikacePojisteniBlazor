using System.Linq;
using System.Collections.Generic;
using AplikacePojisteniBlazor.Data;
using AplikacePojisteniBlazor.Models;
using System.ComponentModel.DataAnnotations;

namespace AplikacePojisteniBlazor.Services
{
    public class InsuranceService
    {
        private List<ClientData> ClientsData { get; set; } = new List<ClientData>();
        private List<Insurance> Insurances { get; set; } = new List<Insurance>();


        public InsuranceService()
        {
            // Inicializace dat

            ClientsData.Add(new ClientData
            {
                Id = 1,
                FirstName = "Jan",
                LastName = "Novák",
                Email = "novak.jan@gmail.com",
                Phone = "123456789"
            });
            ClientsData.Add(new ClientData
            {
                Id = 2,
                FirstName = "Petr",
                LastName = "Svoboda",
                Email = "petr.svoboda@gmail.com",
                Phone = "987654321"

            });


            Insurances.Add(new Insurance
            {
                Id = 1,
                PolicyNumber = "POL001",
                Type = "Auto",
                Premium = 5000,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddYears(1),
                ClientId = 1
            });
            Insurances.Add(new Insurance
            {


                Id = 2,
                PolicyNumber = "POL002",
                Type = "Dům",
                Premium = 10000,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddYears(2),
                ClientId = 2
            });


        }

        public List<Insurance> GetInsurances() => Insurances;

        public List<ClientData> GetClientsData() => ClientsData;

        public void AddInsurance(Insurance insurance)
        {
            insurance.Id = Insurances.Any() ? Insurances.Max(i => i.Id) + 1 : 1;
            Insurances.Add(insurance);
        }
        public void UpdateInsurance(Insurance insurance)
        {
            var existing = Insurances.FirstOrDefault(i => i.Id == insurance.Id);
            if (existing != null)
            {
                existing.PolicyNumber = insurance.PolicyNumber;
                existing.Type = insurance.Type;
                existing.Premium = insurance.Premium;
                existing.StartDate = insurance.StartDate;
                existing.EndDate = insurance.EndDate;
                existing.ClientId = insurance.ClientId;
            }
        }

        public void DeleteInsurance(int id)
        {
            var insurance = Insurances.FirstOrDefault(i => i.Id == id);
            if (insurance != null)
            {
                Insurances.Remove(insurance);
            }
        }
        public Insurance GetInsuranceById(int id) => Insurances.FirstOrDefault(i => i.Id == id);
    }
}
