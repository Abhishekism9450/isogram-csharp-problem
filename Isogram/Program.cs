using System;
using System.Collections.Generic;

namespace Isogram
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }
        public static bool isogram(string text)
        {
            HashSet<char> myset = new HashSet<char>();

            for(int c = 0; c < text.Length; c++)
            {
                if((text[c]==' ') || (text[c]== '-'))
                {
                    continue;
                }
                if(myset.Contains(text[c])){
                    return false;
                }
                else
                {
                    myset.Add(text[c]);
                }
            }
            return true;
        }
    }
}
