using System;
namespace ProjectX.Logic.Exceptions
{
    public class DatabaseException : ApplicationCoreException
    {
        public DatabaseException(string message) : base(message)
        {

        }
    }
}
