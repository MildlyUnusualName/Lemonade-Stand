
using System.Collections.Generic;

namespace Lemonade_Stand_Code{
    public class Customer
    {
        int icePreference;
        int lemonPreference;
        int sugarPreference;

        public Customer(int lemon, int sugar, int ice)
        {
            this.lemonPreference = lemon;
            this.sugarPreference = sugar;
            this.icePreference = ice;
        }

        public static void CreateCustomers(int temperature, string forecast, List<Customer> c)
        {

            if (forecast == "Cloudy")
            {

            }
            else if (forecast == "Sunny")
            {

            }else if (forecast == "Rainy")
            {

            }else if (forecast == "Hazy")
            {

            }


        }
    }
}