using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrTDD
{
    public class TDD
    {
        public string Short(string text)
        { 
            int len = text.Length;
            string min_word = "";
            string[] words = text.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                if (word.Length < len)
                {
                    len = word.Length;
                    min_word = word;
                }
            }
            return min_word;
        }

        public int WordCount(string text)
        {
            int count = 0;
            string[] words = text.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words)
            {
                count++;
            }
            return count;
        }

        public int CharCount(string text)
        {
            return text.Length;
        }

        public string NineChar(string text)
        {
            if (text.Length >= 9)
            {
                return text[8].ToString();
            }
            return null;
        }

        public int NumberCount(string text)
        {
            int count = 0;
            foreach (char c in text)
            {
                if (Char.IsNumber(c))
                {
                    count++;
                }
            }
            return count;
        }

        public int TwinNumber(string text)
        {
            int max_count = 0;
            int temp = 0;

            foreach (char c in text)
            {
                if (!Char.IsDigit(c))
                {
                    temp = 0;
                    continue;
                }

                temp++;

                if (temp > max_count) { max_count = temp; }
            }
            return max_count;
        }

        public int AmCount(string text)
        {
            if (string.IsNullOrEmpty(text)) { return 0; }

            int count = 0;
            int amIndex = text.IndexOf("ам");

            while (amIndex != -1)
            {
                count++;
                amIndex = text.IndexOf("ам", amIndex + 1);
            }

            return count;
        }
    }
}
