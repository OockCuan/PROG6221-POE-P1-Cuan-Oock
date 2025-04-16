
namespace ProgPoeP1
{

    internal class Program

    {
        static void Main(string[] args)
        {
            Chatbot chat = new Chatbot();
            chat.greeting();
            string response = Console.ReadLine();


            //Continuing the application until the user types in "stop"
            while (!(response.Equals("Stop") | response.Equals("stop")))
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Magenta;

                //Using three methods to identify key words in user input and return a response
                Console.WriteLine(chat.respond(chat.keyWords(response), chat.questionWords(response)));
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n************************\n");
                response = Console.ReadLine();
                

            }


            //Console.ReadKey();
        }
    }
}
