using System;


namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Harry Potter", "J.K Rowling", 400);
            Book bookTwo = new Book("Lord of the Rings", "Tolkein", 700);

            Student studentOne = new Student("Malic Patterson", "Fitness", 3.2);
            Student studentTwo = new Student("Nicholas Patterson", "Software Development", 3.5);

            int[] result = Reverse();
            Console.WriteLine(result);

        }

        static int[] Reverse()
        {
            int[] myArr = { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 };

            int[] myNewArr = new int[5];

            myNewArr[0] = 1;
            myNewArr[1] = 2;
            myNewArr[2] = 3;
            myNewArr[3] = 4;
            myNewArr[4] = 5;

            foreach (int num in myNewArr)
            {
                Console.WriteLine(num);
            }




            Console.WriteLine(myArr);

            foreach (int num in myArr)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Reversed Array...");

            for (int i = myArr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"{myArr[i]}");
            }



            return myArr;
        }

    }
}