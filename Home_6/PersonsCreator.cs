using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_6
{
    public class PersonsCreator
    {
        public Doctor[] DoctorsCreator()
        {
            Doctor doctor = new Doctor("Nikita", Profession.therapist);
            doctor.ShowInfo();
            Doctor doctor2 = new Doctor("Masha", Profession.ophthalmologist);
            doctor2.ShowInfo();
            Doctor doctor3 = new Doctor("Sasha", Profession.dentist);
            doctor3.ShowInfo();
            Doctor[] doctors = { doctor, doctor2, doctor3 };
            return doctors;
        }


        public Patient[] PatientCreator()
        {
            Patient[] patients = {new Patient("Patient 1 AAAA", IlnessType.Teeth, false),
                new Patient("Patient 2 BBBB", IlnessType.Teeth, false),
                new Patient("Patient 3 CCCC", IlnessType.Eyes, false),
                new Patient("Patient 4 EEEE", IlnessType.Teeth, false),
                new Patient("Patient 5 WWWWW", IlnessType.Other, false),
                new Patient("Patient 6 SXXXXX", IlnessType.Other, false),
                new Patient("Patient 7 ZZZZ", IlnessType.Teeth, false),
                new Patient("Patient 8 VVVVV", IlnessType.Eyes, false),
                new Patient("Patient 9 XXXXX", IlnessType.Other, false),
                new Patient("Patient 10  3434", IlnessType.Other, false),
                new Patient("Patient 11 41234", IlnessType.Eyes, false)};
            return patients;
        }
    }
}
