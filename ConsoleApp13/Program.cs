using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            double min =0;
            bool result;
            Console.WriteLine("введите колво студентов");
            result = int.TryParse(Console.ReadLine(), out size);

            if (result)
            {
                Stack<Student> placesForDormitory = new Stack<Student>(size);
                List<Student> list = new List<Student>();
                for(int i=0;i<size;i++)
                {
                    Student student = new Student();
                    Console.WriteLine("введите данные студента " + i + "\n");
                    Console.Write("name: ");
                    student.FIO = Console.ReadLine();
                    Console.Write("group: ");
                    student.Group = Console.ReadLine();
                    Console.Write("average mark: ");
                    int mark;
                    bool check = int.TryParse(Console.ReadLine(), out mark);

                    if (check == false)
                    {
                        Console.WriteLine("not correct\n");
                    }

                    else
                    {
                        student.AverageMark= mark;
                    }

                    Console.Write("income: ");
                    double income;
                    bool check2 = double.TryParse(Console.ReadLine(), out income);

                    if (check2 == false)
                    {
                        Console.WriteLine("not correct\n");
                    }

                    else
                    {
                        if(min<income)
                        {
                            min = income;
                        }
                        student.Income = income;
                    }

                    Console.WriteLine("1 - male, 0 - female");
                    int choise;
                    bool check3 = int.TryParse(Console.ReadLine(), out choise);

                    if (check3 == false)
                    {
                        Console.WriteLine("not correct\n");
                    }

                    else
                    {
                        if(choise==1)
                        {
                            student.pol = Sex.male;
                        }

                        else if(choise==0)
                        {
                            student.pol = Sex.female;
                        }

                        else
                        {
                            Console.WriteLine("not correct, will be set default option");
                            student.pol = Sex.male;
                        }

                    }

                    Console.WriteLine("1 - fulltime, 0 - half");
                    int choise2;
                    bool check4 = int.TryParse(Console.ReadLine(), out choise2);

                    if (check4 == false)
                    {
                        Console.WriteLine("not correct\n");
                    }

                    else
                    {
                        if (choise == 1)
                        {
                            student.form =FormOfEdu.fullTime;
                        }

                        else if (choise == 0)
                        {
                            student.form =FormOfEdu.halfTime;
                        }

                        else
                        {
                            Console.WriteLine("not correct, will be set default option");
                            student.form = FormOfEdu.fullTime;
                        }

                    }
                    list.Add(student);
                }

                min *= 2;

                foreach (var student in list)
                {
                    if(student.Income<min)
                    {
                        placesForDormitory.Push(student);
                    }
                }

                List<Student> sortedList = list.OrderBy(x => x.AverageMark).ToList();

                foreach (var student in list)
                {
                    if(student.Income>min)
                    {
                        placesForDormitory.Push(student);
                    }
                }

                Console.WriteLine("--------------------------------------------------------");

                foreach (var student in placesForDormitory)
                {
                    Console.WriteLine();
                    Console.WriteLine("fio - " + student.FIO);
                    Console.WriteLine("group - " + student.Group);
                    Console.WriteLine("average mark - " + student.AverageMark);
                    Console.WriteLine("income - " + student.Income);
                    Console.WriteLine("pol - " + student.pol);
                    Console.WriteLine("form - " + student.form);
                }
                
            }

            else
            {
                Console.WriteLine("not correct");
            
            }

            Console.ReadLine();
        }
    }
}
