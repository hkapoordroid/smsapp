using System;
using PropertyChanged;

namespace XFSMS.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Compensation
    {

        public Constants.ServiceTypes ServiceType { get; set; }
        public Constants.Currency CurrencyType{ get; set; }

        public string Offering{ get; set; }
        public string Asking{ get; set; }
        bool RequireProductSample{ get; set; }



        public Compensation()
        {
            ServiceType = Constants.ServiceTypes.GiveAway;
            Asking = "10";
            Offering = "10";
            CurrencyType = Constants.Currency.Dollars;
            RequireProductSample = true;
        }
    }


   
}
