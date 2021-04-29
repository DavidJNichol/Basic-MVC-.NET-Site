using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.International_Currency
{
    public class SouthAfricanBankNote : BankNote
    {
        public SouthAfricanBankNote()
        {
            this.Name = "Default South African BankNote";
        }

        public override string About()
        {
            string strAbout = $"{this.Name} is from { System.DateTime.Now.Year }. It is worth R${MonetaryValue}.";

            return "South African " + strAbout;
        }

        public static List<ICoin> GetSANoteList()
        {
            List<ICoin> noteList = new List<ICoin>()
            {
                new OneHundredRandNote(),
                new TwoHundredRandNote()
            };

            return noteList;

        }
    }
}
