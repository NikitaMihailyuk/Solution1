using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_6
{
    public class ShowInformation
    {
        public void ShowPatients(Patient[] patients)
        {
            foreach (Patient pat in patients)
            {
                pat.TreatmentInfo();
            }
        }
    }
}
