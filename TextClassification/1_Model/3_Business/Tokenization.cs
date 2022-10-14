using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextClassification._1_Model._3_Business;

namespace TextClassification.Business
{

    public class Tokenization
    {
        private const int SMALLESTWORDLENGTH = 3;
        List<string> words;

        public static List<string> Tokenize(string originalText)
        {
            List<string>words = new List<string>();
            char[] separators = {
                ' ', '-', '.',
                '?', ':', '!',
                '"', '—', ';',
                ',', '?', '“',
                '…', '(', ')',
                '”', 
                '\n'
            }; 

            string [] tokens = originalText.Split(separators);

            

            
            foreach (string token in tokens)
            {
                Stemming stemming = new Stemming();

                //string tempToken = stemming.Process(token);
                string tempToken = token;

                if (IsAShortWord(tempToken))
                {
                    // skip
                }
                else {

                    string word = tempToken;
                    if (word.EndsWith('s') && word.Contains('\''))
                    {
                        word = word.Substring(0, word.Length -2);
                    }

                    //string cleanWord = RemovePunctuation(token);
                    //cleanWord = cleanWord.ToLower();
                    string cleanWord = word.ToLower();
                    words.Add(cleanWord);

                }
            }
            return words;
        }
        public static bool IsAShortWord(string token)
        {
            if (token.Length < SMALLESTWORDLENGTH)
            {
                return true;
            }
            return false;
        }

        public static string RemovePunctuation(string token)
        {
            token = token.Trim();
            char[] punctuations = {'-','.', ',', '"', '?','\n'};
            
            for (int i = 0; i < punctuations.Length; i++)
            {
                string ch = punctuations[i].ToString();
                if (token.StartsWith(ch))
                {
                    return token.Substring(1);
                }
                else if (token.EndsWith(ch))
                {
                    return token.Substring(0, token.Length - 1);
                }
            }
            return token;
        }

        
    }
}
