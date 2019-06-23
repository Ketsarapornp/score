using System;

namespace Score
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*string score;
            score = Console.ReadLine();
            int x = int.Parse(score);*/
            Console.WriteLine("เกศราภรณ์ พึ่งภักดิ์ ");
            Console.WriteLine("Plz input score ");
            int score= Convert.ToInt32(Console.ReadLine());
            if (score >= 80 && score <= 100)
            {
                Console.WriteLine("A");
            }else if(score >= 70 && score <= 79)
            {
                Console.WriteLine("B");
            }
            else if (score >= 60 && score <= 69)
            {
                Console.WriteLine("C");
            }
            else if (score >= 50 && score <= 59)
            {
                Console.WriteLine("D");
            }
            else if (score >= 0 && score <= 49)
            {
                Console.WriteLine("F");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
