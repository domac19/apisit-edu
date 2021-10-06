using System;

namespace exeptionExample
{
    public class PhotoException : Exception
    {
        public PhotoException(string messageException) :base(messageException)
        {

        }
    }
}
