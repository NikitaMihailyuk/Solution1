using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Home_6
{
    public class Patient : Person
    {

        public IlnessType IlnessType {get; set; }
        public bool Cured { get; set; }

        public Patient(string name, IlnessType ilnessType,bool cured) : base(name)
        {
            IlnessType = ilnessType;
            Cured = cured;
        }
        public  override void ShowInfo()
        {
            Console.WriteLine("The patients name is: ");
            base.ShowInfo();
            Console.Write(" With ilnesstype: " + IlnessType);
        }
        public void TreatmentInfo()
        {
            ShowInfo();

            if (Cured == true)
            {
                Console.Write(" Was treatment");
            }
            else { Console.Write("  Wasnt treatment"); }
            Console.WriteLine();
        }

        public void ShowPatients(Patient[] patients)
        {
            foreach (Patient pat in patients)
            {
               TreatmentInfo(); 
            }
        }
    }

}
