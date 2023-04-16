using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Home_5
{
    public class MarkCalculator
    {
        Random rnd = new Random();



        /// <summary>
        /// Student calculater with best Mark of math 
        /// </summary>
        /// <param name="ArrayOfStudent"></param>
        /// <returns></returns>
        public Student MathMarkCalc(Student[] ArrayOfStudent)
        {

            Student bestStudentMath = ArrayOfStudent[0];


            for (int i = 0; i < ArrayOfStudent.Length; i++)
            {

                if (bestStudentMath.MathMark < ArrayOfStudent[i].MathMark)
                {
                    bestStudentMath = ArrayOfStudent[i];
                }

            }
            return bestStudentMath;
        }


        /// <summary>
        /// Student calculater with best Mark of PhysicalEducation
        /// </summary>
        /// <param name="ArrayOfStudent"></param>
        /// <returns></returns>
        public Student PhysicalEducationMarkCalc(Student[] ArrayOfStudent)
        {

            Student bestStudentPhy = ArrayOfStudent[0];



            for (int i = 0; i < ArrayOfStudent.Length; i++)
            {
                if (bestStudentPhy.PhysicalEducationMark < ArrayOfStudent[i].PhysicalEducationMark)
                {
                    bestStudentPhy = ArrayOfStudent[i];
                }

            }
            return bestStudentPhy;
        }

        /// <summary>
        /// Student calculater with best Mark of Biology
        /// </summary>
        /// <param name="ArrayOfStudent"></param>
        /// <returns></returns>
        public Student BiologyMarkCalc(Student[] ArrayOfStudent)
        {
            Student bestStudentBio = ArrayOfStudent[0];

            for (int i = 0; i < 5; i++)
            {

                if (bestStudentBio.BiologyMark < ArrayOfStudent[i].BiologyMark)
                {
                    bestStudentBio = ArrayOfStudent[i];
                }
            }
            return bestStudentBio;
        }


        /// <summary>
        /// Give reward for best student
        /// </summary>
        /// <param name="bestStudent"></param>
        /// <returns></returns>
        public Student StudentReward(Student bestStudent)
        {
            {
                bestStudent.Reward += rnd.Next(1, 100);
            }
            return bestStudent;
        }

        /// <summary>
        /// Update group students with reward for best student and show them on screen
        /// </summary>
        /// <param name="arrayOfStudent"></param>
        /// <returns></returns>
        public Student[] BestStudentCalc(Student[] arrayOfStudent)
        {
            StudentDisplayer studentDisplayer = new StudentDisplayer();

            Student bestStudentMath = MathMarkCalc(arrayOfStudent);
            Student bestStudentPhysicalEducation = PhysicalEducationMarkCalc(arrayOfStudent);
            Student bestStudentBiology = BiologyMarkCalc(arrayOfStudent);

            for (int i = 0; i < arrayOfStudent.Length; i++)
            {
                if (arrayOfStudent[i] == bestStudentMath)
                {
                    arrayOfStudent[i] = StudentReward(bestStudentMath);
                }
            }
            Console.WriteLine("\n\nbest math student");
            studentDisplayer.DisplayStudent(bestStudentMath);

            for (int i = 0; i < arrayOfStudent.Length; i++)
            {
                if (arrayOfStudent[i] == bestStudentPhysicalEducation)
                {
                    arrayOfStudent[i] = StudentReward(bestStudentPhysicalEducation);
                }
            }
            Console.WriteLine("\n\nbest PhysicalEducation student");
            studentDisplayer.DisplayStudent(bestStudentPhysicalEducation);

            for (int i = 0; i < arrayOfStudent.Length; i++)
            {
                if (arrayOfStudent[i] == bestStudentBiology)
                {
                    arrayOfStudent[i] = StudentReward(bestStudentBiology);
                }
            }
            Console.WriteLine("\n\nbest biology student");
            studentDisplayer.DisplayStudent(bestStudentBiology);

            return arrayOfStudent;
        }

        /// <summary>
        /// Avarage mark for all Group and show them on screen
        /// </summary>
        /// <param name="arrayOfStudent"></param>
        public void AvarageGroupMark(Student[] arrayOfStudent)
        {
            double avarageMath = 1;
            double avaragePhy = 1;
            double avarageBio = 1;
            double mathSum = 0;
            double phySum = 0;
            double bioSum = 0;

            for (int i = 0; i < arrayOfStudent.Length; i++)
            {
                mathSum += arrayOfStudent[i].MathMark;
                phySum += arrayOfStudent[i].PhysicalEducationMark;
                bioSum += arrayOfStudent[i].BiologyMark;
            }
            avarageMath = phySum / arrayOfStudent.Length;
            avaragePhy = phySum / arrayOfStudent.Length;
            avarageBio = bioSum / arrayOfStudent.Length;

            Console.WriteLine($"For {arrayOfStudent[0].Group} avarage math mark is:{avarageMath:F2}");
            Console.WriteLine($"For {arrayOfStudent[0].Group} avarage PhysicalEducation mark is:" + avaragePhy);
            Console.WriteLine($"For {arrayOfStudent[0].Group} avarage Biology mark is: " + avarageBio);
            Console.WriteLine("\n\n");
        }

        }

    }
