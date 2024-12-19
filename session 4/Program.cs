using System;
using System.Numerics;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace session_4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Loop Statments


            //Console.WriteLine("1 T");
            //Console.WriteLine("2 T");
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);

            //for (int i = 1; i <= 10; i++)
            //{
            //Console.WriteLine($"{i} T");
            //}
            #endregion

            #region For - Foreach

            ////for loop


            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //Console.WriteLine(Numbers[i]);
            //}


            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //Numbers[i] += 10;
            //Console.WriteLine(Numbers[i]);
            //}




            //for (int i = 0; i < Numbers.Length; i++)

            //{

            ////Numbers[i] += 10;
            //if (Numbers[i] == 5)
            //{
            //break;  ----> stop on 5 (1 to 4) ..............   continue -----> skip 5 (1 to 10 without 5 )
            //}
            //Console.WriteLine(Numbers[i] + 10);

            //}








            ////foreach
            // Class implienemt interface IEnummrable
            //foreach (int Number in Numbers)
            //{
            //Console.WriteLine(Number);
            //}



            //foreach (int Number in Numbers)
            //{
            //Console.WriteLine(Number + 10);
            //}
            #endregion

            #region While - Do While


            // do while


            //int Number;
            //do
            //{

            //    Console.WriteLine("Enter Even Number ");
            //    Number = int.Parse(Console.ReadLine());

            //Flag = int.TryParse(Console.ReadLine(), out Number);
            //while (Number % 2 == 1 || !Flag) ;


            //}

            //while (Number % 2 == 1);

            //Console.WriteLine($"{Number} is Even");








            //while






            //int Number = 3;
            //bool Flag = false;
            //while (Number % 2 == 1 | | !Flag)
            //{
            //Console.WriteLine("Enter Even Number ");
            //Flag = int.TryParse(Console.ReadLine(), out Number);

            //}

            //Console.WriteLine($"{Number} is Even");


            #endregion

            #region String


            // Class => Reference Type
            // immutable Data Type [Value can not be Changed]
            // Array Of Chars
            //AHMED


            //string Name;

            //Mame = new string("Ahmed");

            //Name = "Ahmed";


            //string Name01 = "Ahmed";
            //string Name02 = "Ahmed";


            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name01 HC : {Name01.GetHashCode()}");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name02 HC : {Name02.GetHashCode()}");


            ////////// same hashcode (load string)




            //string Name01 = "Ahmed";
            //string Name02 = "Ali";

            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name01 HC : {Name01.GetHashCode()}");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name02 HC : {Name02.GetHashCode()}");

            //Name02 = Name01;
            //Console.WriteLine("    **Name02 = Name01 ");
            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name01 HC : {Name01.GetHashCode()}");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name02 HC : {Name02.GetHashCode()}");




            //Name01 = "Mostafa"
            //Console.WriteLine(" ********** Name01 = Mostafa *********** ");
            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name01 HC : {Name01.GetHashCode()}");------- ahmen
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name02 HC : {Name02.GetHashCode()}"); ------- mostafa




            //string Message = "Hello";

            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());

            //Message += " Route";

            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());

            #endregion

            #region StringBuilder
            //StringBuilder Message;

            //Message = new StringBuilder("Hello");

            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());

            ////Message += " Route";
            //Message.Append(" Route");
            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());

            ///// same hashcode
            ///

            #region StringBuilder Methods
            //StringBuilder Message = new StringBuilder("Welcome");

            //Message.Append(" To Route");
            //Message.AppendLine(" Mostafa");
            //Message.Append("Hany");

            //Message.Remove(0, 7);

            //Message.Insert(0, "Hello");
            //Console.WriteLine(Messae);

            //Console.WriteLine();
            //int Age = 10;
            //string Name = "Ali";
            //Message.AppendFormat("Name : {0} , Age : {1}", Name, Age);

            //Console.WriteLine(Message);


            //Message.AppendJoin("/", "Mostafa", "Hany", "Mohammed"f2);
            //Console.WriteLine(Message);
            #endregion

            #endregion

            #region Array 1 D



            //int[] Numbers = { 1, 2, 3 };

            //Numbers[2]; // 3

            //2 * 4 = 8 + Base Address => 0X0008

            //int[] Numbers = new int[3] [ 1, 2, 3 };
            //int[] Numbers = new int[] { 1, 2, 3 };
            //int[] Numbers = { 1, 2, 3 };


            //Numbers[0] = 1;
            //Numbers[1] = 2;
            //Numbers[2] = 3;

            //int[] Numbers = new int[3];


            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //Numbers[i] = i + 1;
            //}





            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //Console.WriteLine(Numbers[i]);
            //}



            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //Console.WriteLine($"Enter Element Number {i + 1}");
            //Numbers[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine(Numbers.Length);
            //Console.WriteLine(Numbers.Rank);
            #endregion

            #region 2D Array
            //int[,] Marks = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 10, 20, 30, 40, 50 }, { 100, 200, 300, 400, 500 } };


            //Console.WriteLine(Marks.Length);
            //Console.WriteLine(Marks.Rank);
            //Console.WriteLine(Marks.GetLength(0)); ROWS
            //Console.WriteLine(Marks.GetLength(1));COLUMNS 


            //for (int i = 0; i < Marks.GetLength(0); ///i++)
            //{
            //Console.WriteLine($"Enter Grades Student ({i + 1})");
            //for (int k = 0; k < Marks.GetLength(1); k++)
            //{
            //bool Flag;
            //Console.WriteLine($"Enter Grade Subject [{k + 1}]");
            ////Marks[i,k] = int.Parse(Console. ReadLine());
            //Flag = int.TryParse(Console.ReadLine(), out Marks[i, k]);

            //if (Flag && Marks[i, k] >= 0)
            //{
            //k++;
            //}

            //k = Flag && Marks[i, k] >= 0 ?++k : k;
            //}
            //}




            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //Console.WriteLine($"Grades Student ({i + 1})");
            //for (int k = 0; k < Marks.GetLength(1); k++)
            //{
            //Console.Write($"Grade Subject [{k + 1}] :");
            //Console.WriteLine(Marks[i, k]);
            //}
            //}

            #region 2D Array one loop
            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //Console.WriteLine(Marks[i / Marks.GetLength(1), i % Marks.GetLength(1)])
            //}   
            #endregion

            #endregion

            #region Judged Array


            //int[][] Number = new int[3][];

            //Number[0] = new int[3] { 1, 2, 3 };
            //Number[1] = new int[2] { 4, 5 };
            //Number[2] = new int[1] { 6 };

            //for (int i = 0; i < Number.Length; i++)
            //{

                //for (int j = 0; j < Number[i].Length; j++)
                //{
                    //Console.WriteLine(Number[i][j]);


                //}



            //}

            #endregion
        }
    }
}
