using System;
using System.Collections.Generic;
using System.Text;

namespace CountingCharacters_Studio
{
    class Letters
    {
        private Dictionary<char, int> count = new Dictionary<char, int>();
        private char[] charArr;

        public Letters(string str)
        {
            this.charArr = str.ToCharArray();
            this.count = Count();
        }

        // Get count of letters
        private Dictionary<char, int> Count()
        {
            foreach(char c in this.charArr)
            {
                if(Char.IsLetter(c))
                {
                    if(this.count.ContainsKey(c))
                    {
                        this.count[c] += 1;
                    } else
                    {
                        this.count[c] = 1;
                    }
                }
            }
            return count;
        }

        // Display count of letters
        public void Print()
        {
            foreach (KeyValuePair<char, int> l in this.count)
            {
                Console.WriteLine($"{l.Key}\t{l.Value}");
            }
        }

    }
}
