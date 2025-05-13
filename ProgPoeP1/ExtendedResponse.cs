using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgPoeP1
{
    internal class ExtendedResponse : Response
    {
        //Method that answers when users are still confused
        public string checkConfusion(string keyWord)
        {
            //default response
            string response = "I'm not sure how to respond to that, I apologize.";
            //Dictionary contianing all responses
            var cResponses = new Dictionary<string, string>
            { {"A","I'm not sure how to respond to that, I apologize." },
            //phishing
            {"B","Let me try and explain a little better; phishing is essentially a scam where someone pretends to be someone they are not. They trick you by" +
                    "making you think you are talking to someone legitimate. This scam happens through email" },
            //safety
            {"C","Companies can store data like your ID or pin, safety in the cybersecuirty sense means knowing what scams looks like to avoid you " +
                    "accidentally giving this information away." },
            //Internet safety
            {"D","Companies can store data like your ID or pin, safety in the cybersecuirty sense means knowing what scams looks like to avoid you " +
                    "accidentally giving this information away." },
            //Browsing safety
            {"F","Companies can store data like your ID or pin, safety in the cybersecuirty sense means knowing what scams looks like to avoid you " +
                    "accidentally giving this information away."},
            //Phishing vs vishing vs pharming
            {"G","I'll try and explain differently, simply put, these scams all try and deceive you. Phising deceives through fake emails, vishing is done through scam" +
                    " telephone calls and pharming is done through fake websites that look legitimate." },
            //Password
            {"H","Think of passwords like a key to unlock your house, only you and your loved ones should be able to access it so you'd want a lock" +
            "that isn't easy to pick and you wouldn't give the key to just anyonw" },
            //Vishing
            {"I","I'll rephrase, vishing is where someone tries to steal your data or money by pretending they are someone trustworthy. This happens over a phone call" },
            //Pharming
            {"J","I'll try and explain a different way. Pharming is where a hacker will create a website that looks like the website of something trustworthy (like a bank or " +
            "shopping platform). This is so people will log in with theri credentials so that they can steal it." },
            //Scam
            {"N","Let me explain it more plainly. Digital scams are just like any other kind of scam, someone tries to trick you for money, power or other reasons, " +
            "just through something digital" },
            //Privacy
            {"O","More simply put, privacy is just your ability to keep your personal things personal" }
            };

            if (cResponses.ContainsKey(keyWord))
            {
                response = cResponses[keyWord];
            }
            return response;
        }
        //Method to see what was spoken about before
        public string recall(ArrayList allKeyWords, string activeKeyWord)
        {
            string recallString = "";
            //looping through arraylist of all past topics
            foreach (string keyWord in allKeyWords)
            {
                //recall if spoken about scams
                if (keyWord.Equals("O") && (activeKeyWord.Equals("B") || activeKeyWord.Equals("J") || activeKeyWord.Equals("I")))
                {
                    recallString = "This is a scam like we've spoken about before.";
                }
                //recall if spoken about password security
                else if (keyWord.Equals("H") && (activeKeyWord.Equals("C") || activeKeyWord.Equals("D") || activeKeyWord.Equals("F")))
                {
                    recallString = "This relates to our previous topic of password safety.";
                }
                //recall if spoken about privacy
                else if (keyWord.Equals("N") && activeKeyWord.Equals("O"))
                {
                    recallString = "Since we've spoken about privacy before, you should know that most scams aim to collect you private data.";
                }

            }
            return recallString;
        }
    }
}
