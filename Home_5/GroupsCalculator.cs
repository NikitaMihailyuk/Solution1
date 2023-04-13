using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_5
{
    public class GroupsCalculator
    {
        public Groups BestGroups(Groups groups)
        {
            double avarageGroup1Mark = 0;
            double avarageGroup2Mark = 0;
            double avarageGroup3Mark = 0;

            for (int i = 0; i < groups.Group1.Length; i++)
            {

                avarageGroup1Mark += (groups.Group1[i].BiologyMark + groups.Group1[i].MathMark + groups.Group1[i].PhysicalEducationMark);
                avarageGroup2Mark += (groups.Group2[i].BiologyMark + groups.Group2[i].MathMark + groups.Group2[i].PhysicalEducationMark);
                avarageGroup3Mark += (groups.Group3[i].BiologyMark + groups.Group3[i].MathMark + groups.Group3[i].PhysicalEducationMark);
            }

            avarageGroup1Mark = avarageGroup1Mark / groups.Group1.Length / 3;
            avarageGroup2Mark = avarageGroup2Mark / groups.Group2.Length / 3;
            avarageGroup3Mark = avarageGroup3Mark / groups.Group3.Length / 3;

            Console.WriteLine("avvarage mark Groups");
            Console.WriteLine($" avarage mark gor Group A: {avarageGroup1Mark:F2}");
            Console.WriteLine($" avarage mark gor Group B: {avarageGroup2Mark:F2}");
            Console.WriteLine($" avarage mark gor Group C: {avarageGroup3Mark:F2}");

            MarkCalculator markCalculator = new MarkCalculator();

            if (avarageGroup1Mark >= avarageGroup2Mark && avarageGroup1Mark >= avarageGroup3Mark)
            {

                for (int i = 0; i < groups.Group1.Length; i++)
                {
                    groups.Group1[i] = markCalculator.StudentReward(groups.Group1[i]);
                }
            }

            if (avarageGroup2Mark >= avarageGroup1Mark && avarageGroup2Mark >= avarageGroup3Mark)
            {

                for (int i = 0; i < groups.Group1.Length; i++)
                {
                    groups.Group2[i] = markCalculator.StudentReward(groups.Group2[i]);
                }
            }

            if (avarageGroup3Mark >= avarageGroup2Mark && avarageGroup3Mark >= avarageGroup1Mark)
            {

                for (int i = 0; i < groups.Group1.Length; i++)
                {
                    groups.Group3[i] = markCalculator.StudentReward(groups.Group3[i]);
                }
            }
            return groups;
        }

        internal void RichStudents(Groups groups1)
        {

            Student[] richStudents = new Student[1];
            richStudents[0] = groups1.Group1[0];
            int j = 1;

            for (int i = 0; i < groups1.Group1.Length; i++)
            {
                if (richStudents[0].Reward < groups1.Group1[i].reward)
                {
                    richStudents[0] = groups1.Group1[i];
                }
                else if (richStudents[0].Reward == groups1.Group1[i].Reward && richStudents[0].Reward > groups1.Group2[j].Reward && richStudents[0].Reward > groups1.Group3[j].Reward)
                {
                    {
                        Array.Resize(ref richStudents, ++j);
                        richStudents[j-1] = groups1.Group1[i];
                    }
                }

            }
            for (int i = 0; i < groups1.Group2.Length; i++)
            {
                if (richStudents[0].Reward < groups1.Group1[i].reward)
                {
                    richStudents[0] = groups1.Group2[i];
                }
                else if (richStudents[0].Reward == groups1.Group1[i].Reward && richStudents[0].Reward > groups1.Group2[j].Reward && richStudents[0].Reward > groups1.Group3[j].Reward)
                {
                    {
                        Array.Resize(ref richStudents, ++j);
                        richStudents[j-1] = groups1.Group2[i];
                    }
                }
            }

            for (int i = 0; i < groups1.Group3.Length; i++)
            {
                if (richStudents[0].Reward < groups1.Group1[i].reward && richStudents[0].Reward < groups1.Group2[i].reward && richStudents[0].Reward < groups1.Group3[i].reward)
                {
                    richStudents[0] = groups1.Group3[i];
                }
                else if (richStudents[0].Reward == groups1.Group1[i].Reward && richStudents[0].Reward > groups1.Group2[j].Reward && richStudents[0].Reward > groups1.Group3[j].Reward)
                {
                    {
                        Array.Resize(ref richStudents, ++j);
                        richStudents[j-1] = groups1.Group3[i];
                    }
                }
            }
            StudentDisplayer studentDisplayer = new StudentDisplayer();
            studentDisplayer.DisplayStudents(richStudents);

        }
           
    }
}
