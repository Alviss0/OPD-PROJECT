using System;
namespace ProjectX.Logic.Exceptions
{
    public class StudentNotFoundException : DatabaseException
    {
        public StudentNotFoundException(string message) : base(message)
        {

        }
    }
}
