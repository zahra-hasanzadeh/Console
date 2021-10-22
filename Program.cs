using System;

namespace q
{
    class Program
    {
        static void Main(string[] args)
        {
            // for (var i = 1; i <= 5; i++)
            // {
            //     for (int p = 5; p > i; p--)
            //     {
            //         Console.Write("");
            //     }

            //     for (int j = 1; j <=i; j++)
            //     {
            //         Console.Write("* ");
            //     }

            //     Console.WriteLine();
            // }





            // System.Console.WriteLine("enter num1:");
            // int a = Convert.ToInt32(Console.ReadLine());


            // System.Console.WriteLine("enter num2:");
            // int b = Convert.ToInt32(Console.ReadLine());

            // System.Console.WriteLine("enter num2:+ * / -");
            // string c = Console.ReadLine();


            // switch (c)
            // {
            //     case "+":
            //         System.Console.WriteLine(a+"+"+b+"=" +(a+b));

            //         break;
            //     case "-":
            //         System.Console.WriteLine(a+"-"+b+"=" + (a-b));

            //         break;
            //     case "/":
            //         System.Console.WriteLine(a+"/"+b+"=" + (a / b));

            //         break;
            //     case "*":
            //         System.Console.WriteLine(a+"X"+b+"=" + (a * b));

            //         break;
            //     default:
            //         break;
            // }
            // try
            // {
            //     System.Console.WriteLine("enter num2:");
            //     int a = Convert.ToInt32(Console.ReadLine());
            // }
            // catch (System.Exception ex)
            // {
            //     error
            // }
            // for (int i = 1; i <= 10; i++)
            // {
            //     for (int j = 1; j <= 10; j++)
            //     {
            //         if (i%2==0) {
            //             System.Console.Write("----");

            //         }else{
            //         if (i*j<10){
            //        System.Console.Write(i*j+"  |");
            //        }else
            //        {
            //            System.Console.Write(i*j+" |");
            //        }}
            //     }
            //     Console.WriteLine( );
            // }
            // int[,] a = new int[11, 11];
            // // a[5, 6] = 11;
            // for (int i = 1; i <= 10; i++)
            // {
            //     for (int j = 1; j <= 10; j++)
            //     {
            //         System.Console.Write(i*j + "\t");
            //     }
            //     System.Console.WriteLine();
            // }

            string[,] a = new string[5, 2];
            int[] b = new int[5];



            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.WriteLine("enter name:");
                    a[i, j] = Console.ReadLine();

                    Console.WriteLine("enter avg:");
                    a[i, j + 1] = Console.ReadLine();
                    b[i] = Convert.ToInt32(a[i, j + 1]);


                }
            }
            for (int k = 0; k < 5; k++)
            {
                for (int m = 0; m < 2; m++)
                {
                    System.Console.Write(a[k, m] + "\t");
                }
                System.Console.WriteLine();
            }


            int max = b[0];

            foreach (var item in b)
            {
                if (max < item)
                {

                    max = item;

                }

            }
            System.Console.WriteLine(max);
           

        }
    }
}
