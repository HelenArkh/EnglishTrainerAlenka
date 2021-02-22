using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishTrainerAlenka
{
    public interface IChatCommand
    {
        bool CheckMessage(string message);
    }
}
