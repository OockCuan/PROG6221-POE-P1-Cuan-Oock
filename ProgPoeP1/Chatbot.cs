using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;



namespace ProgPoeP1

{

    internal class Chatbot
    {
        private string name;
        public string Name { get { return name; } }

        //method containing greeting code
        public void greeting()
        {
            //Audio greeting in try catch block
            try
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = "greeting.wav";
                player.Play();
                
            } catch(Exception e) {
                Console.WriteLine("Couldn't play audio greeting");
            }

            //Header
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("    __  __ __  ____     ___  ____        _____   ___    __  __ __  ____   ____  ______  __ __      ____    ___   ______ \r\n   /  ]|  |  ||    \\   /  _]|    \\      / ___/  /  _]  /  ]|  |  ||    \\ |    ||      ||  |  |    |    \\  /   \\ |      |\r\n  /  / |  |  ||  o  ) /  [_ |  D  )    (   \\_  /  [_  /  / |  |  ||  D  ) |  | |      ||  |  |    |  o  )|     ||      |\r\n /  /  |  ~  ||     ||    _]|    /      \\__  ||    _]/  /  |  |  ||    /  |  | |_|  |_||  ~  |    |     ||  O  ||_|  |_|\r\n/   \\_ |___, ||  O  ||   [_ |    \\      /  \\ ||   [_/   \\_ |  :  ||    \\  |  |   |  |  |___, |    |  O  ||     |  |  |  \r\n\\     ||     ||     ||     ||  .  \\     \\    ||     \\     ||     ||  .  \\ |  |   |  |  |     |    |     ||     |  |  |  \r\n \\____||____/ |_____||_____||__|\\_|      \\___||_____|\\____| \\__,_||__|\\_||____|  |__|  |____/     |_____| \\___/   |__| ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(6000);
            //Asking for name.
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Hello, I am your cybersecurity chat bot. What's your name?");
            Console.ForegroundColor = ConsoleColor.White;

            string response = Console.ReadLine();
            if (response.Contains("My name is") | response.Contains("my name is"))
            {
                response = response.Remove(0, 11);
            }
            this.name = response;
            //Displaying greeting
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("--------------------------------------------------");
            Console.Write("~~~~~~~~~~~~~~~~~~~");
            Console.Write("Welcome " + this.name);
            Console.Write("~~~~~~~~~~~~~~~~~~~ \n");
            Console.WriteLine("--------------------------------------------------");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White; 

            //Final text for greeting
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("How can I help you today? (type stop at any point to end the program)\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        //Method that sees what keywords are in user questions and returns a response key
        public string keyWords(string text)
        {
            string key = "A";

            if (text.Contains("phish") | text.Contains("Phish"))
            {
                //if asked about phishing vs vishing vs pharming
                if (text.Contains("vish") | text.Contains("Vish") | text.Contains("pharm") | text.Contains("Pharm"))
                {
                    key = "G";
                }
                else
                {
                    key = "B";
                }
            }
            //Checking for key for all phrases using the word safe
            else if (text.Contains("safe") | text.Contains("Safety"))
            {
                //safe browsing
                if (text.Contains("brows") | text.Contains("Brows"))
                {
                    key = "C";
                }
                //internet safety
                else if (text.Contains("internet") | text.Contains("Internet"))
                {
                    key = "D";
                }
                //defaults to password safety
                else
                {
                    key = "M";
                }

            }
            //default browsing
            else if (text.Contains("brows") | text.Contains("Brows"))
            {
                key = "F";
            }
            //passwords
            else if (text.Contains("Password") | text.Contains("password"))
            {
                key = "H";
            }
            //vishing
            else if (text.Contains("vish") | text.Contains("Vishing"))
            {
                if (text.Contains("pharm") | text.Contains("Pharming"))
                    { key = "G"; }
                else {
                    key = "I"; }
            }
            //pharming
            else if (text.Contains("pharm") | text.Contains("Pharming"))
            {
                key = "J";
            }
            //generic questions
            else if (text.Contains("how are you") | text.Contains("How are you"))
            {
                key = "K";
            }
            else if (text.Contains("your purpose"))
            {
                key = "L";
            }
            else if (text.Contains("ask you about") | text.Contains("ask about"))
            {
                key = "M";
            }
            else if (text.Contains("Privacy") | text.Contains("privacy"))
            {
                key = "N";
            }
            else if (text.Contains("Scam") | text.Contains("scam"))
            {
                key = "O";
            }

            return key;
        }

        //Method that identifies what question words are used in the user input to better structure the answer
        public string questionWords(string text)
        {
            string key = "what";
            if (text.Contains("tip") | text.Contains("Tip"))
            {
                key = "tip";
            }
            else if (text.Contains("what") | text.Contains("What"))
            {
                key = "what";
            }


            return key;
        }

        
    }
}

