using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishTrainerAlenka
{
    public abstract class AbstractCommand : IChatCommand
    {
        public string CommandText;

        public bool CheckMessage(string message)
        {
            return CommandText == message;
        }
    }
}
