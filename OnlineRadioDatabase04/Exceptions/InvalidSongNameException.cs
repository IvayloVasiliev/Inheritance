using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRadioDatabase04.Exceptions
{
    public class InvalidSongNameException : InvalidSongException
    {
        public InvalidSongNameException(string message = "Song name should be between 3 and 30 symbols.")
            : base(message)
        {
        }
    }
}
