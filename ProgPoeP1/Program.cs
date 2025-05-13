
using System.Collections;

namespace ProgPoeP1
{

    internal class Program

    {
        static void Main(string[] args)
        {
            //Declaration of different variables
            Chatbot chat = new Chatbot();
            Response responder = new Response();
            ExtendedResponse eResponder = new ExtendedResponse();
            ArrayList topics = new ArrayList();

            //initiating greeting
            chat.greeting();
            string response = Console.ReadLine(); ;


            //Continuing the application until the user types in "stop"
            while (!(response.Equals("Stop") | response.Equals("stop")))
            {
                
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Magenta;
                //responder checking if there are sentiments in response
                Console.WriteLine(responder.sentimentCheck(response));
                //Using various methods to identify key words in user input and return a response
                Console.WriteLine(responder.respond(chat.keyWords(response), chat.questionWords(response), chat.Name));
                //keeping list of topics to recall 
                topics.Add(chat.keyWords(response));

                Console.WriteLine(eResponder.recall(topics, chat.keyWords(response)));

                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n************************\n");

                //temporary response to see if user is still confused
                string tempResponse = Console.ReadLine();

                //using keywords to identify confusion
                if ((tempResponse.Contains("Explain") || tempResponse.Contains("explain") || tempResponse.Contains("confu") ||
                    tempResponse.Contains("Confu") || tempResponse.Contains("detail") || tempResponse.Contains("Detail")) &&
                    chat.keyWords(tempResponse).Equals("A"))
                {

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\n" + eResponder.checkConfusion(chat.keyWords(response)) + "\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n************************\n");
                    response = Console.ReadLine();
                }
                //rerunning the loop if user is not confused
                else { response = tempResponse;
                    
                }

                
            
                
                

            }
        }
    }
}
