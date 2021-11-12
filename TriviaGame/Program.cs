using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            bool gameOver = false;

            //Welcome user to game
            Console.WriteLine("Welcome to the Trivia Game!");
            Task.Delay(2000).Wait();

            //Clear console
            Console.Clear();

            //Ask user to start game
            Console.WriteLine("Press any key to get your first question!");
            Console.ReadKey();

            //Clear Console
            Console.Clear();

            List<Question> questionList = new List<Question>();
            LoadQuestions(ref questionList);

            while (gameOver == false)
            {
                //display random questions
                Random randomQuestion = new Random();
                foreach (var q in questionList.OrderBy(q => randomQuestion.Next(questionList.Count)))
                {

                    //ask user for answer to question
                    Console.WriteLine(q.Questions);
                    var answer = Console.ReadLine();
                    //check if user input is correct
                    if (q.isCorrect(answer) && score<=20)
                    {
                        //console display correct answer
                        Console.WriteLine("Good job! You got it right!");
                        score++;
                        Console.ReadKey();
                        Console.Clear();
                    }
                    //console display incorrect question
                    //end game
                    else
                    {
                        score--;
                        Console.WriteLine($"Good guess! The answer was {q.Answer}");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    if (score == 20)
                    {
                        Console.WriteLine("You win!");
                        Console.WriteLine($"Your final score is {score}");
                        Console.WriteLine("Press any key to exit");
                        Console.ReadKey();
                    }
                    else if (score == -5)
                    {
                        Console.WriteLine("Game over! You lose!");
                        Console.WriteLine($"Your final score is {score}");
                        Console.WriteLine("Press any key to exit");
                        Console.ReadKey();
                        gameOver = true;
                        break;
                    }
                }
            }
        }
        private static void LoadQuestions(ref List<Question> questions)
        {
 
                Question question1 = new Question { Questions = "What is the capital of France?", Answer = "Paris" };
                questions.Add(question1);
                Question question2 = new Question { Questions = "What country is the national animal a unicorn?", Answer = "Scotland" };
                questions.Add(question2);
                Question question3 = new Question { Questions = "What shape is used for stop signs?", Answer = "Octagon" };
                questions.Add(question3);
                Question question4 = new Question { Questions = "How many languages are written left to right?", Answer = "12" };
                questions.Add(question4);
                Question question5 = new Question { Questions = "What is the name of the biggest technology company in south Korea?", Answer = "Samsung" };
                questions.Add(question5);
                Question question6 = new Question { Questions = "What animal is on the porsche logo?", Answer = "Horse" };
                questions.Add(question6);
                Question question7 = new Question { Questions = "What animal is commonly called 'mans best friend'?", Answer = "Dog" };
                questions.Add(question7);
                Question question8 = new Question { Questions = "Is cereal soup?", Answer = "Yes" };
                questions.Add(question8);
                Question question9 = new Question { Questions = "Are tacos sandwiches", Answer = "Yes" };
                questions.Add(question9);
                Question question10 = new Question { Questions = "Is guacamole good?", Answer = "Yes" };
                questions.Add(question10);
                Question question11 = new Question { Questions = "Does everyone hate bob", Answer = "Yes" };
                questions.Add(question11);
                Question question12 = new Question { Questions = "What is the only edible food that never goes bad", Answer = "Honey" };
                questions.Add(question12);
                Question question13 = new Question { Questions = "What year did Waystar get its name?", Answer = "2017" };
                questions.Add(question13);
                Question question14 = new Question { Questions = "How many colors are in the rainbow?", Answer = "7" };
                questions.Add(question14);
                Question question15 = new Question { Questions = "What state is Area 51 in?", Answer = "Nevada" };
                questions.Add(question15);
                Question question16 = new Question { Questions = "When will this pandemic end?", Answer = "Never" };
                questions.Add(question16);
                Question question17 = new Question { Questions = "How many hearts does an octopus have?", Answer = "3" };
                questions.Add(question17);
                Question question18 = new Question { Questions = "How many legs does a spider have?", Answer = "8" };
                questions.Add(question18);
                Question question19 = new Question { Questions = "Are dogs hypoallergenic?", Answer = "No" };
                questions.Add(question19);
                Question question20 = new Question { Questions = "What is the opposite of matter", Answer = "Antimatter" };
                questions.Add(question20);
                Question question21 = new Question { Questions = "What never stop crying?", Answer = "Babies" };
                questions.Add(question21);
                Question question22 = new Question { Questions = "What was the first state?", Answer = "Delaware" };
                questions.Add(question22);
                Question question23 = new Question { Questions = "What planet has the most gravity?", Answer = "Jupiter" };
                questions.Add(question23);
                Question question24 = new Question { Questions = "How many neck bones does a giraffe have?", Answer = "7" };
                questions.Add(question24);
                Question question25 = new Question { Questions = "Can you get bolts for airplanes from home depot?", Answer = "No" };
                questions.Add(question25);
                Question question26 = new Question { Questions = "What comes down but never goes up?", Answer = "Rain" };
                questions.Add(question26);
                Question question27 = new Question { Questions = "Where is waystar headquartered?", Answer = "Louisville" };
                questions.Add(question27);
                Question question28 = new Question { Questions = "Are dogs good boys/girls?", Answer = "Yes" };
                questions.Add(question28);
                Question question29 = new Question { Questions = "Are cats evil?", Answer = "Yes" };
                questions.Add(question29);
                Question question30 = new Question { Questions = "Is bread the bearded dragon a goblin in disguise?", Answer = "Yes" };
                questions.Add(question30);
        }
    }
}
