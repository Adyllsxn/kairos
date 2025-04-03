namespace Kairos.Domain.Abstractions.Validation;
public class DomainExceptionValidation : Exception
{
    public DomainExceptionValidation(string message) : base(message){}
    public static void When (bool condition, string message)
    {
        if(condition)
        {
            throw new DomainExceptionValidation(message);
        }
    }
    
}
