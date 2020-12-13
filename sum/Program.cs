using System;

using System.Collections.Generic;

namespace Assignment4
{
    class Program
    {

       


        static void Main(string[] args)
        {
            Stack<int> rec = new Stack<int>();

            Console.WriteLine("Welcome to  Employee Management System");
            Console.WriteLine(" Enter How Many Employee ID want to Store ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter" + num + " Employee Id");

            int count = 0;
            for (int i = 0; i < num; i++)
            {
                count++;
                Console.WriteLine("Enter" + (count) + "Employee Id");
                int empid = Convert.ToInt32(Console.ReadLine());

                rec.Push(empid);




            }
            Console.WriteLine("Employee Id Stored in stack Successfully");


            Console.WriteLine("**********Menu***************");

            Console.WriteLine("1-Display  All Stack Element\n 2- Sort Element List \n3- Reverse Element List\n 4-Search Element\n 5- POP Element\n6- Exit");


            Console.WriteLine("Enter Your Choice");

            int ch = Convert.ToInt32(Console.ReadLine());


            switch (ch)
            {

                case 1:

                    int j = 0;
                    foreach (object emp_id in rec)
                    {
                        j++;
                        Console.WriteLine(j + "Employee empid=" + emp_id);
                    }


                    break;


                case 2:
                    int[] eid = rec.ToArray();
                    int len = eid.Length;

                    int m, n;
                    for (m = 0; m < len; m++)
                    {
                        for (n = m + 1; n < len; n++)
                        {
                            if (eid[n] < eid[m])
                            {
                                int tmp = eid[m];
                                eid[m] = eid[n];
                                eid[n] = tmp;
                            }
                        }
                    }


                    Console.WriteLine(" Sorted Employee Id List");
                    for (int i = 0; i < len; i++)
                    {
                        Console.WriteLine(eid[i]);
                    }


                    break;



                case 3:

                    int[] eid1 = rec.ToArray();
                    int len1 = eid1.Length;

                    int m1, n1;
                    for (m1 = 0; m1 < len1; m1++)
                    {
                        for (n1 = m1 + 1; n1 < len1; n1++)
                        {
                            if (eid1[n1] < eid1[m1])
                            {
                                int tmp = eid1[m1];
                                eid1[m1] = eid1[n1];
                                eid1[n1] = tmp;
                            }
                        }
                    }


                    Console.WriteLine(" Sorted Employee Id List");
                    Console.WriteLine(" Total Length of array" + len1);

                    for (int i = len1 - 1; i >= 0; i--)
                    {
                        Console.WriteLine(eid1[i]);
                    }


                    break;

                






            }


        }
    }
}
