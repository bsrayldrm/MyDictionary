using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> Exam = new MyDictionary<string, int>();
            Exam.Add("Tarih neti:", 22);
            Exam.Add("Vatandaşlık neti:", 12);
            Exam.Add("Matematik neti:", 28);

            Exam.GetExam();
        }
    }
}
