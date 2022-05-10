using System;
namespace ProjectX.Logic.Exceptions
{
    public class LectorNotFoundException : DatabaseException
    {
        public LectorNotFoundException(string message) : base(message)
        {

        }
    }
}
