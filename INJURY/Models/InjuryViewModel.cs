using Injury.DataAccess.Repositories;
using INJURY.DataAccess.Models;
using INJURY.DataAcess.Context;

namespace INJURY.Models
{
    public class InjuryViewModel
	{
		private InjuryRepository _repo;

		public List<InjuryModels> InjuryList { get; set; }

		public InjuryModels CurrentInjury { get; set; }

		public bool IsActionSuccess { get; set; }

		public string ActionMessage { get; set; }

		public InjuryViewModel(SQLFundamentalsContext context )
		{
			_repo = new InjuryRepository(context);
			InjuryList = GetAllInjury();
			CurrentInjury = InjuryList.FirstOrDefault();
		}
		public InjuryViewModel(SQLFundamentalsContext context, int injuryid)
		{
			_repo = new InjuryRepository(context);
			InjuryList = GetAllInjury();

			if (injuryid >0)
			{
				CurrentInjury = GetInjury(injuryid);
            }
			else
            {
				CurrentInjury = new InjuryModels();
			}

		}

		public void SaveAccount(InjuryModels account)
		{
			if (account.InjuryID > 0) 
			{
				_repo.UpdateInjury(account);
			}
			else
			{
				account.InjuryID = _repo.CreateInjury(account);
			}

			InjuryList = GetAllInjury();
			CurrentInjury = GetInjury(account.InjuryID);
		}
		
		public void RemoveAccount(int accountId)
		{
			_repo.DeleteInjury(accountId);
			InjuryList = GetAllInjury();
			CurrentInjury = InjuryList.FirstOrDefault();
		}

		

        private InjuryModels GetInjury(int injuryid)
        {
			return _repo.GetInjury(injuryid);
        }



        private List<InjuryModels> GetAllInjury()
        {
			return _repo.GetAllInjury();
        }

        
	}
}

