
namespace ProgPoeP1
{

    internal class Program

    {
        static void Main(string[] args)
        {
            Chatbot chat = new Chatbot();
            chat.greeting();
            string response = Console.ReadLine();



            while (!(response.Equals("Stop") | response.Equals("stop")))
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(chat.keyWords(response));
                Console.WriteLine(chat.questionWords(response));
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n************************\n");
                response = Console.ReadLine();
                

            }


            //Console.ReadKey();
        }
    }
}
