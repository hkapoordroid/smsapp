using System;
namespace XFSMS.Models
{
    public class Constants
    {

        public enum BusinessTypes
        {
            Fashion,
            Beauty,
            Food,
            Sports

        }

		public enum ServiceTypes
		{
			GiveAway,
			ShoutOuts,
			TeamUp,
			Sports

		}


		public enum EventTypes
		{
			GiveAway,
			ShoutOut,
		}

		public enum EventStatus
		{
			Running,
			Completed,
            Development
		}

		public enum AdStatus
		{
			Posted,
			Removed,
			Development
		}

        public enum Platforms
		{
			instagram,
			youtube,
            facebook,
            twitter
		}

		public enum Currency
		{
			Dollars,
			Rupees
		
		}

        public Constants()
        {
        }
    }
}
