namespace Flights.Dtos
{
    // Changed public class to public record
    // public records have different syntax where parameter brackets
    // are used instead
    public record NewPassengerDto(
        string Email,
        string FirstName,
        string LastName,
        bool Gender);
    
}
