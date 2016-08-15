using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_sentences
{
    class Program
    {
        static void Main()
        {
            string word = "in"; //Console.ReadLine();
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";//Console.ReadLine();
            string text2 = text;
            int dot = text.IndexOf('.');
            int indexOfWord = 0;
            int start = 0;
            while (text2.Length>0)
            {
                string sentence = text2.Remove(dot + 1);
                indexOfWord = sentence.IndexOf(word, start);
                if (indexOfWord >= 0)
                {
                    while (indexOfWord >= 0)
                    {
                        indexOfWord = sentence.IndexOf(word, start);
                        if (indexOfWord > 0 && sentence[indexOfWord - 1] == ' ' && sentence[indexOfWord + word.Length] == ' ')
                        {
                            Console.WriteLine(sentence);
                            break;
                        }
                        else
                        {
                            start = indexOfWord + word.Length;
                        }
                    }
                }
                else
                {
                    text2 = text2.Substring(start);
                }
            }
        }
    }
}
