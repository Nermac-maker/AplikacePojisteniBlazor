using System.Linq;
using System.Collections.Generic;
using AplikacePojisteniBlazor.Data;
using AplikacePojisteniBlazor.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace AplikacePojisteniBlazor.Services
{
    public class InsuranceService
    {
        private readonly IAppDbContextFactory _dbContextFactory;


        public InsuranceService(IAppDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public List<Insurance> GetInsurances()
        {
            using var context = _dbContextFactory.CreateDbContext();
            return context.Insurances.ToList();
        }
        public async Task<List<ClientData>> GetClientDataAsync()
        {
            var context = _dbContextFactory.CreateDbContext();
            return await context.ClientDatas.ToListAsync();
        }
        public async Task AddClient(ClientData client)
        {
            using var context = _dbContextFactory.CreateDbContext();
            context.ClientDatas.Add(client);
            await context.SaveChangesAsync();
        }
        public void AddInsurance(Insurance insurance)
        {
            using var context = _dbContextFactory.CreateDbContext();
            context.Insurances.Add(insurance);
            context.SaveChanges();
        }
        public void DeleteInsurance(int id)
        {
            using var context = _dbContextFactory.CreateDbContext();
            var insurance = context.Insurances.Find(id);
            if (insurance != null)
            {
                context.Insurances.Remove(insurance);
                context.SaveChanges();
            }
        }
        public void UpdateInsurance(Insurance insurance)
        {
            using var context = _dbContextFactory.CreateDbContext();
            context.Insurances.Update(insurance);
            context.SaveChanges();
        }
        public Insurance GetInsuranceById(int id)
        {
            using var context = _dbContextFactory.CreateDbContext();
            return context.Insurances.Find(id);
        }
    }
}
        
        
    //    private readonly AppDbContext _context;
    //    public InsuranceService(AppDbContext context)
    //    {
    //        _context = context;
    //        //ClientsData = _context.ClientsData.ToList();
    //        //Insurances = _context.Insurances.ToList();
    //    }

    //    public List<Insurance> GetInsurances()
    //    {
    //        return _context.Insurances.ToList();
    //    }

    //    public List<ClientData> GetClientsData()
    //    {
    //        return _context.ClientsData.ToList();
    //    }
    //    public async Task AddClient(ClientData client)
    //    {
    //        _context.ClientsData.Add(client);
    //        await _context.SaveChangesAsync();
    //    }
    //    public void DeleteInsurance(int id)
    //    {
    //        var insurance = _context.Insurances.Find(id);
    //        if (insurance != null)
    //        {
    //            _context.Insurances.Remove(insurance);
    //            _context.SaveChanges();
    //        }
    //    }
    //    public void AddInsurance(Insurance insurance)
    //    {
    //        _context.Insurances.Add(insurance);
    //        _context.SaveChanges();
    //    }
    //    public void UpdateInsurance(Insurance insurance)
    //    {
    //        _context.Insurances.Update(insurance);
    //        _context.SaveChanges();
    //    }
    //    public Insurance GetInsuranceById(int id)
    //    {
    //        return _context.Insurances.Find(id);
    //    }
    //}





