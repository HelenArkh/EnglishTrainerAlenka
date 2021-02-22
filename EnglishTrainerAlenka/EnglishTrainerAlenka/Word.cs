using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishTrainerAlenka
{
    public class Word
    {
        string rusWord;
        string engWord;
        string category;

        public Word(string rusWord, string engWord, string category)
        {
            this.rusWord = rusWord;
            this.engWord = engWord;
            this.category = category;
        }
    }
}
