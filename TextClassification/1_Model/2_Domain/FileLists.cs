using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextClassification.Domain
{
    public class FileLists
    {
        private List<string> _a;
        private List<string> _b;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public FileLists(){
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        }

        public void SetA(List<string> a)
        {
            _a = a;
        }

        public void SetB(List<string> b)
        {
            _b = b;
        }

        public List<string> GetA()
        {
            return _a;
        }

        public List<string> GetB()
        {
            return _b;
        }

        public List<string> GetBoth()
        {
            return _a.Concat(_b).ToList(); ;
        }

    }
}
