using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishTrainerAlenka
{
    public class AddWordCommand : AbstractCommand, IChatTextCommand
    {
        Dictionary<string, string> words = new Dictionary<string, string>();
        public AddWordCommand()
        {
            CommandText = "/addword";
        }


        public void AddWordToDictionary(string word, string translation)
        {
            words.Add(word, translation);
        }

        public string ReturnText()
        {            
            return "Введите русское значение слова";
        }
    }
}
