using System;


namespace VetInfo.dataAcess.Models
{
    public partial class InjuryModels
    {
        public int InjuryID { get; set; }
        public string LastName { get; set; }
        public bool FirstName { get; set; }
        public decimal Address { get; set; }
        public string City { get; set; }
        public char Injury { get; set; }



        public InjuryModels(int injuryid, String lastName, bool firstname, char address, string city, Char injury)
        {
            InjuryID = injuryid;
            LastName = lastName;
            FirstName = firstname;
            Address = address;
            City = city;
            Injury = injury;




        }
        public InjuryModels()
        {

        }
    }
}
