

using System;
using INJURY.DataAccess.Context;
using INJURY.DataAccess.Models;
using VetInfo.dataAcess.Models;

namespace VetInfo.dataAcess.Repositories
{
    public class InjuryRepository
    {
        private SQLFundamentalsContext _dbContext;

        public InjuryRepository(SQLFundamentalsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int CreateVetInfo(InjuryModels injury)
        {

            _dbContext.Add(injury);
            _dbContext.SaveChanges();

            return injury.InjuryID;
        }

        public int UpdateVetInfo(InjuryModels injury)
        {
            InjuryModels injury = _dbContext.vetModels.Find(injury.InjuryID)!;

            injury.LastName = injury.LastName;
            injury.FirstName = injury.FirstName;
            injury.Address = injury.Address;
            injury.City = injury.City;
            injury.Injury = injury.Injury;


            _dbContext.SaveChanges();

            return injury.vetID;
        }

        public bool DeleteVetInfo(int injury)
        {
            InjuryModels injury = _dbContext.vetModels.Find(injury)!;
            _dbContext.Remove(injury);
            _dbContext.SaveChanges();

            return true;
        }

        public List<InjuryModels> GetAllVetInfo()
        {
            List<InjuryModels> injuryList = _dbContext.injuryList.ToList();

            return injuryList;
        }

        public InjuryModels GetVetInfo(int ID)
        {
            InjuryModels account = _dbContext.vetModels.Find(ID)!;

            return account;
        }
    }
}
