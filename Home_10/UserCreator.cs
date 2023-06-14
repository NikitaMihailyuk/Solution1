using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_10
{
    public class UserCreator
    {
        public User[] UserCreates() {

            User[] Users = {new User ("Ivanov","Ivan","ivanovich"),
                new User ("Volnova","Natalia","Vetalievna"),
                new User ("Mihailyuk","Nikita","Evgenievich"),
                new User ("Popov","Petr","Petrovich"),
                new User ("Sanova","Anna","Nikolaevna"),
                new User ("Krokodil","Gena","Genadievich"),
                new User ("ktoto","bezochestva","")
            };
            return Users;
        
        }
    }
}
