using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_8
{
    public class ShowInformation
    {
        /// <summary>
        /// Show ration for all people 
        /// with logic
        /// </summary>
        public void ShowRation()
        {
            PersonCreator personCreator = new PersonCreator();
            Person[] persons = personCreator.PersonCreates();

            foreach (Person person in persons)
            {
                RationCreator rationCreator = new RationCreator();

                Console.WriteLine("_______________________________________________________");
                Console.WriteLine("Menu for " + person.Name);
                Console.WriteLine("_______________________________________________________");

                Dictionary<string, List<Ration>> ration = rationCreator.WeekRation();
                ration = rationCreator.RationCorrector(person.MaxNumberOfCalories, ration);

                double maxCall = 0;

                foreach (KeyValuePair<string, List<Ration>> pair in ration)
                {
                    maxCall = 0;
                    Console.WriteLine($" \n\nDay of Week: {pair.Key} ");
                    foreach (var val in pair.Value)
                    {
                        Console.WriteLine($"{val.ProductName} Callories {val.Callories}");
                        maxCall += val.Callories;
                    }
                    Console.WriteLine("Max callories in that day:" + maxCall);
                }
            }
        }
    }
}
