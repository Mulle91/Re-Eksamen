using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Quiz_Game_2._0
{
    class Program
    {
        //En lille velkomst
        public static void Welcome()
        {
            Console.WriteLine("Hej med dig");
            Console.WriteLine("Vil du spille med mig?");
            Console.WriteLine("1: Ja 2: Nej");
        }
        static void Main(string[] args)
        {
            /* Mine while loops parametre */
            bool game = true;
            bool beginGame = true;
            string answerBox = "Skriv dit svar her: ";
            string rightAnswer = "Det var måske for nemt!";
            string wrongAnswer = "HVAD!?! hvorfor svarede du ikke rigtigt";
            bool wrongAnswerLoop = true;

            //Arrayets længde
            int arrayLenght = 4;

            //Mine classes med dens indhold
            Question firstQuestion = new Question();
            firstQuestion.questionText = "Hvad blev resultatet mellem Danmark og Irland i fodbold?";
            firstQuestion.answers = "1: 1-0, 2: 3-0, 3: 5-1, 4: 3-2";

            Question secondQuestion = new Question();
            secondQuestion.questionText = "Hvad hedder den nyeste Xbox?";
            secondQuestion.answers = "1: Xbox one, 2: Xbox X, 3: Xbox 360, 4: Xbox One S";

            Question thirdQuestion = new Question();
            thirdQuestion.questionText = "Hvilket spilfirma står bag spilserien Assassin's Creed?";
            thirdQuestion.answers = "1: EA, 2: IO Interactive, 3: Nintendo, 4: Ubisoft";

            Question fourthQuestion = new Question();
            fourthQuestion.questionText = "Hvem har sloganet NEVER SETTLE?";
            fourthQuestion.answers = "1: One Plus, 2: Samsung, 3: Apple, 4: Google";

            //Array over mine spørgsmål
            string[] questions = new string[arrayLenght];
            questions[0] = firstQuestion.questionText;
            questions[1] = secondQuestion.questionText;
            questions[2] = thirdQuestion.questionText;
            questions[3] = fourthQuestion.questionText;

            //Array over svarene til min spørgsmål
            string[] answers = new string[arrayLenght];
            answers[0] = firstQuestion.answers;
            answers[1] = secondQuestion.answers;
            answers[2] = thirdQuestion.answers;
            answers[3] = fourthQuestion.answers;

            //Det overordnede loop
            while (game)
            {
                //Loopet der starter spillet
                //tager fra velkomst til efter dit svar
                while (beginGame)
                {
                    //Clear Console
                    Console.Clear();
                    //Kalder Funktionen Velkommen
                    Welcome();
                    //Skriver beskeden "Skriv dit svar her: "
                    Console.Write(answerBox);

                    //Et nyt try catch så du ikke kan skrive forkert
                    try
                    {
                        //Laver string til int
                        int startAnswer = int.Parse(Console.ReadLine().ToLower().Trim());

                        //Hvis startAnswer == 1 køre den bare videre
                        if (startAnswer == 1)
                        {
                            //Hvad der så sker når man skriver 1
                            Console.WriteLine("Så lad os spille!!!");
                            Thread.Sleep(1000);
                            beginGame = false;
                        }
                        else if (startAnswer == 2)
                        {
                            Console.WriteLine("Øhh hvorfor startede du???");
                            Thread.Sleep(1000);
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Det er ikke en mulighed");
                            Thread.Sleep(1000);
                        }
                    }
                    //Catch hvis det du har svaret ikke er mulighed
                    catch
                    {
                        Console.WriteLine("Det er ikke en mulighed");
                        Thread.Sleep(1000);
                    }
                }
                //Loop for det først spørgsmål hvis man svare forkert så hopper den bare tilbage til samme spørgsmål
                while (wrongAnswerLoop)
                {
                    Console.Clear();
                    Console.WriteLine(questions[0]);
                    Console.WriteLine(answers[0]);
                    Console.Write(answerBox);

                    try
                    {

                        int firstAnswer = int.Parse(Console.ReadLine().ToLower().Trim());

                        if (firstAnswer == 3)
                        {
                            Console.WriteLine(rightAnswer);
                            Thread.Sleep(1500);
                            wrongAnswerLoop = false;
                        }
                        else
                        {
                            Console.WriteLine(wrongAnswer);
                            Thread.Sleep(1500);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Det er ikke en mulighed");
                        Thread.Sleep(1500);
                    }
                }
                //Loop for det andet spørgsmål hvis man svare forkert så hopper den bare tilbage til samme spørgsmål
                wrongAnswerLoop = true;
                while (wrongAnswerLoop)
                {
                    Console.Clear();
                    Console.WriteLine(questions[1]);
                    Console.WriteLine(answers[1]);
                    Console.Write(answerBox);

                    try
                    {
                        int secondAnswer = int.Parse(Console.ReadLine().ToLower().Trim());

                        if (secondAnswer == 2)
                        {
                            Console.WriteLine(rightAnswer);
                            Thread.Sleep(1000);
                            wrongAnswerLoop = false;
                        }
                        else
                        {
                            Console.WriteLine(wrongAnswer);
                            Thread.Sleep(1000);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Det er ikke mulighed");
                        Thread.Sleep(1000);
                    }
                }
                //Loop for det tredje spørgsmål hvis man svare forkert så hopper den bare tilbage til samme spørgsmål
                wrongAnswerLoop = true;
                while (wrongAnswerLoop)
                {
                    Console.Clear();
                    Console.WriteLine(questions[2]);
                    Console.WriteLine(answers[2]);
                    Console.Write(answerBox);

                    try
                    {
                        int thirdAnswer = int.Parse(Console.ReadLine().ToLower().Trim());

                        if (thirdAnswer == 4)
                        {
                            Console.WriteLine(rightAnswer);
                            Thread.Sleep(1000);
                            wrongAnswerLoop = false;
                        }
                        else
                        {
                            Console.WriteLine(wrongAnswer);
                            Thread.Sleep(1000);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Det er ikke en mulighed");
                        Thread.Sleep(1000);
                    }
                }
                //Loop for det fjerde spørgsmål hvis man svare forkert så hopper den bare tilbage til samme spørgsmål
                wrongAnswerLoop = true;
                while (wrongAnswerLoop)
                {
                    Console.Clear();
                    Console.WriteLine(questions[3]);
                    Console.WriteLine(answers[3]);
                    Console.Write(answerBox);

                    try
                    {
                        int fourthAnswer = int.Parse(Console.ReadLine().ToLower().Trim());

                        if (fourthAnswer == 1)
                        {
                            Console.WriteLine(rightAnswer);
                            Console.WriteLine("Spillet er nu slut. Tak for denne gang");
                            Console.ReadKey();
                            return;
                        }
                        else
                        {
                            Console.WriteLine(wrongAnswer);
                            Thread.Sleep(1000);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Det er ikke mulighed");
                        Thread.Sleep(1000);
                    }
                }
            }
        }
        /// <summary>
        /// Dette er alle min class som der lavet så jeg bare kan kalde dem og give dem den value de skal have
        /// </summary>
        public class Question
        {
            public string questionText;
            public string answers;
        }
    }
}