using System;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("총학생수를 입력하세요");
            int totalStudentNumber = int.Parse(Console.ReadLine());

            double[] KoreanScores = new double[totalStudentNumber];
            double[] EnglishScores = new double[totalStudentNumber];
            double[] MathScores = new double[totalStudentNumber];

            int studentIndex = 0;
            while (studentIndex < totalStudentNumber)
            {
                Console.Write(studentIndex + 1);
                Console.WriteLine("번째 학생의 국어 성적을 입력하세요 ");
                KoreanScores[studentIndex] = double.Parse(Console.ReadLine());

                Console.Write(studentIndex + 1);
                Console.WriteLine("번째 학생의 영어 성적을 입력하세요 ");
                EnglishScores[studentIndex] = double.Parse((Console.ReadLine()));

                Console.Write(studentIndex + 1);
                Console.WriteLine("번째 학생의 수학 성적을 입력하세요 ");
                MathScores[studentIndex] = double.Parse((Console.ReadLine()));

                studentIndex = studentIndex + 1;
            }

            studentIndex = 0;
            while (studentIndex < totalStudentNumber)
            {
                double totalScore = KoreanScores[studentIndex] + EnglishScores[studentIndex] + MathScores[studentIndex];

                Console.Write(studentIndex + 1);
                Console.Write("번째 학생의 총점:");
                Console.WriteLine(totalScore);

                Console.Write(studentIndex + 1);
                Console.Write("번째 학생의 평균:");
                Console.WriteLine(totalScore / 3);

                studentIndex = studentIndex + 1;
            }
        }
    }
}