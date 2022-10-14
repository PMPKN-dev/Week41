using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextClassification.Controller;
using TextClassification.Domain;

namespace TextClassification._1_Model._1_Controller
{
    internal class DistanceCalc
    {
        /*
         * Formula for two dimensional Vector distanc ecalculation:
         * 
         * D = SQRT( (x1-y1)SQD + (x2-y2)SQD )
         * 
         * 
         * Decutively, formula for vector of size k =
         * D = SQRT( (x1-y1)SQD + (x2-y2)SQD + ... + (xk-yk)SQD )
         * 
         * order of working:
         * Addition of each part of the sequence in the bags of words
         * squaring the sum
         * addition of all the sums
         * finding the square root of the final sum
         */


        public double getDistance(BagOfWords total, ) 
        {
            


            return 0;
        }
    }
}
