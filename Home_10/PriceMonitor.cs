using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Home_10
{
    public class PriceMonitor
    {
        public delegate Home[] PriceInfo(Home[] homes);
        public event Action<Home> notify;

    /// <summary>
    /// Logic for options and Delegate
    /// </summary>
    /// <param name="homes"></param>
    /// <param name="typeinfo"></param>
        public void LogicPrice(Home[] homes, Typeinfo typeinfo)
        {
            PriceInfo pinfo;
            switch (typeinfo)
            {
                case Typeinfo.Avarage:
                    pinfo = AvaragePrice;
                    break;
                case Typeinfo.Max:
                    pinfo = MaxPrice;
                    break;
                case Typeinfo.Min:
                    pinfo = MinPrice;
                    break;
                default: pinfo = null; break;
            }
            ShowPrice(pinfo(homes));
        }


        /// <summary>
        ///  Show all info
        /// </summary>
        /// <param name="homes"></param>
        public void ShowPrice(Home[] homes)
        {
            foreach (Home home in homes)
            {
                {
                    Console.WriteLine(home.Adress + " with price: " + home.Price);
                }
            }
        }

        /// <summary>
        /// Avarage Price Logic
        /// </summary>
        /// <param name="homes"></param>
        /// <returns></returns>
        public static Home[] AvaragePrice(Home[] homes)
        {
            Home[] offer = homes;
            int avaragePrice = 0;

            foreach (Home build in homes)
            {
                avaragePrice += build.Price;
            }

            avaragePrice /= offer.Length;
            Console.WriteLine("Avarage price: " + avaragePrice);
            /// return all offer after, but can be logic.
            return offer;
        }

        /// <summary>
        /// Max Price Logic
        /// </summary>
        /// <param name="homes"></param>
        /// <returns></returns>
        public static Home[] MaxPrice(Home[] homes)
        {
            Home maxPrice = homes[0];
            foreach (Home build in homes)
            {
                if (maxPrice.Price <= build.Price)
                    maxPrice = build;
            }
            Home[] offer = { new Home(maxPrice.Adress, maxPrice.Price) };
            return offer;
        }

        /// <summary>
        /// Min Price Logic
        /// </summary>
        /// <param name="homes"></param>
        /// <returns></returns>
        public static Home[] MinPrice(Home[] homes)
        {
            Home maxPrice = homes[0];
            foreach (Home build in homes)
            {
                if (maxPrice.Price >= build.Price)
                    maxPrice = build;
            }
            Home[] offer = { new Home(maxPrice.Adress, maxPrice.Price) };
            return offer;
        }

        /// <summary>
        /// Logic for notify Delegate
        /// </summary>
        /// <param name="home"></param>
        public void PriceGoDown(Home[] home)
        {
            {
                List<Home> listPrices = home.ToList();
                foreach (Home build in listPrices)
                {
                    build.Price -= 5000;
                    if (build.Price < 15000)
                    {
                        notify?.Invoke(build);
                    }
                }
            }
        }
    }
}
