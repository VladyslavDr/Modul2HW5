using System;

public class BusinessException : Exception
{
    public BusinessException(string messege)
        : base(messege)
    {
    }
}
