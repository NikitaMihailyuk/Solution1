using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_6
{
    public class Doctor : Person
    {
        public Profession Profession { get; set; }


        public Doctor(string name, Profession profession) : base(name)
        {
            Profession = profession;
        }


        public override void ShowInfo()
        {
            Console.WriteLine($"Doctor name is ");
            base.ShowInfo();
            Console.WriteLine($" With Profession: {Profession}");
            Console.WriteLine();
        }


        /// <summary>
        /// Treating logic
        /// </summary>
        /// <param name="patients"></param>
        /// <returns></returns>
        public Patient[] Treat(Patient[] patients)
        {
            for (int i = 0; i < patients.Length; i++)
            {
                switch (patients[i].IlnessType)
                {
                    case IlnessType.Other:
                        patients[i]=TherapistTreat(patients[i]);
                        break;
                    case IlnessType.Teeth:
                        patients[i] = OphthalmologistTreat(patients[i]);
                        break;
                    case IlnessType.Eyes:
                        patients[i] = DentistTreat(patients[i]);
                        break;
                    default:
                        patients[i] = patients[i];
                        break;
                }
            }
            return patients;
        }

        /// <summary>
        /// Patients treating
        /// </summary>
        /// <param name="patient"></param>
        /// <returns></returns>
        internal Patient TherapistTreat(Patient patient)
        {
            patient.Cured = true;
            return patient;
        }


        internal Patient OphthalmologistTreat(Patient patient)
        {
            patient.Cured = true;
            return patient;
        }


        internal Patient DentistTreat(Patient patient)
        {
            patient.Cured = true;
            return patient;
        }
    }
}
