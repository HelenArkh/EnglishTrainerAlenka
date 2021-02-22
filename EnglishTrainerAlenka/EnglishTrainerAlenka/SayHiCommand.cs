using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishTrainerAlenka
{
    public class SayHiCommand : AbstractCommand, IChatTextCommand
    {
        public SayHiCommand()
        {
            CommandText = "/saymehi";
        }

        public string ReturnText()
        {
            return "привет";
        }
    }
}
