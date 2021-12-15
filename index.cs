    using System;
    using System.Collections.Generic;
     
    namespace Coding.Exercise
    {
        public static class SpoilerHelper
        {
            private static string[] _forbiddenWords;
        
        
            public static void Display(string sentence)
            {
                if(IsAllowed(sentence)){
                    Console.WriteLine(sentence);
                } else {
                    Console.WriteLine("*Spoiler*");
                }
            }
     
            private static bool IsAllowed(string sentence)
            {
                string[] words = sentence.Split(new char[]{',',' '});
                foreach(var w in words)
                {
                    if(Array.IndexOf(_forbiddenWords,w) >= 0)
                    {
                        return false;
                    } 
                }
                return true;
             }
              
             public static void SetForbiddenWords(List<string> forbiddenWords)
             {
                _forbiddenWords = forbiddenWords.ToArray();          
             }
        }
    }