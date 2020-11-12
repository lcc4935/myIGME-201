using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Web;

namespace TriviaApp
{
    class TriviaResult
    {
        public string category;
        public string type;
        public string difficulty;
        public string question;
        public string correct_answer;
        public List<string> incorrect_answers;
    }
    class Trivia
    {
        public int response_code;
        public List<TriviaResult> results;
    }


    class Program
    {
        static void Main(string[] args)
        {
            string url = null;
            string s = null;

            HttpWebRequest request;
            HttpWebResponse response;
            StreamReader reader;

            url = "https://opentdb.com/api.php?amount=1";

            request = (HttpWebRequest)WebRequest.Create(url);
            response = (HttpWebResponse)request.GetResponse();
            reader = new StreamReader(response.GetResponseStream());
            s = reader.ReadToEnd();
            reader.Close();

            Trivia trivia = JsonConvert.DeserializeObject<Trivia>(s);

            trivia.results[0].question = HttpUtility.HtmlDecode(trivia.results[0].question);
            trivia.results[0].correct_answer = HttpUtility.HtmlDecode(trivia.results[0].correct_answer);

            for (int i = 0; i < trivia.results[0].incorrect_answers.Count; ++i)
            {
                trivia.results[0].incorrect_answers[i] = HttpUtility.HtmlDecode(trivia.results[0].incorrect_answers[i]);
            }


            int totalAnswers = 0;
            List<string> answers = new List<string>();

            //asking question
            Console.WriteLine(trivia.results[0].question);

            //adding incorrect answers to list
            for (int i = 0; i < trivia.results[0].incorrect_answers.Count; ++i)
            {
                answers.Add(trivia.results[0].incorrect_answers[i]);
                totalAnswers = i;
            }

            answers.Add("hello");


            //add correct answer
            totalAnswers = totalAnswers + 1;

            //generating random order
            Random rand = new Random();
            int num = rand.Next(0, totalAnswers);

            //adding to list
            answers[totalAnswers] = answers[num];
            answers[num] = (trivia.results[0].correct_answer);

            //printing out the answers
            for (int i = 0; i < answers.Count; ++i)
            {
                Console.WriteLine(answers[i]);
            }

            //adding extra line
            Console.WriteLine("\n");

            //guessing
            string guess = Console.ReadLine();

            //Were they right?
            if (guess == trivia.results[0].correct_answer)
            {
                //yes
                Console.WriteLine("Correct!");
            }
            else
            {
                //nope
                Console.WriteLine("Sorry, the answer was " + trivia.results[0].correct_answer);
            }



        }
    }
}
