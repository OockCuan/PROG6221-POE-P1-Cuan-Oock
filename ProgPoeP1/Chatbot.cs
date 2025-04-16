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
            Console.WriteLine("How can I help you today?\n");
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
                key = "I";
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

            return key;
        }

        //Method that identifies what question words are used in the user input to better structure the answer
        public string questionWords(string text)
        {
            string key = "Default";
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

        //Method that holds all the preprogrammed responses for the chat bot
        public string respond(string keyword, string questionWord)
        {
            //default response that asks user to change input
            string response = "Sorry, I didn't quite understand that, could you rephrase or maybe change the spelling? I might also have not been trained on this topic";

            //Answers for generic questions
            if (keyword.Equals("K")) {
                response = "I'm doing great " + this.name + ", ready to answer your cyber security questions!";
                return response;
            } 
            else if (keyword.Equals("L")) {
                response = "My purpose is to help people learn more about everything cybersecurity. You can ask me your cyber security questions.";
                return response;
            }
            else if (keyword.Equals("M"))
            {
                response = "I've been trained on types of cyber scams as well as internet and password safety, so you can ask about those.";
                return response;
            }
            
            //All other response options
            
                switch (keyword)
                {
                //phishing responses
                    case "B":
                    if (questionWord.Equals("tip"))
                    {
                        response = "Here's some tips to avoid phsihing\n" +
                            "-Always check where emails come from and make sure they have official domains \n" +
                            "-Do not click on unknown links sent through email, rather go to the website (if its trusted) through your browser";
                    }
                    else
                    {
                        response = "Phishing is an email scam where someone will send you an email pretending to be a reputable source, like yor bank..";
                    }
                    break;

                //safety responses
                case "C":

                    response = "Being safe while browsing on the internet can be tricky, heres some tips to help with that \n" +
                            "-Don't go to piracy websites as they could give your device malware/viruses\n" +
                            "-Don't connect to free internet in public, only use trusted networks.";
                        break;
                //internet safety
                    case "D":
                        response = "Being safe on the internet can be tricky, heres some tips to help with that \n" +
                            "-Don't go to piracy websites as they could give your device malware/viruses\n" +
                            "-Don't connect to free internet in public, only use trusted networks.";
                        break;
                //browsing safety
                    case "F":
                        response = "Being safe while browsing on the internet can be tricky, heres some tips to help with that \n" +
                            "-Don't go to piracy websites as they could give your device malware/viruses\n" +
                            "-Don't connect to free internet in public, only use trusted networks.";
                        break;
                //phishing vs vishing vs pharming
                    case "G":
                        response = "Many people confuse phishing, vishing and pharming. Let me help you understand the difference.\n" +
                            "phishing is an email scam, vishing is done through telephone calls and pharming redirects people to fake websites that look real.";
                        break;
                //password safety
                    case "H":
                    if (questionWord.Equals("tip"))
                    {
                        response = "Here's some tips on making a good password\n" +
                            "-Make sure your password is at least 8 characters and contains special characters \n" +
                            "-Include numbers, upper and lowercase letters in your passweords";
                    }
                    else
                    {
                        response = "Password safety is very important, this means developing complex passwords to make it harder for hackers to access your accounts.";
                    }
                    break;
                //vishing
                case "I":
                    if (questionWord.Equals("tip"))
                    {
                        response = "Here's some tips to help you avoid vishing\n" +
                            "-Don't trust calls from supposedly credible sources like banks or ISPs, rather call them through trusted numbers \n" +
                            "-Don't give personal information over calls";
                    }
                    else
                    {
                        response = "Vishing is a kind of scam where a scammer will call you pretending to be someone, or a company, you would trust.";
                    }
                    break;
                //pharming
                case "J":
                    if (questionWord.Equals("tip")) 
                    {
                        response = "Here's some tips to help you avoid pharming\n" +
                            "-Always make sure the websites you visit are secure (using https or have a lock icon) \n" +
                            "-Keep an up to date antivirus that protects you while browsing";
                    }
                    else
                    {
                        response = "Pharming is a common scam where, while browsing, a scammer will redirect you to a fake website that looks credible.";
                    }
                        break;



            }
            return response;
        }
    }
}

