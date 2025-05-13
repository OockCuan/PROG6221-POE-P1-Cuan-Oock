using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgPoeP1
{
    internal class Response
    {
        public Response() { }

        
        
        //method used to see what sentiments the person has and respond accoringly 
        public string sentimentCheck(string input) {
            //Dictoray to store responses
            var sResponses = new Dictionary<int, string> 
            { 
                {0, "" },
                {1, "I can see why you would be worried.\n" },
                {2, "Your frustrations are completely valid.\n" },
                {3,  "Curiosity about these kinds of topics is always great!! You need to learn more to protect yourself.\n"}
            };
            int response = 0;
            if (input.Contains("Worried") || input.Contains("worried")) {
                response = 1;
            }
            else if (input.Contains("Frustrated") || input.Contains("frustrated")) {
                response = 2;
            }
            else if (input.Contains("curious") || input.Contains("Curious"))
            {
                response = 3;
            }

            return sResponses[response];
        }

        //Method that holds all the preprogrammed responses for the chat bot
        public string respond(string keyword, string questionWord, string name)
        {
            //Item 0:Question word "what"
            //Item 1:Alternative response to "what"
            //Item 2:Tip

            var fResponses = new Dictionary<string, string[] > { 
                //Default answer
                {"A", 
                    ["I don't really have a response for that, could you rephrase or maybe change the spelling? I might also have not been trained on this topic",
                    "I don't really have a response for that, could you rephrase or maybe change the spelling? I might also have not been trained on this topic",
                    "I don't really have a response for that, could you rephrase or maybe change the spelling? I might also have not been trained on this topic"]} ,
                //Phishing
                {"B",  
                    ["Phishing is an email scam where someone will send you an email pretending to be a reputable source, like yor bank.",
                    //Random
                    "Phishing is essentially a scam where someone pretends to be someone they are not. They trick you by " +
                    "making you think you are talking to someone legitimate. This scam happens through email", 
                    //Tip
                    "Here's some tips to avoid phsihing\n" +
                    "-Always check where emails come from and make sure they have official domains \n" +
                    "-Do not click on unknown links sent through email, rather go to the website (if its trusted) through your browser"
                ]},
                //Safety
                {"C", ["Safety in the cybersecurity sense is all about making sure your data is protected.",
                    //Random
                    "Being safe means using practices that keeps you and your personal data protected", 
                    //Tip
                    "Being safe while browsing on the internet can be tricky, heres some tips to help with that \n" +
                            "-Don't go to piracy websites as they could give your device malware/viruses\n" +
                            "-Don't connect to free internet in public, only use trusted networks."] },
                //Internet Safety
                {"D", ["Internet safety is all about making sure your data is protected online.",
                    //Random
                    "Being safe on the internet means using practices that keeps you and your personal data protected",
                    //Tip
                    "Being safe on the internet can be tricky, heres some tips to help with that \n" +
                        "-Don't go to piracy websites as they could give your device malware/viruses\n" +
                        "-Don't connect to free internet in public, only use trusted networks."]},
                //Browsing Safety
                {"F", ["Browsing safety is all about making sure your data is protected online.",
                    //Random
                    "Being safe while browsing means using practices that keeps you and your personal data protected",
                    //Tip
                    "Being safe while browsing on the internet can be tricky, heres some tips to help with that \n" +
                        "-Don't go to piracy websites as they could give your device malware/viruses\n" +
                        "-Don't connect to free internet in public, only use trusted networks."] },
                //Phishing vs vishing vs pharming
                {"G", ["Many people confuse phishing, vishing and pharming. Let me help you understand the difference.\n" +
                        "phishing is an email scam, vishing is done through telephone calls and pharming redirects people to fake websites that look real.",
                    //Random
                    "There are a lot of similarites between vishing, phishing and pharming. The difference is the medium through which they're done. " +
                    "phishing is an email scam, vishing is done through telephone calls and pharming redirects people to fake websites that look real.",
                    //Tip
                    "Here's some tips to help you avoid these scams" +
                            "-Don't trust calls from supposedly credible sources like banks or ISPs, rather call them through trusted numbers \n" +
                            "-Don't give personal information over calls, emails or through websites without proper authentication\n" +
                            "-Do not click on untrusted email links"
                    ] },
                //Password
                {"H", ["Password safety is very important, this means developing complex passwords to make it harder for hackers to access your accounts.",
                //Random
                "Password safety is the practice of creating strong passwords and making sure that you don't share them to protect your data",
                    //Tip
                    "Here's some tips on making a good password\n" +
                            "-Make sure your password is at least 8 characters and contains special characters \n" +
                            "-Include numbers, upper and lowercase letters in your passweords"] },
                //Vishing
                {"I", ["Vishing is a kind of scam where a scammer will call you pretending to be someone, or a company, you would trust.",
                //Random
                "Vishing is when someone deceivingly pretends to be someone trustworthy in a telephone scam",
                    //Tip
                        "Here's some tips to help you avoid vishing\n" +
                            "-Don't trust calls from supposedly credible sources like banks or ISPs, rather call them through trusted numbers \n" +
                            "-Don't give personal information over calls"] },
                //Pharming
                {"J", ["Pharming is a common scam where, while browsing, a scammer will redirect you to a fake website that looks credible.",
                //Random
                "Pharming is when a victim gets redirected to a website that looks legitimate (such as a bank website) but is really a scam website.",
                    //Tip   
                    "Here's some tips to help you avoid pharming\n" +
                            "-Always make sure the websites you visit are secure (using https or have a lock icon) \n" +
                            "-Keep an up to date antivirus that protects you while browsing"] },
                //Privacy
                {"N",["Privacy is a right of an internet user to keep their data to themselves and trusted sources",
                //Random
                "Internet privacy is the excersing of keeping your personal data to yourself and trusted sources on the internet, for your safety",
                    //Tip   
                    "Here's some tips to help maintian privacy\n" +
                            "-Educate yourself about scams that try to steal your data \n" +
                            "-Keep an up to date antivirus that protects you while browsing"] },
                //Scam
                {"O",["Cyber scams are like regular scams except they are commited through a digital medium, such as email or telephone",
                //Random
                "Scams are acts,usually committed by hackers, to try and deceive and manipulate you for some nefarious purpose.",
                    //Tip   
                    "Here's some tips to help you avoid scams" +
                            "-Don't trust calls from supposedly credible sources like banks or ISPs, rather call them through trusted numbers \n" +
                            "-Don't give personal information over calls, emails or through websites without proper authentication\n" +
                            "-Do not click on untrusted email links"] }
            };
            //default response that asks user to change input
            
            string response = "I don't really have a response for that, could you rephrase or maybe change the spelling? I might also have not been trained on this topic";



            //All other response options
            if (fResponses.ContainsKey(keyword))
            {
                //Creating random response for questions
                Random rng = new Random();
                int responseNum = rng.Next(2);
                if (questionWord.Equals("what"))
                {

                    response = fResponses[keyword][responseNum];
                }

                //Responding with tip
                else if (questionWord.Equals("tip"))
                {
                    if (fResponses[keyword].Length >= 2)
                    {
                        response = fResponses[keyword][2];
                    }
                    else
                    {
                        response = fResponses[keyword][responseNum];
                    }
                }
            } //Answers for generic questions
            else if (keyword.Equals("K"))
            {
                response = "I'm doing great " + name + ", ready to answer your cyber security questions!";
                
            }
            else if (keyword.Equals("L"))
            {
                response = "My purpose is to help people learn more about everything cybersecurity. You can ask me your cyber security questions.";
                
            }
            else if (keyword.Equals("M"))
            {
                response = "I've been trained on types of cyber scams as well as internet and password safety, so you can ask about those.";
                
            }
             return response;

        }



    }
}
