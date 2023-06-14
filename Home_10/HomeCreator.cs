using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_10
{
    public class HomeCreator
    {
        public Random random = new Random();
        public Home[] HomeCreates()
        {
            Home[] Homes = {
                        new Home("Pobedy 10 st.apartment 1 ", random.Next(10000, 50000)),
                        new Home("Pobedy 11 st.apartment 4",  random.Next(10000, 50000)),
                       new Home("Krasnaya 156 st. apartment 15", random.Next(10000, 50000)),
                        new Home("Krasnaya 56 st. apartment 40", random.Next(10000, 50000)),
                         new Home("Krasnaya 13 st. apartment 17", random.Next(10000, 50000)),
                         new Home("Svobody 15 st. apartment 1",  random.Next(10000, 50000)),
                        new Home("Svobody 17 st. apartment 51", random.Next(10000, 50000)),
                        new Home("Pobedy 261 st.apartment 4",  random.Next(10000, 50000)),
                         new Home("Pobedy 62 st.apartment 62", random.Next(10000, 50000)),
                         new Home("Pobedy 62 st.apartment 6", random.Next(10000, 50000)),
                        new Home("Stasova 101 st.apartment 51 ", random.Next(10000, 50000)),
                        new Home("Stasova 54 st.apartment 7",  random.Next(10000, 50000)),
                       new Home("Krasnaya 256 st. apartment 115", random.Next(10000, 50000)),
                        new Home("Krasnaya 56 st. apartment 40", random.Next(10000, 50000)),
                        new Home("Krasnaya 13 st. apartment 18", random.Next(10000, 50000)),
                        new Home("Krasnaya 23 st. apartment 17", random.Next(10000, 50000)),
                        new Home("Pobedy 333 st. apartment 33",  random.Next(10000, 50000)),
                        new Home("Svobody 227 st. apartment 21", random.Next(10000, 50000)),
            };
            return Homes;
        }
    }
}
