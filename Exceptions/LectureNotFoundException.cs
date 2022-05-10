using System;
namespace ProjectX.Logic.Exceptions
{
    public class LectureNotFoundException : DatabaseException
    {
        public LectureNotFoundException(string message) : base(message)
        {

        }
    }
}
