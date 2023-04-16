using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Home_5
{
    /*
     * 1. Coздайте класс Student, в классе используйте поля Id, Name, Age, Group, MathMark (Оценка по математике от 1 до 10 включительно), 
    PhysicalEducationMark (Оценка по физкультуре от 1 до 10),
    BiologyMark (Оценка по биологии от 1 до 10), Reward 
    (денежное вознаграждение за хорошую учебу)
     Допустим есть 3 группы (Group1, Group2, Group3).
    Создайте 3 массива студентов по 5 в каждой группе. Оценки по дисциплинам задайте с использованием Random

     2. Создайте метод вывода в консоль студента из каждой группы с наилучшей оценкой по Математике. 
    Если существуют студенты с одинаковыми наилучшими оценками - выведите любого из них. (ex: Anton, Math mark: 10)

     3. Создайте метод вывода в консоль студента из каждой группы с наилучшей оценкой по Физкультуре
    . Если существуют студенты с одинаковыми наилучшими оценками - выведите любого из них.

     4. Создайте метод вывода в консоль студента из каждой группы с наилучшей оценкой по Биологии. Е
    сли существуют студенты с одинаковыми наилучшими оценками - выведите любого из них.

    5. Установите каждому из лучших студентов выше - денежное вознаграждение в рублях - reward (rand: 0 - 100)
    (предусмотрите, чтобы нельзя было установить значение reward < 1 рубля)

    6. Создайте методы подсчета и вывода среднего балла группы студентов по каждой из дисциплин и вывода этой информации в консоль (разные методы)
  (ex: Group1, avarage mark math: 8.3)

  7. Создайте метод расчета среднего балла группы студентов по всем 3 дисциплинам 
    (средняя оценка группы по каждой дисциплине / количество дисциплин)
 и выведите эту информацию в консоль. 

  (Avearage mark of Group1 - Math, PhysicalEducation, Biology - 8.3)
   8. Добавьте каждому студенту из группы с наибольшим средним баллом по всем дисциплинам произвольный reward.

   9. Выведите на экран студента с наибольшим reward. Если таких студентов несколько - выведите их всех.
     
     * 

   */
    internal class Program
    {
        static void Main(string[] args)
        {


            //task 1, 2, 3 ,4 ,5 
            Console.WriteLine("Task 1,2,3,4,5");

            StudentCreator studentsCreator = new StudentCreator();
            MarkCalculator markCalculator = new MarkCalculator();
            StudentDisplayer studentDisplayer = new StudentDisplayer();
           
            Student[] arrayOfStudents1 = studentsCreator.CreateStudents1("Group a");
            arrayOfStudents1 = markCalculator.BestStudentCalc(arrayOfStudents1);
            studentDisplayer.DisplayStudents(arrayOfStudents1);

            Student[] arrayOfStudents2 = studentsCreator.CreateStudents1("Group b");
            arrayOfStudents2 = markCalculator.BestStudentCalc(arrayOfStudents2);
            studentDisplayer.DisplayStudents(arrayOfStudents2);


            Student[] arrayOfStudents3 = studentsCreator.CreateStudents1("Group C");
            arrayOfStudents3 = markCalculator.BestStudentCalc(arrayOfStudents3);
            studentDisplayer.DisplayStudents(arrayOfStudents3);



            Console.WriteLine("Task 6");
            // avarage mark groups
            markCalculator.AvarageGroupMark(arrayOfStudents1);
            markCalculator.AvarageGroupMark(arrayOfStudents2);
            markCalculator.AvarageGroupMark(arrayOfStudents3);

            Console.WriteLine("Task 7");
            Console.WriteLine(" and Task 8");

            //Class of classes 
            Groups groups1 = new Groups (arrayOfStudents1, arrayOfStudents2, arrayOfStudents3);

           GroupsCalculator groupsCalculator = new GroupsCalculator();
           groupsCalculator.BestGroups(groups1);

            arrayOfStudents1 = groups1.Group1;
            arrayOfStudents2 = groups1.Group2;
            arrayOfStudents3 = groups1.Group3;

            studentDisplayer.DisplayStudents(arrayOfStudents1);
            studentDisplayer.DisplayStudents(arrayOfStudents2);
            studentDisplayer.DisplayStudents(arrayOfStudents3);

            Console.WriteLine(" Task 9 wasn't completed");
            groupsCalculator.RichStudents(groups1);

            Console.ReadLine();

        }

    }
}
