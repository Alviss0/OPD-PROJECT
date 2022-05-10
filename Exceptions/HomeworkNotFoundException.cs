using System;
namespace ProjectX.Logic.Exceptions
{
    public class HomeworkNotFoundException : DatabaseException
    {
        public HomeworkNotFoundException(string message) : base(message)
        {

        }
    }
}
