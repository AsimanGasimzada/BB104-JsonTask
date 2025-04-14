namespace _14._04_BB104.Exceptions;

public class AlreadyExistException : Exception
{
    public AlreadyExistException(string message = "Already exist") : base(message)
    {
    }
}
