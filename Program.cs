using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STUDENT_MARK;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 nam = new Class1();
            nam.name = "suresh";
            nam.Rollno = 215114619;
            nam.Standard = "VI";
            nam.Dateofbirth = "11.10.2003";
            Console.WriteLine(nam);

            mark[] subj = new mark[3];
            mark subj1 = new mark();
            subj1.Subjectname = "tamil";
            subj1.Subjectmark = 74;
            mark subj2 = new mark();
            subj2.Subjectname = "english";
            subj2.Subjectmark = 78;
            mark subj3 = new mark();
            subj3.Subjectname = "java";
            subj3.Subjectmark = 88;

           
            mark s1 = new mark();
            subj[0] = subj1;
            subj[1] = subj2;
            subj[2] = subj3;
            mark s2 = new mark();
            float total = s2.totalmark(subj1.Subjectmark, subj2.Subjectmark, subj3.Subjectmark);
            float average = s2.averagemark(subj1.Subjectmark, subj2.Subjectmark, subj3.Subjectmark);
            for(int i=0;i<subj.Length;i++)
            {
                Console.WriteLine(subj[i]);
            }
            Console.WriteLine("\n Total mark:"+total +"\n The Average mark is:"+average);
        }
    }
}