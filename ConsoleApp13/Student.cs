using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public enum Sex
    {
        male,female
    }

    public enum FormOfEdu
    {
        fullTime,halfTime
    }

    public class Student
    {
        public string FIO { get; set; }
        public string Group { get; set; }
        public double AverageMark { get; set; }
        public double Income { get; set; }
        public Sex pol;
        public FormOfEdu form;

    }
}
