using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radhika.Assignment1
{
    
        class Program
        {
            static void Main()

            {
                const int correctAnswer = 10;
                int[] answers = new int[correctAnswer];
                answers[0] = 4;
                answers[1] = 2;
                answers[2] = 3;
                answers[3] = 2;
                answers[4] = 1;
                answers[5] = 4;
                answers[6] = 1;
                answers[7] = 2;
                answers[8] = 2;
                answers[9] = 1;


                int[] inputanswers = new int[correctAnswer];


                Console.WriteLine("Mathematics Test for 4th Grade");
                Console.WriteLine("Chosse the Correct option for Below Questions");
                Console.WriteLine("1. About how many people did God inspire to write the Bible? ");
                Console.WriteLine("1.30           2.35            3. 45          4.40");
                inputanswers[0] = int.Parse(Console.ReadLine());
                //Boolean condition1 = true;
                Console.WriteLine("2. Which book of the Bible tells about the beginnings of the Church? ");
                Console.WriteLine("1.Romans           2.Acts           3. James       4.Hebrews");
                inputanswers[1] = int.Parse(Console.ReadLine());
                Console.WriteLine("3. What is the shortest chapter in the Bible? ");
                Console.WriteLine("1.James          2.Psalm 119         3. Psalm 117         4.Psalm 121");
                inputanswers[2] = int.Parse(Console.ReadLine());
                Console.WriteLine("4. What is the longest chapter in the Bible");
                Console.WriteLine("1.Psalm 121           2.Psalm 119          3. Psalm 117        4.Romans");
                inputanswers[3] = int.Parse(Console.ReadLine());
                Console.WriteLine("5. Who lived longer than any other person??");
                Console.WriteLine("1.Methuselah         2.Peter           3. Noah        4.John");
                inputanswers[4] = int.Parse(Console.ReadLine());
                Console.WriteLine("6. Who was Abraham's nephew? ");
                Console.WriteLine("1.Peter           2.Jona            3. Issac         4.Lot");
                inputanswers[5] = int.Parse(Console.ReadLine());
                Console.WriteLine("7. Who was Abraham's wife? ");
                Console.WriteLine("1.Sarah          2.Hager          3. Ruth         4.Naomi");
                inputanswers[6] = int.Parse(Console.ReadLine());
                Console.WriteLine("8. What descendant of Ruth became king of Israel? ");
                Console.WriteLine("1.Samuel           2.David           3. Eli         4.Gideon");
                inputanswers[7] = int.Parse(Console.ReadLine());
                Console.WriteLine("9. Who was the first king of Israel? ");
                Console.WriteLine("1. David          2.Saul             3. Goliath          4.Joab");
                inputanswers[8] = int.Parse(Console.ReadLine());
                Console.WriteLine("10. Who was the captain of David's army?");
                Console.WriteLine("1. Joab          2.Saul             3. Goliath          4.David");
                inputanswers[9] = int.Parse(Console.ReadLine());

                int totalscore = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (answers[i] == inputanswers[i])
                    {
                        totalscore = totalscore + 1;

                    }

                }
                Console.WriteLine("You scored {0} out of 10", totalscore);
                if (totalscore == 10)
                {
                    Console.WriteLine("yay You did it ");
                    Console.WriteLine("you scored  A++");
                }
                else if (totalscore == 9)
                {
                    Console.WriteLine("you are almost there ");
                    Console.WriteLine("you scored  A+");
                }
                else if (totalscore == 8)
                {
                    Console.WriteLine("you scored  A");

                }
                else if (totalscore == 7)
                {
                    Console.WriteLine("you scored  B+");

                }
                else if (totalscore == 6)
                {
                    Console.WriteLine("you scored  B");
                    Console.ReadLine();
                }
                else if (totalscore == 5)
                {
                    Console.WriteLine("you scored  B---");
                }
                else
                {
                    Console.WriteLine("you scored  D--");

                }

                Console.WriteLine("Your Answer               Correct Answer");
                for (int x = 0; x < 10; x++)
                {

                    int j = (answers[x]);
                    int k = inputanswers[x];
                    Console.WriteLine("{0}                         {1}", j, k);

                }


                Console.ReadLine();
            }
        }
    }
