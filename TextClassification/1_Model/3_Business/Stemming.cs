using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextClassification._1_Model._3_Business
{
    internal class Stemming
    {

        //This stemming algorithm is known as the Porter Stemming Algorithm, i am not inventing it merely implementing it

        //note: this adaptation does not work as intended as it has 6 steps, which i could not implement.
            /*the originial used a source which allowed for editing suffixes, checking for consonants and the like,
             * however, that method/class/framework was not included and i wouldn't know nor have time to implement it myself
             * therefore i will keep it here, but not use it.
            */ 

        public string Process(string source) 
        {
            return PerformStep1(source);
            
        }


        public string PerformStep1(string source)
        {
            if (source.EndsWith('s'))
            {
                if (source.EndsWith("sses") || source.EndsWith("ies"))
                {
                    source =source.Substring(0, source.Length-2);
                }
                else if (source.Length-2 != 's')
                {
                    source = source.Substring(0, source.Length - 1);
                }
            }

            if (source.EndsWith("eed"))
            {
                source = source.Substring(0, source.Length - 3);

            }
            else
            {
                if (source.EndsWith("ed"))
                {
                    source = source.Substring(0, source.Length - 2);
                }
                else if (source.EndsWith("ing"))
                {
                    source = source.Substring(0, source.Length - 3);
                }

            }
        

            return source;
        }


    }
}
